namespace Intensiv.Main
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlSettings = new System.Windows.Forms.Panel();
			this._pnlLog = new System.Windows.Forms.Panel();
			this._pnlVideo = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _pnlSettings
			// 
			this._pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlSettings.Location = new System.Drawing.Point(746, 0);
			this._pnlSettings.Name = "_pnlSettings";
			this._pnlSettings.Size = new System.Drawing.Size(188, 454);
			this._pnlSettings.TabIndex = 0;
			// 
			// _pnlLog
			// 
			this._pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlLog.Location = new System.Drawing.Point(0, 459);
			this._pnlLog.Name = "_pnlLog";
			this._pnlLog.Size = new System.Drawing.Size(933, 140);
			this._pnlLog.TabIndex = 1;
			// 
			// _pnlVideo
			// 
			this._pnlVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlVideo.Location = new System.Drawing.Point(0, 0);
			this._pnlVideo.Name = "_pnlVideo";
			this._pnlVideo.Size = new System.Drawing.Size(741, 454);
			this._pnlVideo.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(934, 601);
			this.Controls.Add(this._pnlVideo);
			this.Controls.Add(this._pnlLog);
			this.Controls.Add(this._pnlSettings);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlSettings;
		private System.Windows.Forms.Panel _pnlLog;
		private System.Windows.Forms.Panel _pnlVideo;
	}
}

