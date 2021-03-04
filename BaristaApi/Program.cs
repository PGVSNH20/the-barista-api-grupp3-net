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
            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte 
             */

            IBeverage beverage = new FluentEspresso()
                   .AddWater(20)
                   .AddWater(2)
                   .AddWater(3)
                   .AddBeans()
                   .AddMilk()
                   .ToBeverage();
            Console.ReadKey();



            var beverages = from type in Assembly.GetExecutingAssembly().GetTypes()
                            where type.GetCustomAttributes<EspressoAttribute>().Count() > 0
                            select type;

            foreach (var type in beverages)
            {
                Console.WriteLine(type.Name +  "\t" + type.BaseType);

                PropertyInfo[] propertyInfos = null;
                propertyInfos = type.GetProperties();
                foreach (var prop in propertyInfos)
                {
                    Console.WriteLine("\tProperties: " + prop.Name);
                    //Console.WriteLine("\t\tProperties value: " + prop.GetValue(type, null));

                    var met = type.GetMethods();
                    foreach (var m in met)
                    {
                        Console.WriteLine(m);
                    }
                    
                    if (prop is IEnumerable)
                    {
                        foreach (var listitem in prop as IEnumerable)
                        {
                            Console.WriteLine("Ingredient: " + listitem.ToString());
                        }
                    }

                }


            }

            /*
             Cappuccino
            Americano
            Espresso
            Macchiato
            Mocha
             */

            //var assembly = Assembly.GetExecutingAssembly();
            //var types = assembly.GetTypes();

            //foreach (var type in types)
            //{   

            //    //var props = type.GetProperties();

            //    PropertyInfo[] propertyInfos = null;
            //    propertyInfos = type.GetType().GetProperties();

            //    foreach (var item in propertyInfos)
            //    {
            //        var prop = item.GetValue(type);


            //        if (item.Name == "Ingredients")
            //        {
            //            Console.WriteLine("Type " + type.Name + "\tBaseType: " + type.BaseType);
            //            Console.WriteLine("\tProperty: " + item.Name);

            //            if (prop is IEnumerable)
            //            {
            //                foreach (var listitem in prop as IEnumerable)
            //                {
            //                    Console.WriteLine("Ingredient: " + listitem.ToString());
            //                }
            //            }


            //            //Console.WriteLine(type.GetProperty("Ingredients").GetValue(type, null)); 
            //            //foreach (var ingredient in prop.GetValue())
            //            //{
            //            //    Console.WriteLine(ingredient);
            //            //}
            //        }

            //    }
            //}
            Console.ReadKey();
            //Kommentar hej
            //Hej
        }
    }
}
