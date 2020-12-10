using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	class OpenVinoDetector : IDisposable, IDetector
	{
		public DetectionResult Detect(BitmapData frame)
		{
			return new DetectionResult(new Rectangle[] { });
		}

		public void Dispose()
		{
		}
	}
}
