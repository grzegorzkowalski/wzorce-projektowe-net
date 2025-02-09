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
