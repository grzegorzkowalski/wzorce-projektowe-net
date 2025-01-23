using System;

namespace CH01_CodingStandardsAndPrinciples.GoodCode.Food
{
    public class CookingClass
    {
        private static IChef _chef;

        public void StartCookingLesson()
        {
            CookingLesson(new SushiChef());
            CookingLesson(new VeganChef());
        }

        private static void CookingLesson(IChef chef)
        {
            _chef = chef;
            _chef.FoodCookingHandler += Chef_FoodCookingHandler;
            _chef.FoodCookedHandler += Chef_FoodCookedHandler;
            _chef.StartCooking();
        }

        private static void Chef_FoodCookedHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Mistrz {_chef.Speciality}  zakończył prowadzenie lekcji gotowania w specjalności {_chef.Speciality}.");
            Console.WriteLine($"Lekcja {_chef.Speciality} zakońćzona!");
        }

        private static void Chef_FoodCookingHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Mistrz {_chef.Speciality}  prowadzi lekcję gotowania w specjalności {_chef.Speciality}.");
            Console.WriteLine($"Studenci specjalności {_chef.Speciality} obserwują i robią notatki...");
        }
    }
}
