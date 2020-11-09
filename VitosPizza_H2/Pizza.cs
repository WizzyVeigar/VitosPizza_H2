using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    public abstract class Pizza
    {
        private Queue<Topping> toppings;

        public Queue<Topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public Pizza()
        {
            Toppings = new Queue<Topping>();
        }

        public Pizza(Queue<Topping> toppings) : this()
        {
            Toppings = toppings;
        }
    }
}
