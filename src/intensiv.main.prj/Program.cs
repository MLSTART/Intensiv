using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autofac;

namespace Intensiv.Main
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			using(var container = RegistrationService.CreateContainer())
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(container.Resolve<MainForm>());
			}
		}
	}
}
