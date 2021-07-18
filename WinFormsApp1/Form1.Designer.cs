
namespace WinFormsApp1
{
	partial class VerifyXMLtool
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileButton = new System.Windows.Forms.Button();
			this.FileName = new System.Windows.Forms.TextBox();
			this.verfyXML = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(468, 60);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(290, 77);
			this.openFileButton.TabIndex = 0;
			this.openFileButton.Text = "ファイル開く";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
			// 
			// FileName
			// 
			this.FileName.Enabled = false;
			this.FileName.Location = new System.Drawing.Point(41, 83);
			this.FileName.Name = "FileName";
			this.FileName.Size = new System.Drawing.Size(406, 23);
			this.FileName.TabIndex = 1;
			// 
			// verfyXML
			// 
			this.verfyXML.Location = new System.Drawing.Point(468, 201);
			this.verfyXML.Name = "verfyXML";
			this.verfyXML.Size = new System.Drawing.Size(289, 99);
			this.verfyXML.TabIndex = 2;
			this.verfyXML.Text = "検証";
			this.verfyXML.UseVisualStyleBackColor = true;
			this.verfyXML.Click += new System.EventHandler(this.verfyXML_Click);
			// 
			// VerifyXMLtool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.verfyXML);
			this.Controls.Add(this.FileName);
			this.Controls.Add(this.openFileButton);
			this.Name = "VerifyXMLtool";
			this.Text = "XML電子署名検証ツール";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.TextBox FileName;
		private System.Windows.Forms.Button verfyXML;
	}
}

