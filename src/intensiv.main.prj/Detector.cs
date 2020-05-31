using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alturos.Yolo;
using Intensiv.Main.Controls;
using OpenCvSharp;
using System.Collections.Generic;

namespace Intensiv.Main
{
	public class Detector
	{
		private YoloWrapper _wrapper;

//		public Detector(string pathToCfg, string pathToWeights, string pathToNames)
//		{
//			_wrapper = new YoloWrapper(pathToCfg, pathToWeights, pathToNames)
//;		}

	    public Detector()
		{
			_wrapper = new YoloWrapper(@"C:\Users\Reutov\Desktop\YOLO-Tiny-v3\yolov3-tiny.cfg",
									   @"C:\Users\Reutov\Desktop\YOLO-Tiny-v3\yolov3-tiny.weights",
									   @"C:\Users\Reutov\Desktop\YOLO-Tiny-v3\coco.names");
		}

		public IEnumerable<Alturos.Yolo.Model.YoloItem> GetInfoAboutDetection(string path)
		{
			return _wrapper.Detect(new Mat(path).ToBytes());
		}
		public Mat Detect(string path)
		{


			    var img = new Mat(path);
			    var items = _wrapper.Detect(img.ToBytes()); 
				for (int i = 0; i < items.Count(); i++)
				{
					var xmin = Int32.Parse(items.ElementAt(i).X.ToString());
					var ymin = Int32.Parse(items.ElementAt(i).Y.ToString());
					var width = Int32.Parse(items.ElementAt(i).Width.ToString());
					var height = Int32.Parse(items.ElementAt(i).Height.ToString());

					Rect rect = new Rect(xmin, ymin, width, height);
					img.Rectangle(rect, Scalar.Blue, 3, LineTypes.AntiAlias, 0);

					//_logControler.AddMessage($@"Тип объекта: {items.ElementAt(i).Type.ToString()}");
					//_logControler.AddMessage($@"X: {xmin}, Y: {ymin}, Width: {width}, Height: {height}");

			
				}

				return img;
			}
		
		}
	}

