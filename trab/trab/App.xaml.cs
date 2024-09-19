using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new trab.Master.Masterr();
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
