using Microsoft.Maui.Controls;
using System;
using  PaulineApp.Views;

namespace PaulineApp
{
    public partial class MainPage : ContentPage
    {

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