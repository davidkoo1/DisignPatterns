using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Strategies
{
    public class WithUser : IOrder
    {

        public void OrderPlace() 
        {
            Console.WriteLine("\t\t>>Give order for user!<<");
        }

    }
}
