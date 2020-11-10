using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    public abstract class Topping
    {
        private string toppingName;

        public string ToppingName
        {
            get { return toppingName; }
            set { toppingName = value; }
        }
    }
}
