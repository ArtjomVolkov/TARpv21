using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer_Page : ContentPage
    {
        public Timer_Page()
        {
            InitializeComponent();
        }
        private async void NaitaAeg()
        {
            while(onoff) {
                lbl.Text = DateTime.Now.ToString("T");
                await Task.Delay(300);
            }
        }
        bool onoff = false;
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            NaitaAeg();
        }

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void onoffbtn_Clicked(object sender, EventArgs e)
        {
            if (onoff)
            {
                onoff = false;
                onoffbtn.Text = "Lülita sisse";
            }
            else
            {
                onoff = true;
                onoffbtn.Text = "Lülita välja";
            }
        }
    }
}