using System;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Search;

namespace YTDownloader
{
    public partial class YT : UserControl
    {
        private Properties.Settings settings = Properties.Settings.Default;
        public YT()
        {
            InitializeComponent();
        }

        public void Video_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            // 사실 얘 버튼이 아니라 픽쳐박스로 옴.
            PictureBox button = (PictureBox)sender;
            TableLayoutPanel control = new YTViewer(button.Name, SearchBox.Text).tableLayoutPanel1;
            control.Dock = DockStyle.Fill;
            tableLayoutPanel1.SetColumnSpan(control, 3);
            tableLayoutPanel1.SetRowSpan(control, 2);
            tableLayoutPanel1.Controls.Add(control);
        }

        private async void MakeVideo()
        {
            Videos.Controls.Clear();
            YoutubeClient youtube = new YoutubeClient();

            int i = 0;
            try
            {
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
                                Videos.Controls.Add(Video($"{video.Id}|video", video.Title, video.Author.Title));
                                //Console.WriteLine($"Title : {video.Title}\nID : {video.Id}\nAuthor : {video.Author.Title}\n------------------");
                                break;
                            }
                        case PlaylistSearchResult playlist:
                            {
                                Videos.Controls.Add(Video($"{playlist.Id}|playlist", $"{playlist.Title} (재생 목록)", playlist.Author.Title));
                                Console.WriteLine($"Title : {playlist.Title}(재생 목록)\nID : {playlist.Id}\nAuthor : {playlist.Author.Title}\n------------------");
                                break;
                            }
                    }
                    Application.DoEvents();
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
