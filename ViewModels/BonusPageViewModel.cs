using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PaulineApp
{
    public class BonusPageViewModel : INotifyPropertyChanged
    {
        private string _youtubeVideoUrl;
        public string YoutubeVideoUrl
        {
            get { return _youtubeVideoUrl; }
            set
            {
                if (_youtubeVideoUrl != value)
                {
                    _youtubeVideoUrl = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void ShareVideo()
        {
            try
            {
                Share.RequestAsync(new ShareTextRequest
                {
                    Uri = YoutubeVideoUrl,
                    Title = "Check out this video!"
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sharing failed: {ex.Message}");
            }
        }
    }
}