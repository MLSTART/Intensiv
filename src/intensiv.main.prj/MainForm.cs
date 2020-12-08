using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intensiv.Main
{
	public partial class MainForm : Form
	{
		private LogControl _log;
		private SettingsControl _setting;
		private VideoPlayerControl _videoPlayer;

		private LogController _logController;
		private VideoPlayerController _videoPlayerController;

		public MainForm(LogController logController,
			VideoPlayerController videoPlayerController,
			RecognitionController recognitionController,
			DetectorProvider detectorProvider,
			SettingsControl settingsControl)
		{
			InitializeComponent();

			_logController = logController;
			_videoPlayerController = videoPlayerController;

			_log = new LogControl(_logController);
			_setting = settingsControl;
			_videoPlayer = new VideoPlayerControl(_logController, _videoPlayerController, recognitionController);

			_pnlLog.Controls.Add(_log);
			_pnlSettings.Controls.Add(_setting);
			_pnlVideo.Controls.Add(_videoPlayer);

			_logController.AddMessage("Старт программы.");
		}

		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
				_setting.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
