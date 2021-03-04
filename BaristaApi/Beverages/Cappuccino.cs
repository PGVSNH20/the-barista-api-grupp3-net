using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    [Espresso]
    class Cappuccino : IBeverage
    {
        private List<string> ingredients = new List<string>() { "Espresso", "Milk" };

        private string cupType = "small cup";

        public List<string> Ingredients => ingredients;


        public string CupType => cupType;
    }
}
