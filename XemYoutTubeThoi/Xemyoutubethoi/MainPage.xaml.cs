using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xemyoutubethoi.Model;

namespace Xemyoutubethoi
{
  
    public sealed partial class MainPage : Page
    {
        private YouTubeService youTubeService = new YouTubeService(new BaseClientService.Initializer
        {
            ApiKey = "AIzaSyDBf8bq5AKUSHfF_CF0eeZ2RCLzyfmOi5s",
            ApplicationName = "youtube"

        });
        List<Video> Listvideo = new List<Video>();
        private string TokenNextPage = null, TokenPrivPage = null;
        private object lv;

        public MainPage()
        {
            this.InitializeComponent();
            GetVideo();
        }

        public object SearchResource { get; private set; }

        private async void GetVideo(string PageToken = null)
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    var Request = youTubeService.Search.List("snippet");
                    Request.ChannelId = "UCsooa4yRKGN_zEE8iknghZA";
                    Request.MaxResults = 25;
                    Request.Type = "video";
                    Request.Order = SearchResource.ListRequest.OrderEnum.Date;
                    Request.PageToken = PageToken;
                    var Result = await Request.ExecuteAsnyc();
                    if (Result.NextPageToken != null)
                        TokenNextPage = Result.NextPageToken;
                    if(Result.PrevPageToken) !null)
                        TokenPrivPage = Result.PrevPageToken;
                    foreach(var item in Result.Items)
                    {
                        Listvideo.Add(new Video
                        {
                            Title = item.Snippet.Title,
                            Id = item.Id.VideoId,
                            Img= item.Snippet.Thumbnails.Default__.Url

                        });
                            
                    }
                    lv.ItemsSource = null;
                    lv.ItemsSource = Listvideo;


                }
                else
                {
                    MessageDialog msg = new MessageDialog("Check your  internet connection");
                    await msg.ShowAsync();
                }
            }
            catch { }
        }
        private void lv_ItemClick(object sender,ItemClickEventArgs e)
        {
            Video video = e.ClickedItem as Video;
            Frame.Navigate(typeof(VideoPage), video);

        }

        private void GetVideo()
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

internal class MessageDialog
    {
        private string v;

        public MessageDialog(string v)
        {
            this.v = v;
        }
    }
    }

    internal class ItemClickEventArgs
    {
    }



