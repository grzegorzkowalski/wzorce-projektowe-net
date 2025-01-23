using Newtonsoft.Json;

namespace OrkPrototype
{
    internal class Ork
    {     
        public int Age { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }

        public Ork copyOrk()
        {
            string orkCopy = JsonConvert.SerializeObject(this);
            Ork copiedOrk = JsonConvert.DeserializeObject<Ork>(orkCopy);
            copiedOrk.Strenght = new Random().Next(300);
            return copiedOrk;
        }
    }
}
