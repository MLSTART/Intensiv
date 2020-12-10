using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class RecognitionController
	{
		public event EventHandler<DetectionResult> ObjectDetected;

		private void OnObjectDetected(DetectionResult args) => ObjectDetected?.Invoke(this, args);

		private readonly VideoPlayerController _videoPlayerController;
		private readonly DetectorSelector _detectorSelector;
		private readonly LogController _logController;

		public RecognitionController(VideoPlayerController videoPlayerController, LogController logController, DetectorSelector detectorSelector)
		{
			_videoPlayerController = videoPlayerController;
			_logController = logController;
			_detectorSelector = detectorSelector;
		}

		public void StartRecognition()
		{
			_videoPlayerController.OnFrameReaded += OnVideoPlayerControllerOnFrameReaded;
		}

		private void OnVideoPlayerControllerOnFrameReaded(object sender, System.Drawing.Imaging.BitmapData e)
		{
			var result = _detectorSelector.SelectedDetectorFactory.GetDetector().Detect(e);
			_logController.AddMessage("Frame processed");
			OnObjectDetected(result);
		}

		public void StopRecognition()
		{
			_videoPlayerController.OnFrameReaded -= OnVideoPlayerControllerOnFrameReaded;
		}
	}
}
