using Autofac;

namespace Intensiv.Main.Services
{
	public static class RegisterServises
	{

		public static IContainer Create()
		{
			var containerBulder = new ContainerBuilder();

			containerBulder
				.RegisterModule<ModuleWinForm>();

			containerBulder
				.RegisterType<MainForm>()
				.AsSelf();

			return containerBulder.Build();

		}
	}
}
