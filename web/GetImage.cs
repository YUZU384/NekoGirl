using System.Diagnostics;
using System.Text.Json;

namespace NekoGirl.web
{
	internal class GetImage
	{
        private static readonly HttpClient httpClient = new (new SocketsHttpHandler
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(2) // 建议设置为2-5分钟
        })
        {
            Timeout = TimeSpan.FromSeconds(10)
        };


        private readonly List<string> imageUrls = [];
		private readonly List<string> artistNames = [];
		private readonly List<string> artistLinks = [];

		public int ImageCount => imageUrls.Count;

		static GetImage()
		{
			httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
				"Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
		}


		/// 获取下一批 URL
		public async Task GetNextSetAsync()
		{
			try
			{
				await Task.Delay(200);

				for (int k = 0; k < 5; k++)
				{
					string json = await httpClient.GetStringAsync(
						"https://nekos.best/api/v2/neko");

					using JsonDocument doc = JsonDocument.Parse(json);

					string? url = doc.RootElement
						.GetProperty("results")[0]
						.GetProperty("url")
						.GetString();

					string? name = doc.RootElement
						.GetProperty("results")[0]
						.GetProperty("artist_name")
						.GetString();
					
					string? link = doc.RootElement
						.GetProperty("results")[0]
						.GetProperty("artist_href")
						.GetString();

					if (!string.IsNullOrWhiteSpace(url))
					{
						imageUrls.Add(url);
						artistNames.Add(name);
						artistLinks.Add(link);
						Debug.WriteLine($"[成功] 获取URL: {url}，作者名:{name}");
					}

					await Task.Delay(100);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"[获取失败] {ex.Message}");
			}
		}


		/// 下载图片
		public async Task<Image?> GetImageAsync(int index)
		{
			if (index < 0 || index > imageUrls.Count)
			{
				Debug.WriteLine($"[跳过] 索引 {index} 无效");
				return null;
			}
			
			try
			{
				string url = imageUrls[index];
				Debug.WriteLine($"[加载] {url}");

				byte[] imageBytes = await httpClient.GetByteArrayAsync(url);

				using var ms = new MemoryStream(imageBytes);
				return Image.FromStream(ms);
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"[图片加载失败] {ex.Message}");
				return null;
			}
		}
		public string GetImageArtist(int index)
		{
			return artistNames[index];
		}
		public string GetArtistLink(int index) { 
			return artistLinks[index];
		}
	}
}