using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage()
        {
            InitializeComponent();
        }

        private async void TakePhoto_btn(object sender, EventArgs e)
        {

            try
            {
                ////check if camera is available
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                ////Take photo using device camera and store into the specified file 
                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "Test",
                    SaveToAlbum = true,
                    CompressionQuality = 75,
                    CustomPhotoSize = 50,
                    PhotoSize = PhotoSize.MaxWidthHeight,
                    MaxWidthHeight = 2000,
                    DefaultCamera = CameraDevice.Rear
                });

                ////Check if the file have that photo
                if (file == null)
                    return;

                await DisplayAlert("File Location", file.Path, "OK");

                ////Add that photo to the image source
                image.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }

        private async void PickPhoto_btn(object sender, EventArgs e)
        {
            try
            {
                ////check the support for picking photo from device
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Photos Not Supported", "Permission not granted to photos.", "OK");
                    return;
                }

                ////Pick photo from device 
                var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Small
                });

                ////If photo not selected, return 
                if (file == null)
                    return;

                ////Add that photo to the image source
                image.Source = ImageSource.FromStream(() => file.GetStream());
                await DisplayAlert("Photo Selected", "Location: " + file.Path, "OK");
                file.Dispose();

            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }
    }
}