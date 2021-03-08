using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    class CustomBeverage : IBeverage
    {
        public List<string> Ingredients { get; set; }

        private string cupType = "Valfri kopp"; 
        
        public string CupType => cupType; 
        public override string ToString()
        {
            return "Det här är en Macchiato";
        }

        public int Water => water;

        private int water = 20;
    }
}
