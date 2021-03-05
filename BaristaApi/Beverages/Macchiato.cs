using System.Collections.Generic;

namespace BaristaApi.Beverages
{
    [Espresso]
    class Macchiato : IBeverage
    {
        private List<string> ingredients = new List<string>() { "Espresso", "Milk Foam" };

        private string cupType = "small cup";

        public List<string> Ingredients => ingredients;

        public string CupType => cupType;

        public override string ToString()
        {
            return "Det här är en Macchiato";
        }
    }
}
