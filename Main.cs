using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesCleaner
{
    public partial class Main : Form
    {
		private string folderPath = "";
		private bool waitingEnd = false;

        public Main()
        {
            InitializeComponent();
        }

		private void Main_Load(object sender, EventArgs e)
		{
			
		}

		private void folderButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderSelection = new FolderBrowserDialog();
			if (folderSelection.ShowDialog() == DialogResult.OK)
			{
				folderPath = folderSelection.SelectedPath;
			}

			folderPathLabel.Text = folderPath;
		}

		private void cleanButton_Click(object sender, EventArgs e)
		{
			if (waitingEnd)
			{
				MessageBox.Show($"You are currently performing an action, wait for it to be completed.", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			BackgroundWorker worker = new BackgroundWorker();
			worker.DoWork += new DoWorkEventHandler(FilesCleaner);
			worker.RunWorkerAsync();
		}

		private void FilesCleaner(object sender, EventArgs e)
		{
			if (Directory.Exists(folderPath))
			{
				string[] filesList;

				try
				{
					waitingEnd = true;
					filesList = Directory.GetFiles(folderPath, (searchPaternTextBox.Text != "" ? searchPaternTextBox.Text : "*"), SearchOption.AllDirectories);
				}
				catch (UnauthorizedAccessException)
				{
					MessageBox.Show($"Unauthorized access for {folderPath}", "UnauthorizedAccessException", MessageBoxButtons.OK, MessageBoxIcon.Error);
					waitingEnd = false;
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString(), ex.InnerException.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
					waitingEnd = false;
					return;
				}

				long totalFilesSize = GetTotalFilesSize(filesList);
				DialogResult confirmationMessageBox = MessageBox.Show($"You're about to delete: {filesList.Length} files ({BytesFormatted(totalFilesSize)})", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (confirmationMessageBox == DialogResult.Yes)
				{
					Invoke(new Action(() =>
					{
						long progression = 0L;
						richTextBox.ResetText();
						for (int i = 0; i < filesList.Length; i++)
						{
							try
							{
								FileInfo currentFile = new FileInfo(filesList[i]);
								progression += currentFile.Length;
								progressionLabel.Text = $"{BytesFormatted(progression)}/{BytesFormatted(totalFilesSize)}";
								progressionLabel.Refresh();
								currentFile.Delete();
								richTextBox.Text += (richTextBox.Text != "" ? "\n" : "") + "Deleted: " + currentFile.Name;
							}
							catch
							{
								richTextBox.Text += "\nCatched error at " + filesList[i];
								continue;
							}
						}
					}));
					
					waitingEnd = false;
				}
				else
				{
					waitingEnd = false;
					return;
				}
			}
			else
			{
				MessageBox.Show("Invalid folder path, check if the selected folder path exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private long GetTotalFilesSize(string[] files)
		{
			long totalSize = 0;
			foreach (string file in files)
			{
				FileInfo currentFile = new FileInfo(file);
				totalSize += currentFile.Length;
			}

			return totalSize;
		}

		private string BytesFormatted(long bytes)
		{
			double result = bytes / 1024d;
			if (result < 1000) return $"{Math.Round(bytes / 1024d, 2)}ko";
			else if (result < 1000000) return $"{Math.Round(bytes / 1024d / 1024d, 2)}mo";
			else if (result < 1000000000) return $"{Math.Round(bytes / 1024d / 1024d / 1024d, 2)}go";
			else return $"{Math.Round(bytes / 1024d / 1024d / 1024d / 1024d, 2)}to";
		}

		private void richTextBox_TextChanged(object sender, EventArgs e)
		{
			richTextBox.SelectionStart = richTextBox.Text.Length;
			richTextBox.ScrollToCaret();
		}
	}
}
