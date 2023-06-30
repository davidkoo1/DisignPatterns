using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products
{
    public interface IOrderItem
    {
        string Name { get; set; }

        string Description { get; set; }

        decimal GetPrice();

        string ToString()
        {
            return $"{Name} - {GetPrice()}";
        }
    }
}
