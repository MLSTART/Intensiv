using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Intensiv.Main
{

	class DarknetDetector : IDetector
	{
		public DetectorResult Detect(BitmapData image)
		{
			return new DetectorResult(new Rectangle[] { });
		}
	}
}
