using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    class EspressoMachine : IEspressoMachine
    {
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();

        public IEspressoMachine AddBeans()
        {

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
            
            foreach(var type in types)
            {
                if (type.GetInterfaces().Contains(typeof(IBeverage)))
                {

                }
            }



        }
    }
}
