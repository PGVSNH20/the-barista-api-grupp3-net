﻿using System.Collections.Generic;

namespace BaristaApi.Beverages
{
    [Espresso]
    class Americano : IBeverage
    {

        private List<string> ingredients = new List<string>() { "Espresso", "Water" };

        private string cupType = "small cup";

        public List<string> Ingredients => ingredients;

        public string CupType => cupType;

        private int water = 20;

        public int Water => water;

        public override string ToString()
        {
            return "Det här är en Americano";
        }
    }
}
