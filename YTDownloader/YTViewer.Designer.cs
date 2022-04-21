namespace YTDownloader
{
    partial class YTViewer
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.VideoDownload = new System.Windows.Forms.Button();
            this.ShareBtn = new System.Windows.Forms.Button();
            this.RightVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.ChannelInfo = new System.Windows.Forms.Panel();
            this.ChannelPic = new System.Windows.Forms.PictureBox();
            this.ChannelName = new System.Windows.Forms.Label();
            this.VideoDate = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.detailVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.YTViewerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.YTEmbed = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AllDonwload = new System.Windows.Forms.Button();
            this.ThumbDownload = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.YTLogo = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ChannelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelPic)).BeginInit();
            this.detailVideo.SuspendLayout();
            this.YTViewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YTEmbed)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YTLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoDownload
            // 
            this.VideoDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.VideoDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VideoDownload.Location = new System.Drawing.Point(200, 3);
            this.VideoDownload.Name = "VideoDownload";
            this.VideoDownload.Size = new System.Drawing.Size(191, 44);
            this.VideoDownload.TabIndex = 1;
            this.VideoDownload.Text = "영상 다운로드";
            this.VideoDownload.UseVisualStyleBackColor = false;
            this.VideoDownload.Click += new System.EventHandler(this.VideoDownload_Click);
            // 
            // ShareBtn
            // 
            this.ShareBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ShareBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShareBtn.Location = new System.Drawing.Point(3, 3);
            this.ShareBtn.Name = "ShareBtn";
            this.ShareBtn.Size = new System.Drawing.Size(191, 44);
            this.ShareBtn.TabIndex = 0;
            this.ShareBtn.Text = "공유";
            this.ShareBtn.UseVisualStyleBackColor = false;
            this.ShareBtn.Click += new System.EventHandler(this.ShareBtn_Click);
            // 
            // RightVideo
            // 
            this.RightVideo.AutoScroll = true;
            this.RightVideo.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.RightVideo, 2);
            this.RightVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightVideo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RightVideo.Location = new System.Drawing.Point(3, 103);
            this.RightVideo.Name = "RightVideo";
            this.RightVideo.Size = new System.Drawing.Size(388, 443);
            this.RightVideo.TabIndex = 1;
            this.RightVideo.WrapContents = false;
            // 
            // ChannelInfo
            // 
            this.ChannelInfo.Controls.Add(this.ChannelPic);
            this.ChannelInfo.Controls.Add(this.ChannelName);
            this.ChannelInfo.Location = new System.Drawing.Point(3, 53);
            this.ChannelInfo.Name = "ChannelInfo";
            this.ChannelInfo.Size = new System.Drawing.Size(697, 50);
            this.ChannelInfo.TabIndex = 3;
            // 
            // ChannelPic
            // 
            this.ChannelPic.ErrorImage = global::YTDownloader.Properties.Resources.YTErr;
            this.ChannelPic.Location = new System.Drawing.Point(3, 3);
            this.ChannelPic.Name = "ChannelPic";
            this.ChannelPic.Size = new System.Drawing.Size(44, 44);
            this.ChannelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChannelPic.TabIndex = 2;
            this.ChannelPic.TabStop = false;
            // 
            // ChannelName
            // 
            this.ChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChannelName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChannelName.Location = new System.Drawing.Point(53, 15);
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.Size = new System.Drawing.Size(590, 20);
            this.ChannelName.TabIndex = 1;
            this.ChannelName.Text = "채널명";
            // 
            // VideoDate
            // 
            this.VideoDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoDate.AutoSize = true;
            this.VideoDate.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VideoDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.VideoDate.Location = new System.Drawing.Point(3, 30);
            this.VideoDate.Name = "VideoDate";
            this.VideoDate.Size = new System.Drawing.Size(697, 20);
            this.VideoDate.TabIndex = 3;
            this.VideoDate.Text = "1970.01.01";
            this.VideoDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.MaximumSize = new System.Drawing.Size(0, 55);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(697, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "제목";
            // 
            // detailVideo
            // 
            this.detailVideo.AutoScroll = true;
            this.detailVideo.BackColor = System.Drawing.Color.Transparent;
            this.detailVideo.Controls.Add(this.Title);
            this.detailVideo.Controls.Add(this.VideoDate);
            this.detailVideo.Controls.Add(this.ChannelInfo);
            this.detailVideo.Controls.Add(this.description);
            this.detailVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailVideo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.detailVideo.Location = new System.Drawing.Point(6, 386);
            this.detailVideo.Margin = new System.Windows.Forms.Padding(6);
            this.detailVideo.Name = "detailVideo";
            this.detailVideo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.detailVideo.Size = new System.Drawing.Size(646, 163);
            this.detailVideo.TabIndex = 2;
            this.detailVideo.WrapContents = false;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(3, 106);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(83, 17);
            this.description.TabIndex = 4;
            this.description.Text = "               ";
            // 
            // YTViewerPanel
            // 
            this.YTViewerPanel.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.YTViewerPanel, 3);
            this.YTViewerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.YTViewerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.YTViewerPanel.Controls.Add(this.detailVideo, 0, 1);
            this.YTViewerPanel.Controls.Add(this.YTEmbed, 0, 0);
            this.YTViewerPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.YTViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YTViewerPanel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.YTViewerPanel.Location = new System.Drawing.Point(3, 48);
            this.YTViewerPanel.Name = "YTViewerPanel";
            this.YTViewerPanel.RowCount = 2;
            this.YTViewerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.YTViewerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.YTViewerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.YTViewerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.YTViewerPanel.Size = new System.Drawing.Size(1058, 555);
            this.YTViewerPanel.TabIndex = 3;
            // 
            // YTEmbed
            // 
            this.YTEmbed.CreationProperties = null;
            this.YTEmbed.DefaultBackgroundColor = System.Drawing.Color.White;
            this.YTEmbed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YTEmbed.Location = new System.Drawing.Point(3, 3);
            this.YTEmbed.Name = "YTEmbed";
            this.YTEmbed.Size = new System.Drawing.Size(652, 374);
            this.YTEmbed.TabIndex = 4;
            this.YTEmbed.ZoomFactor = 1D;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AllDonwload, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ThumbDownload, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.RightVideo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.VideoDownload, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ShareBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(661, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.YTViewerPanel.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 549);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // AllDonwload
            // 
            this.AllDonwload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.AllDonwload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllDonwload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllDonwload.Location = new System.Drawing.Point(200, 53);
            this.AllDonwload.Name = "AllDonwload";
            this.AllDonwload.Size = new System.Drawing.Size(191, 44);
            this.AllDonwload.TabIndex = 3;
            this.AllDonwload.Text = "영상, 썸네일 다운로드";
            this.AllDonwload.UseVisualStyleBackColor = false;
            this.AllDonwload.Click += new System.EventHandler(this.AllDonwload_Click);
            // 
            // ThumbDownload
            // 
            this.ThumbDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ThumbDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThumbDownload.Location = new System.Drawing.Point(3, 53);
            this.ThumbDownload.Name = "ThumbDownload";
            this.ThumbDownload.Size = new System.Drawing.Size(191, 44);
            this.ThumbDownload.TabIndex = 2;
            this.ThumbDownload.Text = "썸네일 다운로드";
            this.ThumbDownload.UseVisualStyleBackColor = false;
            this.ThumbDownload.Click += new System.EventHandler(this.ThumbDownload_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.SearchBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.YTViewerPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.YTLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 606);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBtn.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.SearchBtn.Location = new System.Drawing.Point(977, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(84, 39);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // YTLogo
            // 
            this.YTLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YTLogo.Image = global::YTDownloader.Properties.Resources.YoutubeLogo;
            this.YTLogo.Location = new System.Drawing.Point(0, 0);
            this.YTLogo.Margin = new System.Windows.Forms.Padding(0);
            this.YTLogo.Name = "YTLogo";
            this.YTLogo.Size = new System.Drawing.Size(230, 45);
            this.YTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YTLogo.TabIndex = 0;
            this.YTLogo.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.SearchBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchBox.Location = new System.Drawing.Point(233, 9);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(738, 27);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Text = "검색";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // YTViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "YTViewer";
            this.Size = new System.Drawing.Size(1064, 606);
            this.ChannelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChannelPic)).EndInit();
            this.detailVideo.ResumeLayout(false);
            this.detailVideo.PerformLayout();
            this.YTViewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YTEmbed)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YTLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel RightVideo;
        private System.Windows.Forms.Button VideoDownload;
        private System.Windows.Forms.Button ShareBtn;
        private System.Windows.Forms.FlowLayoutPanel detailVideo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label VideoDate;
        private System.Windows.Forms.Panel ChannelInfo;
        private System.Windows.Forms.PictureBox ChannelPic;
        private System.Windows.Forms.Label ChannelName;
        private Microsoft.Web.WebView2.WinForms.WebView2 YTEmbed;
        public System.Windows.Forms.TableLayoutPanel YTViewerPanel;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.PictureBox YTLogo;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AllDonwload;
        private System.Windows.Forms.Button ThumbDownload;
    }
}
