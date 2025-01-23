using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSearchStrategy
{
    internal class Pixabay : IPhotoStrategy
    {
        public List<string> FindPhotos(string category)
        {
            return new List<string>() { "kotek2", "piesek2", "kurka2" };
        }
    }
}
