using System;
using System.Windows.Forms;

using Autofac;
using Intensiv.Main.Services;

namespace Intensiv.Main
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			using(var container = RegisterServises.Create())
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(container.Resolve<MainForm>());
			}
		}
	}
}
