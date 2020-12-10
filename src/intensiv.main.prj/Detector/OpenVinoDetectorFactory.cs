using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class OpenVinoDetectorFactory : IDisposable, IDetectorFactory
	{
		private OpenVinoDetector _detector;

		public string Name => "OpenVino";

		public IDetector GetDetector()
		{
			return _detector ?? (_detector = new OpenVinoDetector());
		}

		public void Dispose()
		{
			_detector?.Dispose();
		}
	}
}
