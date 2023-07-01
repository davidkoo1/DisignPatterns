using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Strategies
{
    public class InCoffeClub : IOrder
    {
        void IOrder.OrderPlace()
        {
            Console.WriteLine("\t\t>>Sit down and wait for your order!<<");
        }
    }
}
