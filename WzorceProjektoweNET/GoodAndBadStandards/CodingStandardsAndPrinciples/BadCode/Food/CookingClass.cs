using System;

namespace CH01_CodingStandardsAndPrinciples.BadCode.Food
{
    public class CookingClass
    {
        private SushiChef _sushiChef;
        private VeganChef _veganChef;

        public void StartCookingLesson()
        {
            SushiCookingLesson();
            VeganCookingLesson();
        }

        private void SushiCookingLesson()
        {
            _sushiChef = new SushiChef();
            _sushiChef.FoodCookedHandler += SushiChef_FoodCookedHandler;
            _sushiChef.FoodCookingHandler += SushiChef_FoodCookingHandler;
            _sushiChef.StartCooking();
        }

        private void SushiChef_FoodCookingHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Mistrz {_sushiChef.Speciality}  prowadzi lekcję gotowania w specjalności {_sushiChef.Speciality}.");
            Console.WriteLine($"Studenci specjalności {_sushiChef.Speciality} obserwują i robią notatki...");
        }

        private void SushiChef_FoodCookedHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Mistrz {_sushiChef.Speciality}  zakończył prowadzenie lekcji gotowania w specjalności {_sushiChef.Speciality}.");
            Console.WriteLine($"Lekcja gotowania {_sushiChef.Speciality} zakończona!");
        }

        private void VeganCookingLesson()
        {
            _veganChef = new VeganChef();
            _veganChef.FoodCookedHandler += VeganChef_FoodCookedHandler;
            _veganChef.FoodCookingHandler += VeganChef_FoodCookingHandler;
            _veganChef.StartCooking();
        }

        private void VeganChef_FoodCookingHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Mistrz {_veganChef.Speciality} prowadzi lekcję gotowania w specjalności {_veganChef.Speciality}.");
            Console.WriteLine($"Studenci specjalności {_veganChef.Speciality} obserwują i robią notatki...");
        }

        private void VeganChef_FoodCookedHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Mistrz {_veganChef.Speciality} zakończył prowadzenie lekcji gotowania w specjalności {_veganChef.Speciality}.");
            Console.WriteLine($"Lekcja gotowania {_veganChef.Speciality} zakończona!");
        }
    }
}
