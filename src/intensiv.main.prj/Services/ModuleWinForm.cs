using System;

using Autofac;

using Intensiv.Main.Controls;

namespace Intensiv.Main.Services
{
	public sealed class  ModuleWinForm : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);
			builder
				.RegisterType<LogControler>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<ProjectSettings>()
				.AsSelf()
				.SingleInstance();
			builder
				.RegisterType<VideoPlayerControler>()
				.AsSelf()
				.SingleInstance();
			//builder
			//	.RegisterType<SettingControl>()
			//.As<IImageForMarkup>()
			//	.AsSelf()
			//	.SingleInstance();
			//builder
			//	.RegisterType<VideoPanel>()
			//	.AsSelf()
			//	.SingleInstance();

		}
	}
}
