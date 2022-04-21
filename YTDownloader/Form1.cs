using System;
using System.IO;
using System.Windows.Forms;


// 아니 시발 WebView2 왜 용량 400MB넘게먹냐
namespace YTDownloader
{
    public partial class Form1 : Form
    {
        public static Control nowControl = new YT().tableLayoutPanel1;
        public Form1()
        {
            InitializeComponent();
        }

        private void YTBtn_Click(object sender, EventArgs e)
        {
            ChangeView(new YT().tableLayoutPanel1);
        }
        public void ChangeView(TableLayoutPanel control)
        {
            nowControl.Dispose();
            nowControl = control;
            View.BackColor = nowControl.BackColor;
            View.Controls.Clear();
            View.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        private void Setting_Click(object sender, EventArgs e)
        {
            ChangeView(new Settings().tableLayoutPanel1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MakeFolder();
            View.Controls.Add(nowControl);
        }
        public void MakeFolder()
        {
            #region 영상 폴더 만들기
            if (Properties.Settings.Default.VideoAddress == "") Properties.Settings.Default.VideoAddress = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)}\YTDownloader";
            DirectoryInfo vdi = new DirectoryInfo(Properties.Settings.Default.VideoAddress);
            if (vdi.Exists == false) vdi.Create();
            #endregion
            #region 썸네일 폴더 만들기
            if (Properties.Settings.Default.ThumbAddress == "") Properties.Settings.Default.ThumbAddress = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\YTDownloader";
            DirectoryInfo tdi = new DirectoryInfo(Properties.Settings.Default.ThumbAddress);
            if (tdi.Exists == false) tdi.Create();
            #endregion
            #region 문서 폴더 만들기
            if (Properties.Settings.Default.DocumentAddress == "") Properties.Settings.Default.DocumentAddress = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\YTDownloader";
            DirectoryInfo ddi = new DirectoryInfo(Properties.Settings.Default.DocumentAddress);
            if (ddi.Exists == false) ddi.Create();
            #endregion
            #region 임시 폴더 만들기
            DirectoryInfo tempDi = new DirectoryInfo(Path.GetFullPath($@"{Environment.GetEnvironmentVariable("temp")}\YTDownloader"));
            if (tempDi.Exists == false) tempDi.Create();
            #endregion
        }
    }
}
