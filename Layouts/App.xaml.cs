using System;
using Layouts.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LayoutTest();
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
