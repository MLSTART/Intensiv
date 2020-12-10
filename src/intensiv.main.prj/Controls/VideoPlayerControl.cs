using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Intensiv.Main
{
	public partial class VideoPlayerControl : UserControl
	{
		#region Data

		private readonly LogController _logController;
		private readonly VideoPlayerController _videoPlayerController;
		private readonly RecognitionController _recognitionController;

		#endregion

		#region .ctor

		/// <summary> Создает контрол видеопроигрывателя. </summary>
		public VideoPlayerControl(
			LogController logController, 
			VideoPlayerController videoPlayerControler,
			RecognitionController recognitionController)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_logController = logController;
			_videoPlayerController = videoPlayerControler;
			_recognitionController = recognitionController;
		}

		#endregion

		private void _btnStart_Click(object sender, EventArgs e)
		{
			_logController.AddMessage("Started");
			_recognitionController.StartRecognition();
			_videoPlayerController.Start();
		}

		private void _btnStop_Click(object sender, EventArgs e)
		{
			_logController.AddMessage("Stopped");
			_videoPlayerController.Stop();
			_recognitionController.StopRecognition();
		}
	}
}
