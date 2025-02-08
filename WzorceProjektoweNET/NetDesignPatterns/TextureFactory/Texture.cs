namespace TextureFactory_
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
}
