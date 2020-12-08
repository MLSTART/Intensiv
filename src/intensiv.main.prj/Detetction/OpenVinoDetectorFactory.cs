using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class OpenVinoDetectorFactory : IDetectorFactory
	{
		private OpenVinoDetector _instance;

		public string Name => "OpenVino";

		public IDetector Create()
		{
			return _instance ?? (_instance ?? new OpenVinoDetector());
		}
	}
}
