using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class DarknetDetectorFactory : IDetectorFactory
	{
		private DarknetDetector _instance;

		public string Name => "Darknet";

		public IDetector Create()
		{
			return _instance ?? (_instance = new DarknetDetector());
		}
	}
}
