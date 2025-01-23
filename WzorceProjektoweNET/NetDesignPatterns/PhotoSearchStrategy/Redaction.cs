namespace PhotoSearchStrategy
{
    internal class Redaction
    {
        private IPhotoStrategy _strategy;

        internal List<string> FindPhotos(string category)
        {
            var list = new List<string>();  
            if (_strategy != null) 
            {
               list = _strategy.FindPhotos(category);
            }
            return list;
        }

        internal void SetStrategy(IPhotoStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
