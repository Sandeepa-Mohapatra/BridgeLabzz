using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UploadImage : ContentPage
    {
        public UploadImage()
        {
            InitializeComponent();
        }
        //MediaFile file;
        private async void btnPick_Clicked(object sender, EventArgs e)
        {
            
                await CrossMedia.Current.Initialize();
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("No pick photo", "Device doesn't support", "ok");
                }
               var file = await CrossMedia.Current.PickPhotoAsync();
                if (file == null)
                    return;
                imgChoosed.Source = ImageSource.FromStream(() =>
                {
                    return file.GetStream();
                });
            
           
        }

        private async void btnStore_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsTakePhotoSupported && !CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("No take photo", "Device doesn't support", "ok");
            }
           var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                Directory = "sample",
                Name = "icon.png"
            });
            if (file == null)
                return;
            imgChoosed.Source = ImageSource.FromStream(() =>
            {
                return file.GetStream();
            });
        }

        private void Upload_btn(object sender, EventArgs e)
        {

        }
    }
}