using System.Collections.Generic;
using System;

public interface IBeverage{
	List<string> Ingredients { get; }
    string CupType { get; }


}
class FluentEspresso
{
    public static void AddWater() => Console.WriteLine("Lägger till vatten!");
    public static void AddBeans() => Console.WriteLine("Lägger till bönor!");
    public static void Validate() => Console.WriteLine("Rätt temperatur för vattnet");

    public static void GrindBeans() => Console.WriteLine("Rätt temperatur för vattnet");
    public static void ToBeverage() => Console.WriteLine("DU en sån här dryck.");




    /* AddWater(20)
                            .AddBeans(new Bean(){ 
                                AmountInG = 5,
                                Sort = CoffeSorts.Robusta})
    						.Validate(e => e.Temerature > 90)
                        .ToBeverage()*/

}

class Espresso : IBeverage
{
    private List<string> ingredients = new List<string>() { "Espresso" };

    private string cupType = "small cup";

    public Espresso(string ingredients, string cupType)
    {

    }
    public List<string> Ingredients => ingredients;



    public string CupType => cupType;
}

class Latte : IBeverage
{
    private List<string> ingredients = new List<string>() { "Espresso", "Milk" };

    public List<string> Ingredients => ingredients;

    private string cupType = "glass";

    public string CupType => cupType;
}

class Bean
{
    private int amountIng;
    private string sort;

    public int AmountInG => amountIng;
    public string Sort => sort;
    

}