﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	public class DetectorSelector
	{
		public IDetectorFactory SelectedDetectorFactory { get; set; }
	}
}
