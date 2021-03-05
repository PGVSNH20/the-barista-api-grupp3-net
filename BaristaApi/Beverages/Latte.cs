using System.Collections.Generic;

namespace BaristaApi.Beverages
{
    [Espresso(Temperature = 92)]
    class Latte : IBeverage
    {
        private List<string> ingredients = new List<string>() { "Espresso", "Milk" };

        public List<string> Ingredients => ingredients;

        private string cupType = "glass";

        public string CupType => cupType;
        public override string ToString()
        {
            return "Det här är en Latte";
        }
    }
}
