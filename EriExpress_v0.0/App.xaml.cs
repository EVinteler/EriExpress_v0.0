using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EriExpress_v0._0.Services;
using EriExpress_v0._0.Views;

namespace EriExpress_v0._0
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
