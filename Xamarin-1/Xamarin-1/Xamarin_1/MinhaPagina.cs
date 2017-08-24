using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_1
{
    public class MinhaPagina: Xamarin.Forms.ContentPage
    {
        Button button;
        Label lbl;
        Entry entry;
        public MinhaPagina()
        {
            entry = new Entry
            {
                Placeholder = "Digite seu nome aqui",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            button =
                    new Button
                    {
                        Text = "Clique aqui",
                        FontSize = 12,
                        HorizontalOptions = LayoutOptions.Center,

                    };

            button.Clicked += (sender, args) =>
            {
                lbl.Text = "Seu nome é:" + entry.Text;//"Hello:" + DateTime.Now;
            };

            lbl = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,

                // YAlign=TextAlignment.Start,
                Text = "",
                FontSize = 20,
                TextColor = Color.White
            };




            Title = "Meu App em C#";
            Content = new StackLayout
            {
               
                BackgroundColor =Color.Gray,
                Padding = 20,
                VerticalOptions=LayoutOptions.Start,
               // HeightRequest=500,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment=TextAlignment.Start,
                        
                       // YAlign=TextAlignment.Start,
                        Text="Digite Seu Nome",
                        //FontSize=20,
                        TextColor=Color.Purple
                    },
                    entry,
                    button,
                    lbl

                }
            };


            
        }
    }
}
