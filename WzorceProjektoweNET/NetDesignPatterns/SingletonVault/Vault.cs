namespace SingletonVault
{
    public sealed class Vault
    {
        private static string key;
        private static Vault vault;
        private static object lockObject = new Object();

        private Vault() 
        {
            key = createKey();
        }

        public static Vault Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (vault == null)
                    {
                        vault = new Vault();
                    }
                }

                return vault;
            }
        }

        private static string createKey()
        {
            var random = new Random();
            return "dfsd45454dsfgdgfdgd454353345" + random.Next().ToString();
        }


        public void getKey()
        {            
            Console.WriteLine($"Klucz do systemu: {key}");
        }

    }
}
