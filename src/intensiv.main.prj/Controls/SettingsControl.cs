using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Intensiv.Main
{
	public partial class SettingsControl : UserControl
	{
		#region Data

		private readonly LogController _logController;

		#endregion

		#region .ctor

		/// <summary> Создает контрол панели настроек. </summary>
		public SettingsControl(LogController logController)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logController = logController;
		}

		#endregion
	}
}
