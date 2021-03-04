using System.Collections.Generic;
using System;

public interface IBeverage
{
    List<string> Ingredients { get; }
    string CupType { get; }


}
class FluentEspresso
{

    private List<string> ingredients = new List<string>();

   
    public List<string> Ingredients => Ingredients;


    public static bool containsWater = false;

    
    public static void AddWater(byte water) => containsWater = (water > 0) ? true : false;


    public static void AddBeans() => Console.WriteLine("Lägger till bönor!");
    public static void Validate() => Console.WriteLine("Rätt temperatur för vattnet");

    public static void GrindBeans() => Console.WriteLine("Rätt temperatur för vattnet");
    public static void AddMilk() => Console.WriteLine("Lägger till mjölk!");
    public static void ToBeverage() => Console.WriteLine("DU en sån här dryck.");




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