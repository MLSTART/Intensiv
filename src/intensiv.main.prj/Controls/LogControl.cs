using System;
using System.Windows.Forms;

namespace Intensiv.Main.Controls
{
	/// <summary> Лог контрол. </summary>
	public partial class LogControl : UserControl
	{
		#region Data

		private LogControler _logControler;

		#endregion

		#region .ctor

		/// <summary> Создать контрол лога. </summary>
		public LogControl(LogControler log)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logControler = log;

			_logControler.AddMessageInLog += OnAddMessageInLog;

		}

		#endregion

		#region Methods

		/// <summary> Вызывается при добавлении текста в Лог. </summary>
		private void OnAddMessageInLog(object sender, string text)
		{
			_txtLog.AppendText(text);
		}

		#endregion
	}
}
