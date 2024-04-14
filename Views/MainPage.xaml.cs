using PdfKit;
using Microsoft.Maui.Controls;
using System;

namespace PaulineApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGifButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GifPage());
        }
    }
}