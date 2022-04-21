namespace YTDownloader
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.FlowLayoutPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Setting = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Panel();
            this.YTBtn = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Left.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Location = new System.Drawing.Point(200, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1064, 75);
            this.Header.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Image = global::YTDownloader.Properties.Resources.SmileMoremi;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 75);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // Setting
            // 
            this.Setting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Setting.BackColor = System.Drawing.Color.Transparent;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Setting.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.Location = new System.Drawing.Point(3, 528);
            this.Setting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(194, 54);
            this.Setting.TabIndex = 0;
            this.Setting.Text = "설정";
            this.Setting.UseVisualStyleBackColor = false;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Left.Controls.Add(this.YTBtn);
            this.Left.Controls.Add(this.Setting);
            this.Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Left.Location = new System.Drawing.Point(0, 75);
            this.Left.Margin = new System.Windows.Forms.Padding(0);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(200, 606);
            this.Left.TabIndex = 4;
            // 
            // YTBtn
            // 
            this.YTBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YTBtn.BackColor = System.Drawing.Color.Transparent;
            this.YTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YTBtn.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.YTBtn.ForeColor = System.Drawing.Color.White;
            this.YTBtn.Location = new System.Drawing.Point(3, 17);
            this.YTBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YTBtn.Name = "YTBtn";
            this.YTBtn.Size = new System.Drawing.Size(194, 54);
            this.YTBtn.TabIndex = 1;
            this.YTBtn.Text = "유튜브";
            this.YTBtn.UseVisualStyleBackColor = false;
            this.YTBtn.Click += new System.EventHandler(this.YTBtn_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.White;
            this.View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.View.Location = new System.Drawing.Point(200, 75);
            this.View.Margin = new System.Windows.Forms.Padding(0);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(10);
            this.View.Size = new System.Drawing.Size(1064, 606);
            this.View.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Header, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.View, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Logo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Left.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel Header;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Setting;
        new private System.Windows.Forms.Panel Left;
        private System.Windows.Forms.Button YTBtn;
        public System.Windows.Forms.Panel View;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

