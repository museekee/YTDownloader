namespace YTDownloader
{
    partial class Settings
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
            this.SearchNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Zip = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.reset = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VideoSaveTBox = new System.Windows.Forms.TextBox();
            this.ThumbDownloadTBox = new System.Windows.Forms.TextBox();
            this.AllDownloadTbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchNum
            // 
            this.SearchNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.SearchNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchNum.DropDownHeight = 125;
            this.SearchNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchNum.ForeColor = System.Drawing.Color.White;
            this.SearchNum.FormattingEnabled = true;
            this.SearchNum.IntegralHeight = false;
            this.SearchNum.Items.AddRange(new object[] {
            "무한",
            "1",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "225",
            "250",
            "275",
            "300",
            "350",
            "400",
            "450",
            "500"});
            this.SearchNum.Location = new System.Drawing.Point(351, 0);
            this.SearchNum.Margin = new System.Windows.Forms.Padding(0);
            this.SearchNum.Name = "SearchNum";
            this.SearchNum.Size = new System.Drawing.Size(713, 28);
            this.SearchNum.TabIndex = 1;
            this.SearchNum.SelectedIndexChanged += new System.EventHandler(this.SearchNum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "영상 로딩 개수";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Zip, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchNum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.VideoSaveTBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ThumbDownloadTBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AllDownloadTbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 606);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zip.Location = new System.Drawing.Point(354, 33);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(707, 24);
            this.Zip.TabIndex = 4;
            this.Zip.UseVisualStyleBackColor = true;
            this.Zip.CheckedChanged += new System.EventHandler(this.Zip_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zip 압축";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.reset, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Save, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 559);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1058, 44);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(3, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(523, 38);
            this.reset.TabIndex = 1;
            this.reset.Text = "초기화";
            this.reset.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Location = new System.Drawing.Point(532, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(523, 38);
            this.Save.TabIndex = 0;
            this.Save.Text = "저장";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "영상 저장 경로";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "썸네일 저장 경로";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "모두 다운로드 저장 경로";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VideoSaveTBox
            // 
            this.VideoSaveTBox.BackColor = System.Drawing.Color.White;
            this.VideoSaveTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoSaveTBox.Location = new System.Drawing.Point(354, 63);
            this.VideoSaveTBox.Name = "VideoSaveTBox";
            this.VideoSaveTBox.ReadOnly = true;
            this.VideoSaveTBox.Size = new System.Drawing.Size(707, 27);
            this.VideoSaveTBox.TabIndex = 10;
            this.VideoSaveTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveTbox_MouseDown);
            // 
            // ThumbDownloadTBox
            // 
            this.ThumbDownloadTBox.BackColor = System.Drawing.Color.White;
            this.ThumbDownloadTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbDownloadTBox.Location = new System.Drawing.Point(354, 93);
            this.ThumbDownloadTBox.Name = "ThumbDownloadTBox";
            this.ThumbDownloadTBox.ReadOnly = true;
            this.ThumbDownloadTBox.Size = new System.Drawing.Size(707, 27);
            this.ThumbDownloadTBox.TabIndex = 11;
            this.ThumbDownloadTBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveTbox_MouseDown);
            // 
            // AllDownloadTbox
            // 
            this.AllDownloadTbox.BackColor = System.Drawing.Color.White;
            this.AllDownloadTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllDownloadTbox.Location = new System.Drawing.Point(354, 123);
            this.AllDownloadTbox.Name = "AllDownloadTbox";
            this.AllDownloadTbox.ReadOnly = true;
            this.AllDownloadTbox.Size = new System.Drawing.Size(707, 27);
            this.AllDownloadTbox.TabIndex = 12;
            this.AllDownloadTbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveTbox_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 346);
            this.label6.TabIndex = 13;
            this.label6.Text = "도움말";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(354, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(707, 346);
            this.label7.TabIndex = 14;
            this.label7.Text = "텍스트박스를 휠(가운데)클릭 하시면 폴더 선택 창이 나타납니다.\r\nZip압축을 하지 않는걸 추천합니다. (다운로드 속도도 느리고 압축률도 좋지 않" +
    "아요)";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1064, 606);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox SearchNum;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox Zip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VideoSaveTBox;
        private System.Windows.Forms.TextBox ThumbDownloadTBox;
        private System.Windows.Forms.TextBox AllDownloadTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
