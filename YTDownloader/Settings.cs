using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows.Forms;

namespace YTDownloader
{
    public partial class Settings : UserControl
    {
        private readonly Properties.Settings settings = Properties.Settings.Default;
        public Settings()
        {
            InitializeComponent();
            if (settings.SearchNumber.ToString() == "0") SearchNum.SelectedItem = "무한";
            else SearchNum.SelectedItem = settings.SearchNumber.ToString();
            Zip.Checked = settings.AllDownloadZip;
            VideoSaveTBox.Text = settings.VideoAddress;
            ThumbDownloadTBox.Text = settings.ThumbAddress;
            AllDownloadTbox.Text = settings.DocumentAddress;
        }

        private void SearchNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchNum.SelectedItem.ToString() == "무한") settings.SearchNumber = 0;
            else settings.SearchNumber = int.Parse(SearchNum.SelectedItem.ToString());
        }

        private void Zip_CheckedChanged(object sender, EventArgs e)
        {
            settings.AllDownloadZip = Zip.Checked;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            settings.Save();
            new Form1().MakeFolder();
            MessageBox.Show("저장 되었습니다.", "설정", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveTbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                TextBox textBox = (TextBox)sender;
                CommonOpenFileDialog dialog = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    InitialDirectory = textBox.Text
                };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    textBox.Text = dialog.FileName;
                    if (textBox == VideoSaveTBox) settings.VideoAddress = dialog.FileName;
                    if (textBox == ThumbDownloadTBox) settings.ThumbAddress = dialog.FileName;
                    if (textBox == AllDownloadTbox) settings.DocumentAddress = dialog.FileName;
                }
            }
        }
    }
}
