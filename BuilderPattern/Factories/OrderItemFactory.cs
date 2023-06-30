using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Products;

namespace BuilderPattern.Factories
{
    public abstract class OrderItemFactory
    {
        public abstract IOrderItem GetOrder();

    }
}
