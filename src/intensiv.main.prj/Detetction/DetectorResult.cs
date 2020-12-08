using System.Collections.Generic;
using System.Drawing;

namespace Intensiv.Main
{
	public class DetectorResult
	{
		public IReadOnlyList<Rectangle> BoundingBoxes { get; }

		public DetectorResult(IReadOnlyList<Rectangle> boundingBoxes)
		{
			BoundingBoxes = boundingBoxes;
		}
	}
}
