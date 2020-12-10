using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class DetectionResult
	{
		public IReadOnlyList<Rectangle> BoundingBoxes { get; }

		public DetectionResult(IReadOnlyList<Rectangle> boundingBoxes)
		{
			BoundingBoxes = boundingBoxes;
		}
	}
}
