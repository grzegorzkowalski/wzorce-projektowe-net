using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_sample
{
    abstract class Ingredient { }
    class Bread : Ingredient { }
    class Turkey : Ingredient { }
    class Lettuce : Ingredient { }
    class Mayonnaise : Ingredient { }

    abstract class Sandwich
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        //Factory method
        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
        }
    }

    class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Bread());
        }
    }

    class Dagwood : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
        }
    }
}
