using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public interface IDetectorFactory
	{
		string Name { get; }

		IDetector Create();
	}
}
