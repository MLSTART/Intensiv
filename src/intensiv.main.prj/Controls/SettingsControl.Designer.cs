namespace Intensiv.Main
{
	partial class SettingsControl
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
			this._gbxSettings = new System.Windows.Forms.GroupBox();
			this._cmbDetectorType = new System.Windows.Forms.ComboBox();
			this._gbxSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// _gbxSettings
			// 
			this._gbxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gbxSettings.Controls.Add(this._cmbDetectorType);
			this._gbxSettings.Location = new System.Drawing.Point(0, 0);
			this._gbxSettings.Margin = new System.Windows.Forms.Padding(4);
			this._gbxSettings.Name = "_gbxSettings";
			this._gbxSettings.Padding = new System.Windows.Forms.Padding(4);
			this._gbxSettings.Size = new System.Drawing.Size(232, 565);
			this._gbxSettings.TabIndex = 0;
			this._gbxSettings.TabStop = false;
			this._gbxSettings.Text = "Настройки";
			// 
			// _cmbDetectorType
			// 
			this._cmbDetectorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbDetectorType.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cmbDetectorType.FormattingEnabled = true;
			this._cmbDetectorType.Location = new System.Drawing.Point(7, 35);
			this._cmbDetectorType.Name = "_cmbDetectorType";
			this._cmbDetectorType.Size = new System.Drawing.Size(218, 24);
			this._cmbDetectorType.TabIndex = 0;
			this._cmbDetectorType.SelectedIndexChanged += new System.EventHandler(this._cmbDetectorType_SelectedIndexChanged);
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this._gbxSettings);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(235, 568);
			this._gbxSettings.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox _gbxSettings;
		private System.Windows.Forms.ComboBox _cmbDetectorType;
	}
}
