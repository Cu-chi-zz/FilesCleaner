
namespace FilesCleaner
{
	partial class Main
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderButton = new System.Windows.Forms.Button();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.searchPaternTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressionLabel = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.folderButton.FlatAppearance.BorderSize = 4;
            this.folderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            this.folderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.folderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderButton.Location = new System.Drawing.Point(12, 12);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(476, 48);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Select folder to clean";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(13, 64);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(0, 13);
            this.folderPathLabel.TabIndex = 1;
            // 
            // cleanButton
            // 
            this.cleanButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.cleanButton.FlatAppearance.BorderSize = 4;
            this.cleanButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            this.cleanButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(221)))));
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanButton.Location = new System.Drawing.Point(12, 247);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(476, 48);
            this.cleanButton.TabIndex = 2;
            this.cleanButton.Text = "CLEAN";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // searchPaternTextBox
            // 
            this.searchPaternTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.searchPaternTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchPaternTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.searchPaternTextBox.Location = new System.Drawing.Point(448, 64);
            this.searchPaternTextBox.Name = "searchPaternTextBox";
            this.searchPaternTextBox.Size = new System.Drawing.Size(40, 13);
            this.searchPaternTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "search pattern:";
            // 
            // progressionLabel
            // 
            this.progressionLabel.AutoSize = true;
            this.progressionLabel.Location = new System.Drawing.Point(14, 229);
            this.progressionLabel.Name = "progressionLabel";
            this.progressionLabel.Size = new System.Drawing.Size(0, 13);
            this.progressionLabel.TabIndex = 6;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.richTextBox.Location = new System.Drawing.Point(12, 81);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(476, 145);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(500, 307);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.progressionLabel);
            this.Controls.Add(this.searchPaternTextBox);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Files Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button folderButton;
		private System.Windows.Forms.Label folderPathLabel;
		private System.Windows.Forms.Button cleanButton;
		private System.Windows.Forms.TextBox searchPaternTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label progressionLabel;
		private System.Windows.Forms.RichTextBox richTextBox;
	}
}

