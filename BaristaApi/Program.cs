using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage espresso = new FluentEspresso()
                   .AddWater(20)
                   .AddBeans()
                   .ToBeverage();
            Console.WriteLine();

            IBeverage americano = new FluentEspresso()
                   .AddWater(20)
                   .AddWater(2)
                   .AddBeans()
                   .AddWater(2)
                   .ToBeverage();
            Console.WriteLine();

            IBeverage latte = new FluentEspresso()
                   .AddWater(20)
                   .AddBeans()
                   .AddMilk()
                   .ToBeverage();
            Console.ReadKey();
        }
    }
}
