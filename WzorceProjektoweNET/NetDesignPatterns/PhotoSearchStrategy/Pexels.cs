using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSearchStrategy
{
    internal class Pexels : IPhotoStrategy
    {
        public List<string> FindPhotos(string category)
        {
            return new List<string>() { "kotek", "piesek", "kurka" };
        }
    }
}
