using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    [Espresso]
    public class Espresso : IBeverage
    {

        private List<string> ingredients = new List<string>() { "Espresso" };

        private string cupType = "small cup";

        public Espresso(string ingredients, string cupType)
        {

        }
        public List<string> Ingredients => Ingredients;



        public string CupType => cupType;
    }
}
