using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;

namespace YTDownloader
{
    public partial class YTViewer : UserControl
    {
        private Properties.Settings settings = Properties.Settings.Default;
        private static string VideoID;
        private static string VideoType;
        private string SearchText;
        private static readonly string Temp = Path.GetFullPath($@"{Environment.GetEnvironmentVariable("temp")}\YTDownloader");
        public YTViewer(string BtnName, string Searchtext)
        {
            VideoID = BtnName.Split('|')[0];
            VideoType = BtnName.Split('|')[1];
            Console.WriteLine($"VideoID : {VideoID} / VideoType : {VideoType} / BtnName : {BtnName}");
            SearchText = Searchtext;
            InitializeComponent();
            if (BtnName != null)
            {
                InitializeWebView2();
                InitializeVideoInfo();
            }
        }

        public void Video_Click(object sender, EventArgs e)
        {
            // 사실 얘 버튼이 아니라 픽쳐박스로 옴.
            PictureBox button = (PictureBox)sender;
            VideoID = button.Name.Split('|')[0];
            VideoType = button.Name.Split('|')[1];
            Console.WriteLine($"VideoID : {VideoID} / VideoType : {VideoType} / BtnName : {button.Name}");
            InitializeWebView2();
            InitializeVideoInfo();

        }

        private void InitializeWebView2()
        {
            YTEmbed.Source = new Uri($"https://www.youtube.com/embed/{VideoID}");
        }

        private async void InitializeVideoInfo()
        {
            /*
             * Vinfo = Video Info
             * Cinfo = Channel Info
            */

            YoutubeClient ytClient = new YoutubeClient();
            if (VideoType == "video")
            {
                // 영상 정보
                YoutubeExplode.Videos.Video Vinfo = await ytClient.Videos.GetAsync(VideoID);
                Title.Text = Vinfo.Title.ToString();
                description.Text = $"{Vinfo.Description}\n";
                VideoDate.Text = Vinfo.UploadDate.UtcDateTime.ToString();
                detailVideo.VerticalScroll.Visible = false;

                // 채널 정보
                YoutubeExplode.Channels.Channel Cinfo = await ytClient.Channels.GetAsync(Vinfo.Author.ChannelId);
                ChannelName.Text = Cinfo.Title.ToString();
            }
            else if (VideoType == "playlist")
            {
                YoutubeExplode.Playlists.Playlist Pinfo = await ytClient.Playlists.GetAsync(VideoID);
                Title.Text = Pinfo.Title.ToString();
                description.Text = Pinfo.Description.ToString();


                ChannelName.Text = Pinfo.Author.Title.ToString();
            }

            Console.WriteLine($"ID : {VideoID}");
            MakeVideo();
        }

        private void ShareBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"https://youtu.be/{VideoID} \n클립보드에 복사하시겠습니까?", "공유", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Clipboard.SetText($"https://youtu.be/{VideoID}");
            }
        }

        public async void MakeVideo()
        {
            RightVideo.Controls.Clear();
            YoutubeClient youtube = new YoutubeClient();

            int i = 0;
            try
            {
                if (VideoType == "video")
                {
                    SearchBox.ForeColor = Color.Black;
                    SearchBox.Text = SearchText;
                    await foreach (var result in youtube.Search.GetResultsAsync(SearchBox.Text))
                    {
                        if (settings.SearchNumber != 0 && i == settings.SearchNumber)
                        {
                            break;
                        }
                        switch (result)
                        {
                            case VideoSearchResult video:
                                {
                                    RightVideo.Controls.Add(Video($"{video.Id}|video", video.Title, video.Author.Title));
                                    Console.WriteLine($"Title : {video.Title}\nID : {video.Id}\nAuthor : {video.Author.Title}\n------------------");
                                    break;
                                }
                            case PlaylistSearchResult playlist:
                                {
                                    RightVideo.Controls.Add(Video($"{playlist.Id}|playlist ", $"{playlist.Title} (재생 목록)", playlist.Author.Title));
                                    Console.WriteLine($"Title : {playlist.Title}(재생 목록)\nID : {playlist.Id}\nAuthor : {playlist.Author.Title}\n------------------");
                                    break;
                                }
                        }
                        Application.DoEvents();
                        i++;
                    }
                }
                else if (VideoType == "playlist" || VideoType == "listVideo")
                {
                    await foreach (var video in youtube.Playlists.GetVideosAsync(VideoID))
                    {
                        RightVideo.Controls.Add(ListVideo($"{video.Id}", video.Title, video.Author.Title));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private async void VideoDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string address = $"{settings.VideoAddress}\\{VideoID}.mp4";
                YoutubeClient youtube = new YoutubeClient();
                if (RUD("영상을", address) == DialogResult.Yes)
                {
                    await youtube.Videos.DownloadAsync($"https://youtube.com/watch?v={VideoID}", address);
                    SucDown();
                }
            }
            catch (Exception ex)
            {
                if (ex is System.Reflection.TargetInvocationException) Error("영상을 찾을 수 없습니다...?");
            }
        }

        private void ThumbDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string address = $"{settings.ThumbAddress}\\{VideoID}.jpg";
                if (RUD("썸네일을", address) == DialogResult.Yes)
                {
                    using WebClient wc = new WebClient();
                    wc.DownloadFile(new Uri($"https://img.youtube.com/vi/{VideoID}/maxresdefault.jpg"), address);
                    SucDown();
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException) Error("썸네일을 찾을 수 없습니다.");
            }
        }

        private async void AllDonwload_Click(object sender, EventArgs e)
        {
            await AllDownload();
        }

        private async Task AllDownload()
        {
            try
            {
                string tempAddress = $@"{Temp}\{VideoID}";
                string showAddress = $"{settings.DocumentAddress}\\{VideoID}";
                string downloadAddress = tempAddress;
                if (settings.AllDownloadZip) showAddress += ".zip";
                else downloadAddress = showAddress;
                if (RUD("영상과 썸네일을", showAddress) == DialogResult.Yes)
                {
                    // Create Temp Directory
                    DirectoryInfo ddi = new DirectoryInfo(downloadAddress);
                    if (ddi.Exists == false) ddi.Create();
                    else
                    {
                        SucDown();
                        return;
                    }

                    // Thumbnail Download
                    using WebClient wc = new WebClient();
                    byte[] ThumbData = wc.DownloadData(new Uri($"https://img.youtube.com/vi/{VideoID}/maxresdefault.jpg"));
                    File.WriteAllBytes($"{downloadAddress}\\Thumbnail.jpg", ThumbData);
                    wc.Dispose();

                    // Video Download
                    YoutubeClient youtube = new YoutubeClient();
                    await youtube.Videos.DownloadAsync($"https://youtube.com/watch?v={VideoID}", $"{downloadAddress}\\Video.mp4");

                    if (settings.AllDownloadZip) ZipDirectory(tempAddress, showAddress);
                    SucDown();
                }
            }
            catch (Exception ex)
            {
                Error($"{ex.Message}\n파일이 다운로드 되지 않았습니다.\n썸네일 파일을 못 찾은 것 일 수도 있습니다.");
            }
        }

        private void Error(string MSG)
        {
            MessageBox.Show(MSG, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SucDown()
        {
            MessageBox.Show($"다운로드가 완료되었습니다.", "다운로드", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult RUD(string type, string address)
        {
            new Form1().MakeFolder();
            return MessageBox.Show($"{type} 다운로드 하시겠습니까?\n위치 : {address}", "다운로드", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void ZipDirectory(string directoryPath, string outputZipPath)
        {
            try
            {
                if (File.Exists(outputZipPath))
                {
                    File.Delete(outputZipPath);
                }
                ZipFile.CreateFromDirectory(directoryPath, outputZipPath);
            }
            catch (Exception ex)
            {
                Error($"{ex.Message}\n압축에 실패하였습니다.");
            }
        }
    }
}
