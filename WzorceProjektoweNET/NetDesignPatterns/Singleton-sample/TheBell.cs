namespace Singleton_
{
    public sealed class TheBell
    {
        private static TheBell bellConnection;
        private static object syncRoot = new Object();
        private TheBell()
        {
        }

        public static TheBell Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (bellConnection == null)
                    {
                        bellConnection = new TheBell();
                    }
                }

                return bellConnection;
            }
        }

        public void Ring()
        {
            Console.WriteLine("Ding! Order up!");
        }
    }
}
