using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GitDemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FrmPage1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void FrPage2_Tapped(object sender, EventArgs e)
        {

        }
    }
}
