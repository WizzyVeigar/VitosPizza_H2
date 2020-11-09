using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    class ToppingFactory
    {
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


        public Topping CreateTomatoSauce()
        {
            return new TomatoSauce();
        }

        public Topping CreateOregano()
        {
            return new Oregano();
        }

        public Topping CreateCheese()
        {
            return new Cheese();
        }

        public Topping CreateEgg()
        {
            return new Egg();
        }

        public Topping CreateBasil()
        {
            return new Basil();
        }

        internal Topping CreateAnchovy()
        {
            return new Anchovy();
        }
    }
}
