using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Products.Drink
{
    public class Drink : IOrderItem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        internal decimal _price { get; set; }  

        public decimal GetPrice() => _price;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Name);
            stringBuilder.AppendLine(Description);
            stringBuilder.AppendLine($"\t\tPrice: {Convert.ToString(GetPrice())}$");

            return stringBuilder.ToString();    

        }
    }
}
