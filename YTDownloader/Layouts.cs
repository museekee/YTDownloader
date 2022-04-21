using System;
using System.Drawing;
using System.Windows.Forms;

namespace YTDownloader
{
    partial class YT
    {
        private readonly int LW = 410; // Layout Width
        public FlowLayoutPanel Video(string id, string title, string channel)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Width = LW,
                Height = 330,
                Margin = new Padding(0, 0, 0, 0)
            };
            PictureBox pictureBox = new PictureBox
            {
                Width = LW,
                Height = 240,
                Name = id,
                InitialImage = Properties.Resources.YTErr,
                ErrorImage = Properties.Resources.YTErr,
                ImageLocation = $"https://img.youtube.com/vi/{id}/maxresdefault.jpg",
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (pictureBox.Image == pictureBox.ErrorImage)
            {
                pictureBox.ImageLocation = $"https://i1.ytimg.com/vi/{id}/hqdefault.jpg";
            }
            Label Title = new Label
            {
                Text = title,
                Font = new Font("맑은 고딕", 12, FontStyle.Bold),
                Width = LW,
                Height = 50,
                AutoSize = false
            };

            FlowLayoutPanel bottom = new FlowLayoutPanel
            {
                Width = LW,
                Height = 25,
                FlowDirection = FlowDirection.LeftToRight
            };
            Label Channel = new Label
            {
                Text = channel,
                Font = new Font("맑은 고딕", 10),
                Width = LW,
                Height = 25,
                AutoSize = false,
            };

            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += Video_Click;
            flowLayoutPanel.Controls.Add(pictureBox);
            flowLayoutPanel.Controls.Add(Title);
            bottom.Controls.Add(Channel);
            flowLayoutPanel.Controls.Add(bottom);
            return flowLayoutPanel;
        }
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "검색")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "검색";
                SearchBox.ForeColor = Color.Silver;
            }
        }
        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MakeVideo();
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            MakeVideo();
        }
    }
    partial class YTViewer
    {
        private readonly int MLW = 330; // Mini Layout Width
        public FlowLayoutPanel Video(string id, string title, string channel)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Width = MLW,
                Height = 270,
                Margin = new Padding(0, 0, 0, 0),
                FlowDirection = FlowDirection.TopDown,
                Left = (RightVideo.Width - MLW) / 2,
            };
            PictureBox pictureBox = new PictureBox
            {
                Width = MLW,
                Height = 190,
                Name = id,
                InitialImage = Properties.Resources.YTErr,
                ErrorImage = Properties.Resources.YTErr,
                ImageLocation = $"https://img.youtube.com/vi/{id}/maxresdefault.jpg",
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (pictureBox.Image == pictureBox.ErrorImage)
            {
                pictureBox.ImageLocation = $"https://i1.ytimg.com/vi/{id}/hqdefault.jpg";
            }
            Label Title = new Label
            {
                Text = title,
                Font = new Font("맑은 고딕", 11, FontStyle.Bold),
                MaximumSize = new Size(0, 50),
                AutoSize = true
            };
            Label Channel = new Label
            {
                Text = channel,
                Font = new Font("맑은 고딕", 9),
                MaximumSize = new Size(0, 25),
                AutoSize = true
            };

            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += Video_Click;
            flowLayoutPanel.Controls.Add(pictureBox);
            flowLayoutPanel.Controls.Add(Title);
            flowLayoutPanel.Controls.Add(Channel);
            return flowLayoutPanel;
        }
        private FlowLayoutPanel ListVideo(string id, string title, string channel)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Width = MLW,
                Height = 270,
                Margin = new Padding(0, 0, 0, 0),
                FlowDirection = FlowDirection.TopDown,
                Left = (RightVideo.Width - MLW) / 2,
            };
            PictureBox pictureBox = new PictureBox
            {
                Width = MLW,
                Height = 190,
                Name = $"{id}|listVideo",
                InitialImage = Properties.Resources.YTErr,
                ErrorImage = Properties.Resources.YTErr,
                ImageLocation = $"https://img.youtube.com/vi/{id}/maxresdefault.jpg",
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (pictureBox.Image == pictureBox.ErrorImage)
            {
                pictureBox.ImageLocation = $"https://i1.ytimg.com/vi/{id}/hqdefault.jpg";
            }
            Label Title = new Label
            {
                Text = title,
                Font = new Font("맑은 고딕", 11, FontStyle.Bold),
                MaximumSize = new Size(0, 50),
                AutoSize = true
            };
            Label Channel = new Label
            {
                Text = channel,
                Font = new Font("맑은 고딕", 9),
                MaximumSize = new Size(0, 25),
                AutoSize = true
            };

            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += Video_Click;
            flowLayoutPanel.Controls.Add(pictureBox);
            flowLayoutPanel.Controls.Add(Title);
            flowLayoutPanel.Controls.Add(Channel);
            return flowLayoutPanel;
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "검색")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "검색";
                SearchBox.ForeColor = Color.Silver;
            }
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchText = SearchBox.Text;
                VideoType = "video";
                MakeVideo();
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            VideoType = "video";
            SearchText = SearchBox.Text;
            MakeVideo();
        }
    }



    //////////////////DELETED///////////////////
    [Obsolete("This code is not using.")]
    class Deleted
    {
        private readonly int LW = 420; // Layout Width
        public FlowLayoutPanel Channel(string ProfilePic, string channelTitle)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Width = LW,
                Height = 330,
                Margin = new Padding(0, 0, 0, 0)
            };

            PictureBox pictureBox = new PictureBox
            {
                Width = LW,
                Height = 265,
                InitialImage = Properties.Resources.YTErr,
                ErrorImage = Properties.Resources.YTErr,
                ImageLocation = ProfilePic,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            Label Title = new Label
            {
                Text = channelTitle,
                Font = new Font("맑은 고딕", 15, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Width = LW,
                Height = 50,
                AutoSize = false
            };

            flowLayoutPanel.Controls.Add(pictureBox);
            flowLayoutPanel.Controls.Add(Title);
            return flowLayoutPanel;
        }
    }
}
