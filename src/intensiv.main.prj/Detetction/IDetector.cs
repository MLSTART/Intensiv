using System.Drawing.Imaging;

namespace Intensiv.Main
{
	public interface IDetector
	{
		DetectorResult Detect(BitmapData image);
	}
}