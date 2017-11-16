using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Device = Xamarin.Forms.Device;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppCenterTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppCenter.Start("ios=70670cef-0e13-414f-bce0-a98ac08e0ca2;android=b7fb1b43-51ea-4bea-a447-5370be800cbd",
                typeof(Analytics), typeof(Crashes));

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}