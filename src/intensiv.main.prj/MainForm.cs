using System;
using System.Windows.Forms;
using Intensiv.Main.Controls;

namespace Intensiv.Main
{
	public partial class MainForm : Form
	{
		#region Data

		private LogControl _log;
		private SettingControl _setting;
		private VideoPlayerControl _videoPlayer;

		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;
		private ProjectSettings _projectSettings;

		#endregion

		#region .ctor

		/// <summary> Запуск главной формы. </summary>
		public MainForm(
			LogControler logControler,
			VideoPlayerControler videoPlayerControler,
			ProjectSettings projectSettings)
		{
			InitializeComponent();


			_logControler = logControler;
			_videoPlayerControler = videoPlayerControler;
			_projectSettings = projectSettings;

			_log = new LogControl(_logControler);
			_setting = new SettingControl(_logControler,_projectSettings);
			_videoPlayer = new VideoPlayerControl(_logControler, _videoPlayerControler,_projectSettings);

			_pnlLog.Controls.Add(_log);
			_pnlSetting.Controls.Add(_setting);
			_pnlVideoPlayer.Controls.Add(_videoPlayer);
			
		}

		#endregion

	}
}
