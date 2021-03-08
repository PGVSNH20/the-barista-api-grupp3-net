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
        Macchiato macchiato = new Macchiato(); List<IBeverage> beverages = new List<IBeverage>() { espresso, cappuccino, americano, latte, mocha, macchiato }; 
        
        bool IsComparableList = false;        
        // Check if all ingrediens are present for a espesso or a latte

        foreach (var beverage in beverages.Where(bev => this.Ingredients.Count.Equals(bev.Ingredients.Count)))
        {
            IsComparableList = this.Ingredients.All(ingredient => beverage.Ingredients.Contains(ingredient));
            Console.WriteLine($"Den nya dryckan innehåller bara ingredienser som finns i {beverage.GetType().Name}s ingredienslista: " + IsComparableList); if (IsComparableList)
            {
                Console.WriteLine("Du fick en " + beverage.GetType().Name); Console.WriteLine("Dryckens innehåll:"); 
                beverage.Ingredients.ForEach(ing => Console.WriteLine("\t" + ing));
                this.Ingredients.Clear();
                return beverage;
            }
        }
        CustomBeverage custom = new CustomBeverage { Ingredients = this.Ingredients }; Console.WriteLine("Drycken blev en " + custom.GetType().Name);
        this.Ingredients.Clear();       
        return custom;
    }

    //Kommentar
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
                        Console.WriteLine(i + " Är vi här ?");
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