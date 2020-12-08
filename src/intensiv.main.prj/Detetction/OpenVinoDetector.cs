using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	class OpenVinoDetector : IDetector
	{
		public DetectorResult Detect(BitmapData image)
		{
			return new DetectorResult(new Rectangle[] { });
		}
	}
}
