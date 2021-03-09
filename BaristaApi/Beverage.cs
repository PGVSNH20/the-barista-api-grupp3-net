using System.Collections.Generic;
using System;
using BaristaApi.Beverages;
using System.Linq;

public interface IBeverage
{
    List<string> Ingredients { get; }
    int Water { get; }
    string CupType { get; }


}
internal interface IFluentEspresso
{
    IFluentEspresso AddWater(int v);
    IFluentEspresso AddBeans();
    IFluentEspresso AddMilk();
    IFluentEspresso AddChocolateSyrup();
    IFluentEspresso AddMilkFoam();
    IBeverage ToBeverage();
}

[Espresso]
internal class FluentEspresso : IFluentEspresso
{
    public static List<IBeverage> avaibleBeverages = new List<IBeverage>()
    {
        new Espresso(),
        new Cappuccino(),
        new Americano(),
        new Latte(),
        new Mocha(),
        new Macchiato()
    };

    private static List<string> ingredients = new List<string>();
    private static int water = new int();

    public List<string> Ingredients => ingredients;
    public int Water = water;

    public IFluentEspresso AddWater(int v)
    {
        if (!ingredients.Contains("Water"))
        {
            ingredients.Add("Water");
        }      
        water = (this.Water +=v);
        
        return this;
    }

    public IFluentEspresso AddMilk()
    {

        ingredients.Add("Milk");
        return this;
    }

    public IFluentEspresso AddChocolateSyrup()
    {

        ingredients.Add("Chocolate Syrup");
        return this;
    }

    public IFluentEspresso AddMilkFoam()
    {

        ingredients.Add("Milk Foam");
        return this;
    }


    public IFluentEspresso AddBeans()
    {
        if (this.Ingredients.Contains("Water")){

            ingredients.Add("Espresso");
            ingredients.Remove("Water");
            return this;
        }
        else
        {
            return this;
        }
    }

    public IBeverage ToBeverage()
    {
        IBeverage beverageToServe;
        beverageToServe = new CustomBeverage { Ingredients = this.Ingredients };
        bool IsComparableList = false;
        var avaibleBevs = avaibleBeverages.Where(bev => this.Ingredients.Count.Equals(bev.Ingredients.Count)).ToList();
        foreach (var bevToCheck in avaibleBevs)
        {
            // The beverage to be served contains only ingredients from the the avaible beverage types in this class
            IsComparableList = this.Ingredients.All(ingredient => bevToCheck.Ingredients.Contains(ingredient));
            if (IsComparableList == true)
                beverageToServe = bevToCheck;
        }
        BeverageDeclaration(beverageToServe);
        return beverageToServe;

    }
    private void BeverageDeclaration(IBeverage beverage)
    {
        Console.WriteLine($"Du fick en {beverage.GetType().Name} serverad i en {beverage.CupType}!");
        Console.WriteLine("Dryckens innehåll: ");
        beverage.Ingredients.ForEach(ing => Console.WriteLine("\t" + ing));

        this.Ingredients.Clear();
    }
}

[AttributeUsage(AttributeTargets.Class)]
class EspressoAttribute : Attribute
{
    public byte Temperature { get; set; }

}