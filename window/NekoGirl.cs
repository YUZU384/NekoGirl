using NekoGirl.web;
using System.Diagnostics;
using System.Security.Policy;

namespace NekoGirl
{
    public partial class NekoGirl : Form
    {
        //启动事件

        private readonly string SaveDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "neko");
        private readonly GetImage img = new ();
        private int currentIndex = -1;//url数组从0开始

        public NekoGirl()
        {
            InitializeComponent();

            Debug.WriteLine("保存目录: " + SaveDirectory);
            Directory.CreateDirectory(SaveDirectory);

            Load += NekoGirl_Load;//启动自动加载图片
        }

        private async void NekoGirl_Load(object? sender, EventArgs e)
        {
            await img.GetNextSetAsync();
            //await LoadImageAsync(currentIndex);
        }


        //按钮事件
        private async void Button_上_Click(object sender, EventArgs e)
        {
            if (currentIndex <= 0) return;

            ToggleButtons(false);

            Debug.WriteLine("当前id{0}|访问id{1}", currentIndex, currentIndex - 1);

            if (await LoadImageAsync(currentIndex - 1))
                currentIndex--;

            UpdateButtons();
        }

        private async void Button_下_Click(object sender, EventArgs e)
        {
            ToggleButtons(false);

            Debug.WriteLine("当前id{0}|访问id{1}|{2}",
                currentIndex, currentIndex + 1, currentIndex >= img.ImageCount - 2);

            // 快看完时预加载
            if (currentIndex >= img.ImageCount - 2)
                _ = img.GetNextSetAsync(); // 后台加载，不阻塞 UI

            if (await LoadImageAsync(currentIndex + 1))
                currentIndex++;

            UpdateButtons();
        }

        private async Task<bool> LoadImageAsync(int index)
        {
            ModifiedArtistLabel("正在加载图像，请等待喵......", "");

            var image = await img.GetImageAsync(index);
            if (image == null) {
                ModifiedArtistLabel("点击“下一只”开始获取喵~", "");
                return false;
            }


            pictureBox.Image?.Dispose();
            // pictureBox.Image = image;
            // 改为动态适应长宽比
            SmartFitImageSize(image);
            ModifiedArtistLabel("画师：@" + img.GetImageArtist(index), img.GetArtistLink(index));
            
            return true;
        }

        private void Button_存_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            string timestamp = DateTime.Now.ToString("yyyy-M-d_H-m-s");
            string filePath = Path.Combine(SaveDirectory, $"{timestamp}.png");

            pictureBox.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void Button_看_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", SaveDirectory);
        }


        //更改按钮状态
        private void ToggleButtons(bool enabled)
        {
            button_上.Enabled = enabled;
            button_下.Enabled = enabled;
        }

        private void UpdateButtons()
        {
            button_上.Enabled = currentIndex > 0;
            button_下.Enabled = true;
        }


        //更改图片框及标签状态
        private void SmartFitImageSize(Image image) {
            // 在 PictureBox 尺寸不变的情况下
            // 适配不同长宽比的图像
            if (pictureBox == null || image == null) return;

            double imgRatio       = (double)image.Width / (double)image.Height;
            double containerRatio = (double)pictureBox.Width / (double)pictureBox.Height;

            /*
            // 如果图像和容器比例差异大，使用Zoom Mode
            if (Math.Abs(imgRatio - containerRatio) > 0.2)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            */
            pictureBox.Image = image;
        }   

        private void ModifiedArtistLabel(string text, string linkUrl) {
            // 修改 ArtistLabel 的内容以及超链接
            if (text.Length > 20) { text = text.Substring(20) + "..."; }
            artistLabel.Text = text;

            if (!string.IsNullOrWhiteSpace(linkUrl))
            {
                artistLabel.LinkBehavior = LinkBehavior.HoverUnderline;
                artistLabel.LinkColor = Color.FromArgb(65, 105, 225);
                artistLabel.LinkClicked += (sender, e) =>
                {
                    System.Diagnostics.Process.Start(
                        new System.Diagnostics.ProcessStartInfo { FileName = linkUrl, UseShellExecute = true }
                    );
                };
            }
            else {
                artistLabel.LinkBehavior = LinkBehavior.NeverUnderline;
                artistLabel.LinkColor = Color.Black;
            }
        }
    }
}