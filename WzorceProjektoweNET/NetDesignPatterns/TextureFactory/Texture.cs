namespace TextureFactory
{
    public class Texture
    {
        public string FileName { get; private set; }

        public Texture(string fileName)
        {
            FileName = fileName;
            Console.WriteLine($"Loading texture from file: {fileName}");
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Rendering texture {FileName} at position ({x}, {y})");
        }
    }

    // Flyweight Factory
    public class TextureFactory
    {
        private Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

        public Texture GetTexture(string fileName)
        {
            if (!_textures.ContainsKey(fileName))
            {
                _textures[fileName] = new Texture(fileName);
            }
            return _textures[fileName];
        }
    }
}
