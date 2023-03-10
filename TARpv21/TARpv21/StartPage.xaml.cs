using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            Button Textbtn = new Button { 
                Text= "Text Page",
                BackgroundColor= Color.Black,
                TextColor= Color.White,
            };
            Button Timerbtn = new Button
            {
                Text = "Timer Page",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            Button Boxbtn = new Button
            {
                Text = "Box Page",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            Button Valgusbtn = new Button
            {
                Text = "Valgusfoor Page",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            Image imgs = new Image { Source = "aaa.jpg" };
            StackLayout st = new StackLayout { Orientation = StackOrientation.Vertical, BackgroundColor = Color.Beige, Children = { imgs,Textbtn,Timerbtn, Boxbtn,Valgusbtn } };
            Content= st;
            Textbtn.Clicked += Textbtn_Clicked;
            Timerbtn.Clicked += Timerbtn_Clicked;
            Boxbtn.Clicked += Boxbtn_Clicked;
            Valgusbtn.Clicked += Valgusbtn_Clicked;
        }

        private async void Valgusbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor());
        }

        private async void Boxbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Box_Page());
        }

        private async void Timerbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Textbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Text_Page());
        }
    }
}