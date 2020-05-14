using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using OpenCvSharp;

namespace Intensiv.Main.Controls
{
	/// <summary> Контролер для видеопроигрывателя. </summary>
	public class VideoPlayerControler
	{
		#region Data

		private List<string> _listImage;
		private int _curerntIamge;
		private int _countImage;

		private ProjectSettings _projectSettings;
		private LogControler _logControler;

		private VideoCapture _capture;
		private int _fps;

		private bool _pause;
		private bool _stop;

		#endregion

		#region Event

		/// <summary> Вызывается при  изменении картинки.</summary>
		public event EventHandler<string> ChangeImage;

		/// <summary> Вызывается при  изменении кадра.</summary>
		public event EventHandler<Mat> ChangeFrame;

		#endregion

		#region Handler

		/// <summary> Обработчик события изменения картинки на панели. </summary>
		/// <param name="path"> Путь к картинке. </param>
		private void OnChangeImage(string path)
		{
			if(ChangeImage != null)
			{
				ChangeImage.Invoke(null, path);
			}
		}

		/// <summary> Обработчик события изменения кадра. </summary>
		/// <param name="image"> кадр. </param>
		private void OnChangeFrame(Mat image)
		{
			if(ChangeFrame != null)
			{
				ChangeFrame.Invoke(null, image);
			}
		}

		#endregion

		#region .ctor

		/// <summary> Создает контролер для видеопроигрывателя. </summary>
		public VideoPlayerControler(
			ProjectSettings projectSettings,
			LogControler logControler)
		{
			_projectSettings = projectSettings;
			_logControler = logControler;
		}

		#endregion

		#region MethodsImage

		/// <summary> Открыть одну картинку. </summary>
		/// <param name="path">Путь к картинке. </param>
		public void OpenImage(string path)
		{
			AddImageOnControl(path);
		}

		/// <summary> Открыть директорию с картинками. </summary>
		/// <param name="path"> Путь к директории. </param>
		public void OpenFolderWithImages(string path)
		{
			IEnumerable<string> _filesDirectory = null;

			if(_projectSettings.IsUnderCatalog)
			{
				 _filesDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
					.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"));
			}
			else
			{
				_filesDirectory = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
					.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".jpeg"));
			}


			_listImage = _filesDirectory.ToList();

			_curerntIamge = 0;
			_countImage = _filesDirectory.Count();

			if(_countImage != 0)
			{
				AddImageOnControl(_listImage[_curerntIamge]);
				_logControler.AddMessage($"{_curerntIamge} {_countImage}");
			}
			else
			{
				_logControler.AddMessage("Изображений не обнаружено!");
			}

		}

		/// <summary> Добавить картинку на Контрол. </summary>
		/// <param name="path"> Путь к картинке. </param>
		private void AddImageOnControl(string path)
		{
			OnChangeImage(path);
		}

		/// <summary> Переход к следующей картинке. </summary>
		public void NextImage()
		{
			if(_listImage != null && _listImage.Count != 0)
			{
				_curerntIamge++;
				if(_curerntIamge == _countImage)
				{
					_curerntIamge = 0;
				}
				AddImageOnControl(_listImage[_curerntIamge]);
				_logControler.AddMessage($"{_curerntIamge} {_countImage}");
			}
		}

		/// <summary> Переход к предыдущей картинке. </summary>
		public void BackImage()
		{
			if(_listImage != null && _listImage.Count != 0)
			{
				_curerntIamge--;
				if(_curerntIamge <= 0)
				{
					_curerntIamge = _countImage-1;
				}
				AddImageOnControl(_listImage[_curerntIamge]);
				_logControler.AddMessage($"{_curerntIamge} {_countImage}");
			}
		}


		#endregion

		#region MethodsVideo
		/// <summary> открыть видео </summary>
		/// <param name="path"></param>
		public void OpenVideo(string path)
		{
			if(_capture != null) _capture.Dispose();

			_capture = new VideoCapture(path);
			_fps = (int)(1000 / _capture.Fps);
			using(Mat image = new Mat())
			{
				_capture.Read(image);
				if(!image.Empty())
				{
					NextFrameAddInVideoControl(image);
					_pause = false;
					PlayVideo();
				}
				else
				{
					_logControler.AddMessage("Некорректное видео!");
				}

			}
		}

		/// <summary> Воспроизвести видео. </summary>
		public void PlayVideo()
		{
			if(_pause) _pause = false;

			while(true)
			{
				if(_capture != null)
				{

					if(_pause) break;
					using(Mat image = new Mat())
					{
						_capture.Read(image);
						if(image.Empty())
						{
							_logControler.AddMessage("Конец видео!");
							break;
						}
						NextFrameAddInVideoControl(image);
						Cv2.WaitKey(_fps);
					}

				}
			}
		}

		/// <summary> Остановить видео </summary>
		public void StopVideo()
		{

		}

		/// <summary> Пауза в видео </summary>
		public void PauseVideo()
		{
			if(_capture != null) _pause = true;
		}

		/// <summary>Отобразить следующий кадр</summary>
		/// <param name="image"></param>
		private void NextFrameAddInVideoControl(Mat image)
		{
			OnChangeFrame(image);
		}
		#endregion
	}
}
