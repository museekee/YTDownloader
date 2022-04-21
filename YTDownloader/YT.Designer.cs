namespace YTDownloader
{
    partial class YT
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
            this.Videos = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.YTLogo = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.View = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.YTLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.View.SuspendLayout();
            this.SuspendLayout();
            // 
            // Videos
            // 
            this.Videos.AutoScroll = true;
            this.Videos.BackColor = System.Drawing.Color.White;
            this.Videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Videos.Location = new System.Drawing.Point(0, 0);
            this.Videos.Margin = new System.Windows.Forms.Padding(0);
            this.Videos.Name = "Videos";
            this.Videos.Size = new System.Drawing.Size(1058, 555);
            this.Videos.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.View, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchBtn, 2, 0);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // View
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.View, 3);
            this.View.Controls.Add(this.Videos);
            this.View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View.Location = new System.Drawing.Point(3, 48);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(1058, 555);
            this.View.TabIndex = 0;
            // 
            // YT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "YT";
            this.Size = new System.Drawing.Size(1064, 606);
            ((System.ComponentModel.ISupportInitialize)(this.YTLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.View.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Videos;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox YTLogo;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel View;
    }
}
