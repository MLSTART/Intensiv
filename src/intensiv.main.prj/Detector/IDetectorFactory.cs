namespace Intensiv.Main
{
	public interface IDetectorFactory
	{
		IDetector GetDetector();

		string Name { get; }
	}
}