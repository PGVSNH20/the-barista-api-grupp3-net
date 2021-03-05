using System.Collections.Generic;
using System;
using BaristaApi.Beverages;
using System.Linq;

public interface IBeverage
{
    List<string> Ingredients { get; }
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

    private static List<string> ingredients = new List<string>();
    public static bool containsWater = false;


    public List<string> Ingredients => ingredients;

    //public static bool AddWater(int water) => containsWater = (water > 0) ? true : false;
    public IFluentEspresso AddWater(int water)
    {
        return this;
    }

    public IFluentEspresso AddMilk()
    {

        ingredients.Add("Milk");
        return this;
    }

    public IFluentEspresso AddChocolateSyrup()
    {

        ingredients.Add("ChocolateSyrup");
        return this;
    }

    public IFluentEspresso AddMilkFoam()
    {

        ingredients.Add("Milk Foam");
        return this;
    }

    public IFluentEspresso AddBeans()
    {
        //if (containsWater && amount > 4)
        //{
        //    ingredients.Add("Espresso");
        //}
        ingredients.Add("Espresso");
        return this;

    }


    //Console.WriteLine("Lägger till bönor!");
    public static void Validate() => Console.WriteLine("Rätt temperatur för vattnet");

    public static void GrindBeans()
    {




    }
    //=> Console.WriteLine("Rätt temperatur för vattnet");




    public IBeverage ToBeverage()
    {

        Espresso espresso = new Espresso();
        Cappuccino cappuccino = new Cappuccino();
        Americano americano = new Americano();
        Latte latte = new Latte();
        Mocha mocha = new Mocha();
        Macchiato macchiato = new Macchiato();

        List<IBeverage> beverages = new List<IBeverage>() { espresso, cappuccino, americano, latte, mocha, macchiato };

        // Check if all ingrediens are present for a espesso or a latte
        return CheckIngredients(beverages);
    }

    private IBeverage CheckIngredients(List<IBeverage> beverages)
    {
        foreach (var bev in beverages.Where(bev => bev.Ingredients.Count == this.Ingredients.Count))
        {
            foreach (var i in this.Ingredients)
            {
                for (int x = 0; x < bev.Ingredients.Count; x++)
                {
                    if (i == bev.Ingredients[x])
                    {
                        if (x == bev.Ingredients.Count - 1)
                        {
                            Console.WriteLine(bev);
                            return bev;
                        }
                    }

                    else
                    {
                        Console.WriteLine(i);
                        continue;
                    }
                }
            }
        }
        return null;
    }


    /* AddWater(20)
                            .AddBeans(new Bean(){ 
                                AmountInG = 5,
                                Sort = CoffeSorts.Robusta})
    						.Validate(e => e.Temerature > 90)
                        .ToBeverage()*/

}

[AttributeUsage(AttributeTargets.Class)]
class EspressoAttribute : Attribute
{
    public byte Temperature { get; set; }
    //    public List<string> Ingredients;
    //    public string CupType { get; set; }
    //}
}

// Lägg till klassen senare i AddBeans(), försöker få allt att fungera nu
class Bean
{
    private int amountIng;
    private string sort;

    public int AmountInG => amountIng;
    public string Sort => sort;


}