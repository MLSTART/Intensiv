using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alturos.Yolo;
using Intensiv.Main.Controls;
using OpenCvSharp;
using System.Collections.Generic;

namespace Intensiv.Detector
{
	public class Detector
	{
		private YoloWrapper _wrapper;
		

		public Detector(string pathToCfg, string pathToWeights, string pathToNames)
		{
			_wrapper = new YoloWrapper(pathToCfg, pathToWeights, pathToNames)
;		}

		public Mat Detect(Mat img)
		{
			var items = _wrapper.Detect(img.ToBytes());
			return img;
		}
	}
}
