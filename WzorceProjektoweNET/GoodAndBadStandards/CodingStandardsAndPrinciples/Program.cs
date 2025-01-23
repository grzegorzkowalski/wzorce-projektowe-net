using System;

namespace CH01_CodingStandardsAndPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            BadCooking();
            GoodCooking();
            Console.WriteLine("Abny kontynuować, naciśnij dowolny klawisz.");
            Console.ReadKey();
        }

        private static void BadCooking()
        {
            var cookingClass = new BadCode.Food.CookingClass();
            cookingClass.StartCookingLesson();
        }

        private static void GoodCooking()
        {
            var cookingClass = new GoodCode.Food.CookingClass();
            cookingClass.StartCookingLesson();
        }
    }
}
