namespace Intensiv.Main
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._pnlVideoPlayer = new System.Windows.Forms.Panel();
			this._pnlSetting = new System.Windows.Forms.Panel();
			this._pnlLog = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _pnlVideoPlayer
			// 
			this._pnlVideoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._pnlVideoPlayer.Location = new System.Drawing.Point(12, 12);
			this._pnlVideoPlayer.Name = "_pnlVideoPlayer";
			this._pnlVideoPlayer.Size = new System.Drawing.Size(597, 401);
			this._pnlVideoPlayer.TabIndex = 0;
			// 
			// _pnlSetting
			// 
			this._pnlSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._pnlSetting.Location = new System.Drawing.Point(616, 12);
			this._pnlSetting.Name = "_pnlSetting";
			this._pnlSetting.Size = new System.Drawing.Size(145, 401);
			this._pnlSetting.TabIndex = 1;
			// 
			// _pnlLog
			// 
			this._pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._pnlLog.Location = new System.Drawing.Point(13, 420);
			this._pnlLog.Name = "_pnlLog";
			this._pnlLog.Size = new System.Drawing.Size(748, 100);
			this._pnlLog.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 530);
			this.Controls.Add(this._pnlLog);
			this.Controls.Add(this._pnlSetting);
			this.Controls.Add(this._pnlVideoPlayer);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _pnlVideoPlayer;
		private System.Windows.Forms.Panel _pnlSetting;
		private System.Windows.Forms.Panel _pnlLog;
	}
}

