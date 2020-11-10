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
            ToppingFactory.Instance.Toppings.Clear();
            ToppingFactory.Instance.AddTomatoSauce();
            ToppingFactory.Instance.AddCheese();
            ToppingFactory.Instance.AddOregano();
            return new Pizza(ToppingFactory.Instance.Toppings, "Margarita");
        }
        /// <summary>
        /// Make a Vesuvio pizza
        /// </summary>
        /// <returns>returns a Vesuvio Pizza</returns>
        public Pizza MakeVesuvio()
        {
            ToppingFactory.Instance.Toppings.Clear();
            ToppingFactory.Instance.AddTomatoSauce();
            ToppingFactory.Instance.AddCheese();
            ToppingFactory.Instance.AddEgg();
            ToppingFactory.Instance.AddBasil();
            return new Pizza(ToppingFactory.Instance.Toppings, "Vesuvio");
        }
        /// <summary>
        /// Make a Anchovy Pizza
        /// </summary>
        /// <returns>returns a Anchovy Pizza</returns>
        public Pizza MakeAnchovyPizza()
        {
            ToppingFactory.Instance.Toppings.Clear();
            ToppingFactory.Instance.AddTomatoSauce();
            ToppingFactory.Instance.AddCheese();
            ToppingFactory.Instance.AddAnchovy();
            ToppingFactory.Instance.AddBasil();
            return new Pizza(ToppingFactory.Instance.Toppings, "Anchovy Pizza");
        }
    }
}
