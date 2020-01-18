using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        private async void Geocoding_btn(object sender, EventArgs e)
        {
            try
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                    var location = await Geolocation.GetLocationAsync(request);

                    if (location != null)
                    {
                        Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                        Location.Text = "Lat:" + location.Latitude + " " + "Longitude:" + location.Longitude;
                    }
                }
                catch (FeatureNotSupportedException fnsEx)
                {
                    // Handle not supported on device exception
                }
                catch (FeatureNotEnabledException fneEx)
                {
                    // Handle not enabled on device exception
                }
                catch (PermissionException pEx)
                {
                    // Handle permission exception
                }
                catch (Exception ex)
                {
                    // Unable to get location
                }
            

        }

        private async void Geolocation_btn(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }

        private void AppInfo_btn(object sender, EventArgs e)
        {
            info.Text = AppInfo.Name;
            info1.Text = AppInfo.PackageName;
            info2.Text = AppInfo.Version.ToString();
            info3.Text = AppInfo.BuildString;
        }

        private void Email_btn(object sender, EventArgs e)
        {
            Email.ComposeAsync(EntrySub.Text, "", EntryEmail.Text);
        }

        private void Browser_btn(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.google.com/",BrowserLaunchMode.SystemPreferred);
        }

        private void VersionTracking_btn(object sender, EventArgs e)
        {
            currentversion.Text = $"{ VersionTracking.CurrentBuild}({VersionTracking.CurrentVersion})";
            Prevversion.Text = $"{VersionTracking.PreviousBuild}({VersionTracking.PreviousVersion})";
        }
        const string file = "FileTemplate.txt";
        private async void FileSystem_btn(object sender, EventArgs e)
        {
            using (var stream = await FileSystem.OpenAppPackageFileAsync(file))
            {
                using (var reader = new StreamReader(stream))
                {
                    text.Text = await reader.ReadToEndAsync();
                }
            }

        }
    }
}