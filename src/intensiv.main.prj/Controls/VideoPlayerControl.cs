using System;
using System.Drawing;
using System.Windows.Forms;

namespace Intensiv.Main.Controls
{
	/// <summary> Контрол видеопроигрывателя. </summary>
	public partial class VideoPlayerControl : UserControl
	{
		#region Data

		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;
		private ProjectSettings _projectSettings;

		#endregion

		#region .ctor

		/// <summary> Создает контрол видеопроигрывателя. </summary>
		public VideoPlayerControl(
			LogControler logControler,
			VideoPlayerControler videoPlayerControler,
			ProjectSettings projectSettings)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_logControler = logControler;
			_videoPlayerControler = videoPlayerControler;
			_projectSettings = projectSettings;

			_videoPlayerControler.ChangeImage += OnChangeImage;

			_opnFileDialog.Filter = "Image|*.png; *.jpg|Video|*.mp4; *.avi;";

		}

		#endregion

		#region Handler

		/// <summary> Вызывается при необходимости изменить картинку на панели. </summary>
		private void OnChangeImage(object sender, string path) => _picVideo.Image = Image.FromFile(path);

		/// <summary> Вызывается по нажатию на кнопку открыть файл. </summary>
		private void OnOpenFileClick(object sender, EventArgs e)
		{
			if(_opnFileDialog.ShowDialog() == DialogResult.Cancel) return;

			if(_opnFileDialog.FilterIndex == (int)FilterType.Image)
			{
				_videoPlayerControler.OpenImage(_opnFileDialog.FileName);
			}
			else if(_opnFileDialog.FilterIndex == (int)FilterType.Video)
			{

			}

		}

		/// <summary>Вызывается при нажатии открыть папку. </summary>
		private void OnOpenFolderClick(object sender, EventArgs e)
		{
			if(_opnFolderDialog.ShowDialog() == DialogResult.Cancel) return;

			_videoPlayerControler.OpenFolderWithImages(_opnFolderDialog.SelectedPath);
		}

		/// <summary> Вызывается при нажатие на кнопку следующая картинка. </summary>
		private void OnNextClick(object sender, EventArgs e) => _videoPlayerControler.NextImage();

		#endregion
	}
}
