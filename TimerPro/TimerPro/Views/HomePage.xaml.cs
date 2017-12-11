using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerPro.Helpers;
using TimerPro.Interfaces;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimerPro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
            Helper.helper?.BackButtonPress();
        }
    }
}