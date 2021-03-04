using System.Collections.Generic;
using System;

public interface IBeverage
{
    List<string> Ingredients { get; }
    string CupType { get; }


}
class FluentEspresso
{

    private static List<string> ingredients = new List<string>();
    public static bool containsWater = false;


    public List<string> Ingredients => Ingredients;




    public static bool AddWater(byte water) => containsWater = (water > 0) ? true : false;


    public static void AddBeans(Bean bean)
    {
        if (containsWater && bean.AmountInG == 5)
        {
            ingredients.Add("Espresso");
        }
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
    public FluentEspresso ToBeverage()
    {
        return CompareList(this);

        //return this;
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