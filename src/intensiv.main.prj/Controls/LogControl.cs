using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Intensiv.Main
{
	public partial class LogControl : UserControl
	{
		#region Data

		private LogController _logController;

		#endregion

		#region .ctor

		public LogControl(LogController logController)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logController = logController;

			_logController.AddMessageInLog += OnAddMessageInLog; ;
		}

		private void OnAddMessageInLog(object sender, string text)
		{
			_txtLog.AppendText(text);
		}

		#endregion

	}
}
