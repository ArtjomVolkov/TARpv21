using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Box_Page : ContentPage
    {
        BoxView box;
        Button tagasi;
        Label widht;
        Label height;
        public Box_Page()
        {
            height = new Label
            {
                Text = DeviceDisplay.MainDisplayInfo.Height.ToString(),
                FontSize = 20,
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            widht = new Label
            {
                Text = DeviceDisplay.MainDisplayInfo.Width.ToString(),
                FontSize = 20,
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            tagasi = new Button
            {
                Text = "Tagasi",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            
            tagasi.Clicked += Tagasi_Clicked;
            box = new BoxView()
            {
                Color = Color.Chocolate,
                CornerRadius= 50,
                WidthRequest= 50,
                HeightRequest= 50,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions= LayoutOptions.Center,
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);
            Content = new StackLayout { Children = { height, widht, tagasi,box } };
        }
        Random rnd;
        //CornerRadius Rad = 80;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            rnd = new Random();
            box.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            //box.CornerRadius = Rad ;
            box.WidthRequest = box.WidthRequest + 5;
            box.HeightRequest = box.HeightRequest + 8;
            box.Rotation += 10;
            try
            {
                Vibration.Vibrate();
                var a = TimeSpan.FromSeconds(0.5);
                Vibration.Vibrate(a);
            }
            catch ( Exception) { }
        }
        

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}