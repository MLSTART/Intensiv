﻿namespace Intensiv.Main
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
			this._cmbDetector = new System.Windows.Forms.ComboBox();
			this._gbxSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// _gbxSettings
			// 
			this._gbxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gbxSettings.Controls.Add(this._cmbDetector);
			this._gbxSettings.Location = new System.Drawing.Point(0, 0);
			this._gbxSettings.Name = "_gbxSettings";
			this._gbxSettings.Size = new System.Drawing.Size(186, 452);
			this._gbxSettings.TabIndex = 0;
			this._gbxSettings.TabStop = false;
			this._gbxSettings.Text = "Настройки";
			// 
			// _cmbDetector
			// 
			this._cmbDetector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbDetector.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cmbDetector.FormattingEnabled = true;
			this._cmbDetector.Location = new System.Drawing.Point(6, 19);
			this._cmbDetector.Name = "_cmbDetector";
			this._cmbDetector.Size = new System.Drawing.Size(174, 21);
			this._cmbDetector.TabIndex = 0;
			this._cmbDetector.SelectedIndexChanged += new System.EventHandler(this._cmbDetector_SelectedIndexChanged);
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this._gbxSettings);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(188, 454);
			this._gbxSettings.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox _gbxSettings;
		private System.Windows.Forms.ComboBox _cmbDetector;
	}
}
