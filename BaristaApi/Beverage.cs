using System.Collections.Generic;
using System;
using BaristaApi.Beverages;

public interface IBeverage
{
    List<string> Ingredients { get; }
    string CupType { get; }


}
internal interface IFluentEspresso
{
    IFluentEspresso AddWater(int v);
    IFluentEspresso AddBeans(Bean bean);
    IBeverage ToBeverage();
}
[Espresso]
class FluentEspresso : IFluentEspresso
{

    private static List<string> ingredients = new List<string>();
    public static bool containsWater = false;


    public List<string> Ingredients => Ingredients;

    //public static bool AddWater(int water) => containsWater = (water > 0) ? true : false;
    public IFluentEspresso AddWater(int water)
    {
        return this;
    }


    public IFluentEspresso AddBeans(Bean bean)
    {
        if (containsWater && bean.AmountInG == 5)
        {
            ingredients.Add("Espresso");
        }
        return this;

    }


    //Console.WriteLine("Lägger till bönor!");
    public static void Validate() => Console.WriteLine("Rätt temperatur för vattnet");

    public static void GrindBeans()
    {




    }
    //=> Console.WriteLine("Rätt temperatur för vattnet");
    public static void AddMilk() => Console.WriteLine("Lägger till mjölk!");


    private FluentEspresso CompareList(FluentEspresso fluentEspresso)
    {
        
        Console.WriteLine(fluentEspresso + "jämför");
        return fluentEspresso;
    }
    //public FluentEspresso ToBeverage()
    //{
    //    return CompareList(this);

    //    //return this;
    //}

    public IBeverage ToBeverage()
    {
        Espresso espresso = new Espresso("N/A", "N/A");

        // Check if all ingrediens are present for a espesso or a latte
        if (true)
        {
            return espresso;
        }
        else return espresso;
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
class Bean
{
    private int amountIng;
    private string sort;

    public int AmountInG => amountIng;
    public string Sort => sort;


}