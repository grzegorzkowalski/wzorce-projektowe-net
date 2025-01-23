using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadProxy
{
    internal class DownloadService : IDownLoadService
    {
        public void DownloadFilm(string title, string password)
        {
            Console.WriteLine($"{title} - pobieranie ....");
            Console.WriteLine($"Film pobrany, miłego oglądania");
        }
    }
}
