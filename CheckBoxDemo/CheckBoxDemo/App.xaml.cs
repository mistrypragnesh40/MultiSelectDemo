using CheckBoxDemo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckBoxDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MultiSelectDemo();
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
