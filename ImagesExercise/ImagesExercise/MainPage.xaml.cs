using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImagesExercise
{
    public partial class MainPage : ContentPage
    {
        private int _imageIndex=1;
        public MainPage()
        {
            InitializeComponent();
            _imageIndex = 1;
            SetNewImage();
        }


        void SetNewImage()
        {
            UriImageSource imageSource = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", _imageIndex))
            };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;

        }

        void LeftClicked(object sender, System.EventArgs e)
        {
            _imageIndex--;
            if (_imageIndex < 1)
            {
                _imageIndex = 10;
            }

            SetNewImage();
        }
        void RightClicked(object sender, System.EventArgs e)
        {
            _imageIndex++;
            if (_imageIndex > 10)
            {
                _imageIndex = 1;
            }
            SetNewImage();
        }
    }
}
