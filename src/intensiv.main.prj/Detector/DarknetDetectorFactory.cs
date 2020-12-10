using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class DarknetDetectorFactory : IDisposable, IDetectorFactory
	{
		private DarknetDetector _detector;

		public string Name => "Darknet";

		public IDetector GetDetector()
		{
			return _detector ?? (_detector = new DarknetDetector());
		}

		public void Dispose()
		{
			_detector?.Dispose();
		}
	}
}
