using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class EspressoMachine : IEspressoMachine
    {
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();

        public IEspressoMachine AddBeans(CoffeSorts sort)
        {
            Ingredients.Add(new Bean() { Name = "Beans", Sort = sort });
            return this;
        }

        public IEspressoMachine AddChocolateSyrup()
        {
            Ingredients.Add(new Ingredient() { Name = "Chocolate Syrup" });
            return this;
        }

        public IEspressoMachine AddMilk()
        {
            Ingredients.Add(new Ingredient() { Name = "Milk" });
            return this;
        }

        public IEspressoMachine AddMilkFoam()
        {
            Ingredients.Add(new Ingredient() { Name = "Milk Foam" });
            return this;
        }

        public IEspressoMachine AddWater(int v)
        {
            Ingredients.Add(new Ingredient() { Name = "Water" });
            return this;
        }

        public IBeverage ToBeverage()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            
            // Loopa igenom alla tillgängliga typer i assemblyt
            foreach(var type in types)
            {
                // Kolla om nuvarande typen implementerar IBeverage
                if (type.GetInterfaces().Contains(typeof(IBeverage)))
                {
                    IBeverage beverage = (IBeverage)Activator.CreateInstance(type);
                    List<string> beverageIngredients = beverage.Ingredients.Select(ingr => ingr.Name).ToList();
                    List<string> ingredientList = Ingredients.Select(ingr => ingr.Name).ToList();

                    beverageIngredients.Sort();
                    ingredientList.Sort();

                    if (beverageIngredients.SequenceEqual(ingredientList))
                    {
                        return beverage;
                    }
                }
            }
            return new CustomBeverage();
        }
    }
}
