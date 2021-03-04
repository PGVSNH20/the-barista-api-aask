using BaristaApi;
using System.Collections.Generic;

public interface IBeverage{
	public List<Ingredient> Ingredients { get; }
	string CupType { get; }
}




public class Espresso : IBeverage
{
	public List<Ingredient> Ingredients { get; } = new List<Ingredient> { 
		new Ingredient() {Name = "Water"},
		new Ingredient() {Name = "Beans"}
	};
		
	public string CupType { get; } = "Small";
}

public class Latte : IBeverage
{
	public List<Ingredient> Ingredients { get; } = new List<Ingredient> {
		new Ingredient() {Name = "Water"},
		new Ingredient() {Name = "Beans"},
		new Ingredient() {Name = "Milk"}
	};

	public string CupType { get; } = "Large";
}

public class Cappuccino : IBeverage
{
	public List<Ingredient> Ingredients { get; } = new List<Ingredient> {
		new Ingredient() {Name = "Water"},
		new Ingredient() {Name = "Beans"},
		new Ingredient() {Name = "Milk"},
		new Ingredient() {Name = "Milk Foam"}
	};

	public string CupType { get; } = "Medium";
}

public class Americano : IBeverage
{
	public List<Ingredient> Ingredients { get; } = new List<Ingredient> {
		new Ingredient() {Name = "Water"},
		new Ingredient() {Name = "Beans"}
	};

	public string CupType { get; } = "Medium";
}

public class Mocha : IBeverage
{
	public List<Ingredient> Ingredients { get; } = new List<Ingredient> {
		new Ingredient() {Name = "Water"},
		new Ingredient() {Name = "Beans"},
		new Ingredient() {Name = "Chocolate Syrup"},
		new Ingredient() {Name = "Milk"}
	};

	public string CupType { get; } = "Medium";
}
public class Macchiato : IBeverage
{
	public List<Ingredient> Ingredients { get; } = new List<Ingredient> {
		new Ingredient() {Name = "Water"},
		new Ingredient() {Name = "Beans"},
		new Ingredient() {Name = "Milk Foam"}
	};

	public string CupType { get; } = "Large";
}

public class CustomBeverage : IBeverage
{
	public List<Ingredient> Ingredients { get; } = new List<Ingredient> {

	};

	public string CupType { get; } = "Medium";
}