namespace NekoGirl
{
    partial class NekoGirl
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NekoGirl));
            pictureBox = new PictureBox();
            button_上 = new Button();
            button_下 = new Button();
            button_存 = new Button();
            button_看 = new Button();
            artistLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(444, 620);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // button_上
            // 
            button_上.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_上.Enabled = false;
            button_上.Location = new Point(5, 625);
            button_上.Name = "button_上";
            button_上.Size = new Size(55, 30);
            button_上.TabIndex = 0;
            button_上.TabStop = false;
            button_上.Text = "上一只";
            button_上.UseVisualStyleBackColor = true;
            button_上.Click += Button_上_Click;
            // 
            // button_下
            // 
            button_下.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_下.Location = new Point(65, 625);
            button_下.Name = "button_下";
            button_下.Size = new Size(55, 30);
            button_下.TabIndex = 0;
            button_下.TabStop = false;
            button_下.Text = "下一只";
            button_下.UseVisualStyleBackColor = true;
            button_下.Click += Button_下_Click;
            // 
            // button_存
            // 
            button_存.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_存.Location = new Point(279, 625);
            button_存.Name = "button_存";
            button_存.Size = new Size(65, 30);
            button_存.TabIndex = 0;
            button_存.TabStop = false;
            button_存.Text = "保存图片";
            button_存.UseVisualStyleBackColor = true;
            button_存.Click += Button_存_Click;
            // 
            // button_看
            // 
            button_看.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_看.Location = new Point(349, 625);
            button_看.Name = "button_看";
            button_看.Size = new Size(90, 30);
            button_看.TabIndex = 0;
            button_看.TabStop = false;
            button_看.Text = "打开保存目录";
            button_看.UseVisualStyleBackColor = true;
            button_看.Click += Button_看_Click;
            // 
            // artistLabel
            // 
            artistLabel.Anchor = AnchorStyles.Bottom;
            artistLabel.Font = new Font("微软雅黑", 9F);
            artistLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            artistLabel.LinkColor = Color.Black;
            artistLabel.Location = new Point(-98, 630);
            artistLabel.Margin = new Padding(2, 0, 2, 0);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(595, 20);
            artistLabel.TabIndex = 1;
            artistLabel.TabStop = true;
            artistLabel.Text = "点击“下一只”开始获取喵~";
            artistLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NekoGirl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(444, 661);
            Controls.Add(button_看);
            Controls.Add(button_存);
            Controls.Add(button_下);
            Controls.Add(button_上);
            Controls.Add(pictureBox);
            Controls.Add(artistLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(460, 700);
            Name = "NekoGirl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoGirl-猫娘下载器，随机获取猫娘";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pictureBox;
        public Button button_上;
        public Button button_下;
        private Button button_存;
        private Button button_看;
        private LinkLabel artistLabel;
    }
}