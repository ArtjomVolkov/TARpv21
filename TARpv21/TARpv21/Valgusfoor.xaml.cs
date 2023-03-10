using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TARpv21
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        BoxView punane,kolane,roheline;
        StackLayout stacks;
        Label lbl_punane1,lbl_kolane1,lbl_roheline1;
        Button oos,oosi;
        public Valgusfoor()
        {
            Label lbl = new Label
            {
                Text = "Valgusfoor",
                FontSize = 25,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            punane = new BoxView()
            {
                Color = Color.Red,
                CornerRadius = 150,
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            kolane = new BoxView()
            {
                Color = Color.Yellow,
                CornerRadius = 150,
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            roheline = new BoxView()
            {
                Color = Color.Green,
                CornerRadius = 150,
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            Button sisse = new Button
            {
                Text = "Sisse",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
            };
            Button valja = new Button
            {
                Text = "Välja",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
            };
            Button tagasi = new Button
            {
                Text = "Tagasi",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            lbl_punane1 = new Label { Text = "See on punane!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            lbl_kolane1 = new Label { Text = "See on kolane!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            lbl_roheline1 = new Label { Text = "See on roheline!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            oos = new Button
            {
                Text = "Sisse Öö",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
            };
            oosi = new Button
            {
                Text = "Välja Öö",
                BackgroundColor = Color.Black,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                TextColor = Color.White,
            };
            Content = new StackLayout { Children = { lbl, punane, lbl_punane1, kolane, lbl_kolane1, roheline, lbl_roheline1, tagasi, new StackLayout { Orientation = StackOrientation.Horizontal, Children = { sisse, valja } }, new StackLayout { Orientation = StackOrientation.Horizontal, Children = { oos, oosi } }  } };
            sisse.Clicked += Sisse_Clicked;
            tagasi.Clicked += Tagasi_Clicked;
            valja.Clicked += Valja_Clicked;
            oos.Clicked += Oo_Clicked;
            oosi.Clicked += Oosi_Clicked;
        }

        private void Oosi_Clicked(object sender, EventArgs e)
        {
            onoffs = false;
            OO1();
        }

        private void Oo_Clicked(object sender, EventArgs e)
        {
            onoffs = true;
            onoff = false;
            OO1();
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            onoff = false;
            UpdateLights();
        }

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        bool onoff = false;
        bool onoffs = false;
        private async void OO1()
        {
            if (onoffs)
            {
                int i = 0;
                while (onoffs == true)
                {
                    lbl_kolane1.Text = "See on kolane!";
                    lbl_punane1.Text = "See on punane!";
                    lbl_roheline1.Text = "See on roheline!";
                    punane.Color = Color.Gray;
                    roheline.Color = Color.Gray;
                    kolane.Color = Color.Yellow;
                    await Task.Delay(300);
                    kolane.Color = Color.Gray;
                    await Task.Delay(300);
                    kolane.Color = Color.Yellow;
                    await Task.Delay(300);
                    kolane.Color = Color.Gray;
                    i++;
                }

            }
            else
            {
                onoffs = false;
                punane.Color = Color.Gray;
                kolane.Color = Color.Gray;
                roheline.Color = Color.Gray;
            }
        }

        private async void UpdateLights()
        {
            if (onoff)
            {
                int i = 0;
                while (onoff == true) {
                    onoffs = false;
                    lbl_punane1.Text = "See on punane! Kui särab siis sa pead ootama!";
                    punane.Color = Color.Red;
                    punane.Opacity = 0.7;
                    await Task.Delay(1500);
                    punane.Opacity = 0.3;
                    punane.Color = Color.Gray;
                    kolane.Color = Color.Yellow;
                    lbl_punane1.Text = "See on punane!";
                    lbl_kolane1.Text = "See on kolane! Kui särab siis sa pead ootama!";
                    kolane.Opacity = 0.7;
                    await Task.Delay(1500);
                    kolane.Color = Color.Gray;
                    roheline.Color = Color.Green;
                    lbl_kolane1.Text = "See on kolane!";
                    lbl_roheline1.Text = "See on roheline! Sa pead minema!";
                    await Task.Delay(1500);
                    roheline.Color = Color.Gray;
                    kolane.Color = Color.Yellow;
                    lbl_roheline1.Text = "See on roheline!";
                    lbl_kolane1.Text = "See on kolane! Kui särab siis sa pead ootama!";
                    await Task.Delay(1500);
                    kolane.Color = Color.Gray;
                    punane.Color = Color.Red;
                    lbl_kolane1.Text = "See on kolane!";
                    lbl_punane1.Text = "See on punane! Kui särab siis sa pead ootama!";
                    punane.Opacity = 1;
                    i++;
                }
                
            }
            else
            {
                onoff = false;
                punane.Color = Color.Gray;
                lbl_punane1.Text = "See on punane!";
                kolane.Color = Color.Gray;
                lbl_kolane1.Text = "See on kolane!";
                roheline.Color = Color.Gray;
                lbl_roheline1.Text = "See on roheline!";
            }
        }

        private void Sisse_Clicked(object sender, EventArgs e)
        {
            onoff = true;
            onoffs = false;
            UpdateLights();
        }
    }
}