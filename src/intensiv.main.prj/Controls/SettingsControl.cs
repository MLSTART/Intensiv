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

			public override string ToString() => DetectorFactory.Name;
		}

		#region Data

		private readonly LogController _logController;
		private readonly DetectorSelector _detectorSelector;

		#endregion

		#region .ctor

		/// <summary> Создает контрол панели настроек. </summary>
		public SettingsControl(LogController logController, DetectorSelector detectorSelector, IReadOnlyList<IDetectorFactory> detectorFactories)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logController = logController;
			_detectorSelector = detectorSelector;
			foreach(var factory in detectorFactories)
			{
				_cmbDetector.Items.Add(new DetectorItem(factory));
			}
		}

		#endregion

		private void _cmbDetector_SelectedIndexChanged(object sender, EventArgs e)
		{
			_detectorSelector.SelectedDetectorFactory = ((DetectorItem)_cmbDetector.SelectedItem).DetectorFactory;
		}
	}
}
