using Microsoft.Maui.Controls;

namespace PaulineApp
{
    public partial class BonusPage : ContentPage
    {
        public BonusPage()
        {
            InitializeComponent();
            BindingContext = new BonusPageViewModel();
        }

        private void UpdateVideoUrlButton_Clicked(object sender, EventArgs e)
        {
            var viewModel = (BonusPageViewModel)BindingContext;
            viewModel.YoutubeVideoUrl = "https://youtu.be/RDjff-ysRM0";
        }
        private void ShareVideo()
        {
            var viewModel = (BonusPageViewModel)BindingContext;
            viewModel.ShareVideo();
        }

    }
}