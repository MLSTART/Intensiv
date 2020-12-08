using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class RecognitionController
	{
		private readonly DetectorProvider _detectorProvider;
		private readonly LogController _logController;

		public RecognitionController(DetectorProvider detectorProvider, LogController logController)
		{
			_detectorProvider = detectorProvider;
			_logController = logController;
		}

		public DetectorResult Detect(BitmapData bitmapData)
		{
			return _detectorProvider.Detector.Detect(bitmapData);
		}
	}
}
