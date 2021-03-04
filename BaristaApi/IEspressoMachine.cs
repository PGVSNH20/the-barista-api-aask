using System.Collections.Generic;

namespace BaristaApi
{
    internal interface IEspressoMachine
    {
        List<Ingredient>Ingredients { get; }
        IEspressoMachine AddWater(int v);
        IEspressoMachine AddBeans();
        IEspressoMachine AddMilk();
        IEspressoMachine AddMilkFoam();
        IEspressoMachine AddChocolateSyrup();
        IBeverage ToBeverage();
    }
}