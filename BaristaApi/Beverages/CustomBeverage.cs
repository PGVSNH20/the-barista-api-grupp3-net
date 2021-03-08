using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    class CustomBeverage : IBeverage
    {
        private string cupType = "Valfri kopp"; public List<string> Ingredients { get; set; }
        public string CupType => cupType; public override string ToString()
        {
            return "Det här är en Macchiato";
        }
    }
}
