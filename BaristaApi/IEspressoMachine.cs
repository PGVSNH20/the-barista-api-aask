using System.Collections.Generic;

namespace BaristaApi
{
    public interface IEspressoMachine
    {
        List<Ingredient>Ingredients { get; }
        IEspressoMachine AddWater(int v);
        IEspressoMachine AddBeans(CoffeSorts sort);
        IEspressoMachine AddMilk();
        IEspressoMachine AddMilkFoam();
        IEspressoMachine AddChocolateSyrup();
        IBeverage ToBeverage();
    }
}