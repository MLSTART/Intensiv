using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Intensiv.Main
{
	public class VideoPlayerController
	{
		#region Event

		public event EventHandler<BitmapData> OnFrameReaded;

		#endregion

		#region Data

		private LogController _logController;

		#endregion

		/// <summary> Создает контролер для видеопроигрывателя. </summary>
		public VideoPlayerController(LogController logController)
		{
			_logController = logController;
		}

		public void Start()
		{
		}
	}
}
