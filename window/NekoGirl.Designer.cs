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
            pictureBox.Size = new Size(1335, 780);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // button_上
            // 
            button_上.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_上.Enabled = false;
            button_上.Location = new Point(8, 788);
            button_上.Margin = new Padding(4);
            button_上.Name = "button_上";
            button_上.Size = new Size(82, 45);
            button_上.TabIndex = 0;
            button_上.TabStop = false;
            button_上.Text = "上一只";
            button_上.UseVisualStyleBackColor = true;
            button_上.Click += Button_上_Click;
            // 
            // button_下
            // 
            button_下.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_下.Location = new Point(99, 788);
            button_下.Margin = new Padding(4);
            button_下.Name = "button_下";
            button_下.Size = new Size(82, 45);
            button_下.TabIndex = 0;
            button_下.TabStop = false;
            button_下.Text = "下一只";
            button_下.UseVisualStyleBackColor = true;
            button_下.Click += Button_下_Click;
            // 
            // button_存
            // 
            button_存.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_存.Location = new Point(1087, 788);
            button_存.Margin = new Padding(4);
            button_存.Name = "button_存";
            button_存.Size = new Size(98, 45);
            button_存.TabIndex = 0;
            button_存.TabStop = false;
            button_存.Text = "保存图片";
            button_存.UseVisualStyleBackColor = true;
            button_存.Click += Button_存_Click;
            // 
            // button_看
            // 
            button_看.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_看.Location = new Point(1193, 788);
            button_看.Margin = new Padding(4);
            button_看.Name = "button_看";
            button_看.Size = new Size(135, 45);
            button_看.TabIndex = 0;
            button_看.TabStop = false;
            button_看.Text = "打开保存目录";
            button_看.UseVisualStyleBackColor = true;
            button_看.Click += Button_看_Click;
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new Point(537, 798);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(217, 24);
            artistLabel.Font = new Font("Microsoft YaHei", button_上.Font.Size);
            artistLabel.TabIndex = 1;
            artistLabel.Text = "点击“下一只”开始获取喵~";
            artistLabel.TextAlign = ContentAlignment.MiddleCenter;
            artistLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            artistLabel.LinkColor = Color.Black;
            // 
            // NekoGirl
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1335, 842);
            Controls.Add(artistLabel);
            Controls.Add(button_看);
            Controls.Add(button_存);
            Controls.Add(button_下);
            Controls.Add(button_上);
            Controls.Add(pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(589, 872);
            Name = "NekoGirl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoGirl-猫娘下载器，随机获取猫娘";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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