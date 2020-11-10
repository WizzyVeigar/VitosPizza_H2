using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    public enum Flavor
    {
        Sour,
        Sweet,
        Umami,
        Salt,
        Bitter
    }

    public class Topping
    {
        private string toppingName;
        public string ToppingName
        {
            get { return toppingName; }
            set { toppingName = value; }
        }
        private Flavor toppingFlavor;

        public Flavor ToppingFlavor
        {
            get { return toppingFlavor; }
            set { toppingFlavor = value; }
        }

        public Topping(string toppingName, Flavor flavor)
        {
            ToppingName = toppingName;
            ToppingFlavor = flavor;
        }
    }
}
