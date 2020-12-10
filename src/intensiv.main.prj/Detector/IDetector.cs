using System.Drawing.Imaging;

namespace Intensiv.Main
{
	public interface IDetector
	{
		DetectionResult Detect(BitmapData frame);
		void Dispose();
	}
}