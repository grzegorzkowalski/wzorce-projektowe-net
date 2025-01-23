using System.Globalization;

namespace DownloadProxy
{
    internal class DownloadServiceProxy : IDownLoadService
    {
        private DownloadService downloadService;
        public void DownloadFilm(string title, string password)
        {
            var country = RegionInfo.CurrentRegion.DisplayName;
            if (password == "Test1234" && country == "Polska")
            {
                downloadService = new DownloadService();
                downloadService.DownloadFilm(title, password);
            }
            else
            {
                Console.WriteLine($"Błedne hasło lub {title} jest niedostępny w Twoim kraju.");
            }
        }
    }
}
