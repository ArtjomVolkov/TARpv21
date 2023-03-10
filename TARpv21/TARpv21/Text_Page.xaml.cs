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
    public partial class Text_Page : ContentPage
    {
        Editor editor;
        Label lbl;
        Button Tagasibtn;
        public Text_Page()
        {
            Tagasibtn = new Button
            {
                Text = "Tagasi",
                BackgroundColor = Color.Black,
                TextColor = Color.White,
            };
            editor = new Editor
            {
                Placeholder = "Kirjuta text",
                PlaceholderColor= Color.Bisque,
                BackgroundColor= Color.CornflowerBlue,
                TextColor = Color.Black,
            };
            editor.TextChanged += Editor_TextChanged;
            lbl = new Label { Text = "Siia tuleb ka tekst",BackgroundColor = Color.Chocolate };
            Image img = new Image { Source = "xxx.jpg" };


            Content = new StackLayout { Children= { editor,lbl,img ,Tagasibtn } };
            Tagasibtn.Clicked += Tagasibtn_Clicked;
        }
        int i;
        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbl.Text = editor.Text;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';
            if (key == 'A' || key == 'a')
            {
                i++;
                Tagasibtn.Text = key.ToString() + ": " + i.ToString();
            }
        }

        private async void Tagasibtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}