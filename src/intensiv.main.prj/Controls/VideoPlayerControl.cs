using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Intensiv.Main.Controls
{
	/// <summary> Контрол видеопроигрывателя. </summary>
	public partial class VideoPlayerControl : UserControl
	{
		#region Data

		private LogControler _logControler;
		private VideoPlayerControler _videoPlayerControler;
		private ProjectSettings _projectSettings;

		private Detector _detector;

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

			_videoPlayerControler.ChangeFrame += OnChangeFrame;

			_opnFileDialog.Filter = "Image|*.png; *.jpg|Video|*.mp4; *.avi;";

			_detector = new Detector();

		}

		private void OnChangeFrame(object sender, Mat image)
		{

			//Cv2.Resize(image, img, new OpenCvSharp.Size(_picVideo.Width, _picVideo.Height), 0, 0, InterpolationFlags.Cubic);
			_picVideo.ImageIpl = image;
			_picVideo.Refresh();

		}

		#endregion

		#region Handler

		/// <summary> Вызывается при необходимости изменить картинку на панели. </summary>
		private void OnChangeImage(object sender, string path)
		{
			//_picVideo.Image = Image.FromFile(path);
			if (_projectSettings.IsDetector)
			{
				_picVideo.Image = _detector.Detect(path).ToBitmap();
			}
			else
			{
				_picVideo.Image = Image.FromFile(path);
			}
			
		}

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
				_videoPlayerControler.OpenVideo(_opnFileDialog.FileName);
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

		/// <summary> Вызывается при нажатие на кнопку предыдущая картинка. </summary>
		private void OnBackClick(object sender, EventArgs e) => _videoPlayerControler.BackImage();


		/// <summary> Вызывается при нажатие на кнопку START. </summary>
		private void OnStartClick(object sender, EventArgs e) => _videoPlayerControler.PlayVideo();


		/// <summary> Вызывается при нажатие на кнопку PAUSE. </summary>
		private void _btnPause_Click(object sender, EventArgs e) => _videoPlayerControler.PauseVideo();
	}
}
