using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    [Espresso(Temperature = 92)]
    class Latte : IBeverage
    {
        private List<string> ingredients = new List<string>() { "Espresso", "Milk" };

        public List<string> Ingredients => ingredients;

        private string cupType = "glass";

        public string CupType => cupType;
    }
}
