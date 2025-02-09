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
