using Newtonsoft.Json;

namespace OrkPrototype
{
    // Klasa Ork implementująca interfejs ICloneable
    internal class Ork : ICloneable
    {
        public int Age { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        // Implementacja metody Clone jako część wzorca Prototype
        public object Clone()
        {
            // Tworzenie głębokiej kopii obiektu przy użyciu serializacji JSON
            string serializedOrk = JsonConvert.SerializeObject(this);
            Ork clonedOrk = JsonConvert.DeserializeObject<Ork>(serializedOrk);

            // Dodanie logiki związanej z losową zmianą właściwości, jeśli to wymagane
            clonedOrk.Strength = new Random().Next(300);
            return clonedOrk;
        }

        // Dodatkowa metoda dla wygody, która zwraca typowany obiekt Ork
        public Ork DeepCopy()
        {
            return (Ork)this.Clone();
        }
    }
}
