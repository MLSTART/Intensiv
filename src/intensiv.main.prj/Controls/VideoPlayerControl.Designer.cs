﻿namespace Intensiv.Main
{
	partial class VideoPlayerControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlImages = new System.Windows.Forms.Panel();
			this._picVideo = new System.Windows.Forms.PictureBox();
			this._pnlButControl = new System.Windows.Forms.Panel();
			this._btnPause = new System.Windows.Forms.Button();
			this._btnStop = new System.Windows.Forms.Button();
			this._btnOpenFolder = new System.Windows.Forms.Button();
			this._btnImageBack = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._btnImageNext = new System.Windows.Forms.Button();
			this._opnFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._opnFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._pnlImages.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._picVideo)).BeginInit();
			this._pnlButControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _pnlImages
			// 
			this._pnlImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlImages.Controls.Add(this._picVideo);
			this._pnlImages.Location = new System.Drawing.Point(0, 0);
			this._pnlImages.Name = "_pnlImages";
			this._pnlImages.Size = new System.Drawing.Size(741, 385);
			this._pnlImages.TabIndex = 0;
			// 
			// _picVideo
			// 
			this._picVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._picVideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this._picVideo.Location = new System.Drawing.Point(0, 0);
			this._picVideo.Name = "_picVideo";
			this._picVideo.Size = new System.Drawing.Size(741, 377);
			this._picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._picVideo.TabIndex = 0;
			this._picVideo.TabStop = false;
			// 
			// _pnlButControl
			// 
			this._pnlButControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlButControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this._pnlButControl.Controls.Add(this._btnPause);
			this._pnlButControl.Controls.Add(this._btnStop);
			this._pnlButControl.Controls.Add(this._btnOpenFolder);
			this._pnlButControl.Controls.Add(this._btnImageBack);
			this._pnlButControl.Controls.Add(this._btnStart);
			this._pnlButControl.Controls.Add(this._btnOpenFile);
			this._pnlButControl.Controls.Add(this._btnImageNext);
			this._pnlButControl.Location = new System.Drawing.Point(0, 377);
			this._pnlButControl.Name = "_pnlButControl";
			this._pnlButControl.Size = new System.Drawing.Size(741, 77);
			this._pnlButControl.TabIndex = 1;
			// 
			// _btnPause
			// 
			this._btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnPause.Location = new System.Drawing.Point(653, 30);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(75, 23);
			this._btnPause.TabIndex = 6;
			this._btnPause.Text = "Pause";
			this._btnPause.UseVisualStyleBackColor = true;
			// 
			// _btnStop
			// 
			this._btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnStop.Location = new System.Drawing.Point(572, 29);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(75, 23);
			this._btnStop.TabIndex = 5;
			this._btnStop.Text = "Stop";
			this._btnStop.UseVisualStyleBackColor = true;
			this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
			// 
			// _btnOpenFolder
			// 
			this._btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnOpenFolder.Location = new System.Drawing.Point(3, 43);
			this._btnOpenFolder.Name = "_btnOpenFolder";
			this._btnOpenFolder.Size = new System.Drawing.Size(144, 23);
			this._btnOpenFolder.TabIndex = 4;
			this._btnOpenFolder.Text = "Открыть папку";
			this._btnOpenFolder.UseVisualStyleBackColor = true;
			// 
			// _btnImageBack
			// 
			this._btnImageBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnImageBack.Location = new System.Drawing.Point(154, 30);
			this._btnImageBack.Name = "_btnImageBack";
			this._btnImageBack.Size = new System.Drawing.Size(75, 23);
			this._btnImageBack.TabIndex = 3;
			this._btnImageBack.Text = "<<";
			this._btnImageBack.UseVisualStyleBackColor = true;
			// 
			// _btnStart
			// 
			this._btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnStart.Location = new System.Drawing.Point(490, 29);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(75, 23);
			this._btnStart.TabIndex = 2;
			this._btnStart.Text = "Start";
			this._btnStart.UseVisualStyleBackColor = true;
			this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnOpenFile.Location = new System.Drawing.Point(3, 14);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(144, 23);
			this._btnOpenFile.TabIndex = 1;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// _btnImageNext
			// 
			this._btnImageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnImageNext.Location = new System.Drawing.Point(235, 30);
			this._btnImageNext.Name = "_btnImageNext";
			this._btnImageNext.Size = new System.Drawing.Size(75, 23);
			this._btnImageNext.TabIndex = 0;
			this._btnImageNext.Text = ">>";
			this._btnImageNext.UseVisualStyleBackColor = true;
			// 
			// _opnFileDialog
			// 
			this._opnFileDialog.FileName = "openFileDialog1";
			// 
			// VideoPlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this._pnlButControl);
			this.Controls.Add(this._pnlImages);
			this.Name = "VideoPlayerControl";
			this.Size = new System.Drawing.Size(741, 454);
			this._pnlImages.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._picVideo)).EndInit();
			this._pnlButControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlImages;
		private System.Windows.Forms.Panel _pnlButControl;
		private System.Windows.Forms.Button _btnPause;
		private System.Windows.Forms.Button _btnStop;
		private System.Windows.Forms.Button _btnOpenFolder;
		private System.Windows.Forms.Button _btnImageBack;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.Button _btnImageNext;
		private System.Windows.Forms.OpenFileDialog _opnFileDialog;
		private System.Windows.Forms.FolderBrowserDialog _opnFolderDialog;
		private System.Windows.Forms.PictureBox _picVideo;
	}
}
