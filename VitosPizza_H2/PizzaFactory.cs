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
            toppings.Clear();
            toppings.Enqueue(ToppingFactory.Instance.CreateTomatoSauce());
            toppings.Enqueue(ToppingFactory.Instance.CreateCheese());
            toppings.Enqueue(ToppingFactory.Instance.CreateOregano());
            return new Margarita(toppings);
        }
        /// <summary>
        /// Make a Vesuvio pizza
        /// </summary>
        /// <returns>returns a Vesuvio Pizza</returns>
        public Pizza MakeVesuvio()
        {
            toppings.Clear();
            toppings.Enqueue(ToppingFactory.Instance.CreateTomatoSauce());
            toppings.Enqueue(ToppingFactory.Instance.CreateCheese());
            toppings.Enqueue(ToppingFactory.Instance.CreateEgg());
            toppings.Enqueue(ToppingFactory.Instance.CreateBasil());
            return new Vesuvio(toppings);
        }
        /// <summary>
        /// Make a Anchovy Pizza
        /// </summary>
        /// <returns>returns a Anchovy Pizza</returns>
        public Pizza MakeAnchovyPizza()
        {
            toppings.Clear();
            toppings.Enqueue(ToppingFactory.Instance.CreateTomatoSauce());
            toppings.Enqueue(ToppingFactory.Instance.CreateCheese());
            toppings.Enqueue(ToppingFactory.Instance.CreateBasil());
            toppings.Enqueue(ToppingFactory.Instance.CreateAnchovy());
            return new AnchovyPizza(toppings);
        }


    }
}
