using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autofac;

namespace Intensiv.Main
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			using(var container = CreateContainer())
			{
				Application.Run(container.Resolve<MainForm>());
			}
		}

		private static IContainer CreateContainer()
		{
			var builder = new ContainerBuilder();

			builder
				.RegisterType<DetectorProvider>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<RecognitionController>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<LogController>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<VideoPlayerController>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<MainForm>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<SettingsControl>()
				.AsSelf()
				.ExternallyOwned();

			builder
				.RegisterType<DarknetDetectorFactory>()
				.SingleInstance()
				.As<IDetectorFactory>();

			builder
				.RegisterType<OpenVinoDetectorFactory>()
				.SingleInstance()
				.As<IDetectorFactory>();

			return builder.Build();
		}
	}
}
