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
            var image = await img.GetImageAsync(index);
            if (image == null) return false;

            pictureBox.Image?.Dispose();
            pictureBox.Image = image;

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
    }
}