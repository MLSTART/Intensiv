using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Intensiv.Main
{
	public partial class SettingsControl : UserControl
	{
		private class DetectorItem
		{
			public IDetectorFactory DetectorFactory { get; }

			public DetectorItem(IDetectorFactory detectorFactory)
			{
				DetectorFactory = detectorFactory;
			}

			public override string ToString()
			{
				return DetectorFactory.Name;
			}
		}

		#region Data

		private readonly LogController _logController;
		private readonly DetectorProvider _detectorProvider;

		#endregion

		#region .ctor

		/// <summary> Создает контрол панели настроек. </summary>
		public SettingsControl(
			LogController logController, 
			DetectorProvider detectorProvider, 
			IReadOnlyList<IDetectorFactory> factories)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logController = logController;
			_detectorProvider = detectorProvider;
			foreach(var factory in factories)
			{
				_cmbDetectorType.Items.Add(new DetectorItem(factory));
			}
		}

		#endregion

		private void _cmbDetectorType_SelectedIndexChanged(object sender, EventArgs e)
		{
			_detectorProvider.Detector = ((DetectorItem)_cmbDetectorType.SelectedItem).DetectorFactory.Create();
		}
	}
}
