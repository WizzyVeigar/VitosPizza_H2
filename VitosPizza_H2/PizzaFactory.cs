using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    class PizzaFactory
    {
        Queue<Topping> toppings = new Queue<Topping>();
        
        private static PizzaFactory instance;
        public static PizzaFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PizzaFactory();
                }
                return instance;
            }
        }

        /// <summary>
        /// Make a Margarita pizza
        /// </summary>
        /// <returns>returns a Margarita pizza</returns>
        public Pizza MakeMargarita()
        {
            Pizza pizza = new Pizza();
            pizza.PizzaName = "Margarita";
            toppings.Clear();
            toppings.Enqueue(ToppingFactory.Instance.CreateTomatoSauce());
            toppings.Enqueue(ToppingFactory.Instance.CreateCheese());
            toppings.Enqueue(ToppingFactory.Instance.CreateOregano());
            pizza.Toppings = toppings;
            return pizza;
        }
        /// <summary>
        /// Make a Vesuvio pizza
        /// </summary>
        /// <returns>returns a Vesuvio Pizza</returns>
        public Pizza MakeVesuvio()
        {
            Pizza pizza = new Pizza();
            pizza.PizzaName = "Vesuvio";
            toppings.Clear();
            toppings.Enqueue(ToppingFactory.Instance.CreateTomatoSauce());
            toppings.Enqueue(ToppingFactory.Instance.CreateCheese());
            toppings.Enqueue(ToppingFactory.Instance.CreateEgg());
            toppings.Enqueue(ToppingFactory.Instance.CreateBasil());
            pizza.Toppings = toppings;
            return pizza;
        }
        /// <summary>
        /// Make a Anchovy Pizza
        /// </summary>
        /// <returns>returns a Anchovy Pizza</returns>
        public Pizza MakeAnchovyPizza()
        {
            Pizza pizza = new Pizza();
            pizza.PizzaName = "Anchovy Pizza";
            toppings.Clear();
            toppings.Enqueue(ToppingFactory.Instance.CreateTomatoSauce());
            toppings.Enqueue(ToppingFactory.Instance.CreateCheese());
            toppings.Enqueue(ToppingFactory.Instance.CreateBasil());
            toppings.Enqueue(ToppingFactory.Instance.CreateAnchovy());
            pizza.Toppings = toppings;
            return pizza;
        }


    }
}
