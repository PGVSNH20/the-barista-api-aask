using System.Collections.Generic;

public interface IBeverage{
	List<string> Ingredients { get; }
	string CupType { get; }
}

enum CoffeSorts
{
	Robusta,
	Arabica, 


}
class Bean
{
	int AmountInG { get; }
	string Sort { get; }
}

class Espresso : IBeverage
{
	public List<string> Ingredients { get; } = new List<string> { "Espresso" };
		
	public string CupType { get; } = "Small";

	public IBeverage ToBeverage()
    {

    }
}

class Latte : IBeverage
{
	public List<string> Ingredients { get; } = new List<string> { "Espresso", "Milk" };

	public string CupType { get; } = "Large";
}

class Cappuccino : IBeverage
{
	public List<string> Ingredients { get; } = new List<string> { "Espresso", "Milk", "Milk foam" };

	public string CupType { get; } = "Medium";
}

class Americano : IBeverage
{
	public List<string> Ingredients { get; } = new List<string> { "Espresso", "Water"};

	public string CupType { get; } = "Medium";
}

class Mocha : IBeverage
{
	public List<string> Ingredients { get; } = new List<string> { "Espresso", "Chocolate syrup", "Milk" };

	public string CupType { get; } = "Medium";
}
class Macchiato : IBeverage
{
	public List<string> Ingredients { get; } = new List<string> { "Espresso", "Milk Foam" };

	public string CupType { get; } = "Large";
}

class CustomBeverage : IBeverage
{
	public List<string> Ingredients => throw new System.NotImplementedException();

	public string CupType => throw new System.NotImplementedException();
}