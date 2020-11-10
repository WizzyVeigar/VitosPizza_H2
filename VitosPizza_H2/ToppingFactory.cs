using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    class ToppingFactory
    {

        private Queue<Topping> toppings;

        public Queue<Topping> Toppings
        {
            get { return toppings; }
            private set { toppings = value; }
        }


        private static ToppingFactory instance;
        public static ToppingFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ToppingFactory();
                }
                return instance;
            }
        }


        public void AddTomatoSauce()
        {
            Toppings.Enqueue(new Topping("TomatoSauce", Flavor.Bitter));
        }

        public void AddOregano()
        {
            Toppings.Enqueue(new Topping("Oregano", Flavor.Sour));
        }

        public void AddCheese()
        {
            Toppings.Enqueue(new Topping("Cheese", Flavor.Umami));
        }

        public void AddEgg()
        {
            Toppings.Enqueue(new Topping("Egg", Flavor.Sweet));
        }

        public void AddBasil()
        {
            Toppings.Enqueue(new Topping("Basil", Flavor.Sweet));
        }

        public void AddAnchovy()
        {
            Toppings.Enqueue(new Topping("Anchovy", Flavor.Bitter));
        }
    }
}
