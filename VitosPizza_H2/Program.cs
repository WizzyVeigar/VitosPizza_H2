using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitosPizza_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = PizzaFactory.Instance.MakeMargarita();
            Pizza pizza2 = PizzaFactory.Instance.MakeAnchovyPizza();
            Pizza pizza3 = PizzaFactory.Instance.MakeVesuvio();
            Console.WriteLine(pizza.ToString());
            Console.WriteLine(pizza2.ToString());
            Console.WriteLine(pizza3.ToString());
            Console.ReadKey();
        }
    }
}
