using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensiv.Main
{
	static class RegistrationService
	{
		public static IContainer CreateContainer()
		{
			var builder = new ContainerBuilder();

			builder
				.RegisterType<LogController>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<VideoPlayerController>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<RecognitionController>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<DarknetDetectorFactory>()
				.SingleInstance()
				.As<IDetectorFactory>()
				.AsSelf();

			builder
				.RegisterType<MainForm>()
				.AsSelf()
				.SingleInstance();

			builder
				.RegisterType<OpenVinoDetectorFactory>()
				.SingleInstance()
				.As<IDetectorFactory>()
				.AsSelf();

			builder
				.RegisterType<DetectorSelector>()
				.SingleInstance()
				.AsSelf();

			builder
				.RegisterType<SettingsControl>()
				.AsSelf()
				.ExternallyOwned();

			return builder.Build();
		}
	}
}
