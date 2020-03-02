using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xemyoutubethoi.Model;

namespace Xemyoutubethoi
{
   
    public  sealed partial class VideoPage 


    {
        Video video;

        public VideoPage()
        {
            this.InitializeComponent();

        }

        public object Frame { get; private set; }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                if (NetworkInterFace.GetIsNetworkAvailable())
                {
                    video = e.Parameter as Video;
                    var Url = await YouTube.GetVideoUriAsync(video.Id, YouTubeQuality.Quality1080P);
                    Player.Source = Url.Url;


                }
                else
                {
                    MessageDialog message = new MessageDialog("you are not connected to Internet");
                    await message.ShowAsync();
                    this.Frame.GoBack();


                }

            }
            catch
            {

            }
            base.OnNavigatedTo(e);
            
            

            

        }
        private void  btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new object());
        }
    }
}