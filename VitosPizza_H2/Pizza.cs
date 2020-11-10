using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    public class Pizza
    {
        private StringBuilder builder;
        private Queue<Topping> toppings;
        public Queue<Topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        private string pizzaName;

        public string PizzaName
        {
            get { return pizzaName; }
            set { pizzaName = value; }
        }


        public Pizza()
        {
            Toppings = new Queue<Topping>();
        }

        public Pizza(Queue<Topping> toppings, string name) : this()
        {
            Toppings = toppings;
            PizzaName = name;
        }

        public override string ToString()
        {
            builder = new StringBuilder();

            foreach (Topping topping in Toppings)
            {
                builder.Append("Topping: " + topping.ToppingName + "\n");
            }

            return builder.ToString();
        }
    }
}
