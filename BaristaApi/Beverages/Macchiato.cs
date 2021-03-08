using System.Collections.Generic;

namespace BaristaApi.Beverages
{
    [Espresso]
    class Macchiato : IBeverage
    {
        private List<string> ingredients = new List<string>() { "Espresso", "Milk Foam", "Water" };

        private string cupType = "small cup";

        private int water = 20;

        public List<string> Ingredients => ingredients;

        public string CupType => cupType;

        public int Water => water;

        public override string ToString()
        {
            return "Det här är en Macchiato";
        }
    }
}
