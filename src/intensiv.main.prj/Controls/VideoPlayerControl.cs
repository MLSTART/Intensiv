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

		#endregion

		#region .ctor

		/// <summary> Создает контрол видеопроигрывателя. </summary>
		public VideoPlayerControl(
			LogController logController, 
			VideoPlayerController videoPlayerControler)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_logController = logController;
			_videoPlayerController = videoPlayerControler;
		}

		#endregion
	}
}
