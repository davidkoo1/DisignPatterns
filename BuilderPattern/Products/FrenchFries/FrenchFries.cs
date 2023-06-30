using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPattern.Products.Doping;

namespace BuilderPattern.Products.FrenchFries
{
    public class FrenchFries : IOrderItem
    {
        private readonly string _name;
        private readonly decimal _price;

        public FrenchFries(decimal prace)
        {
            _name = "French Fries";
            _price = prace;
        }

        public string Name { get { return _name; } set { Name = value; } }

        public string Description { get; set; }

        public List<Doping.Doping> Doppings = new List<Doping.Doping>();

        public decimal GetPrice() => _price + Doppings.Sum(x => x._price);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Название картошки: {Name}\t\t{Description}\t\tЦена: {_price}$");
            stringBuilder.AppendLine("----------------------------------------------------------------");

            if (Doppings.Count > 0)
            {
                stringBuilder.AppendLine("Добавки:");
                var result = from doping in Doppings
                             group doping by doping.Name into g
                             select new { DopingName = g.Key, DopingCount = g.Count(), DopingDescription = g.FirstOrDefault().Description, DopingPrice = g.FirstOrDefault().GetPrice() };
                foreach (var current in result)
                {
                    stringBuilder.AppendLine($"{current.DopingName} {current.DopingDescription} x{current.DopingCount} {current.DopingPrice}$");
                }
                stringBuilder.AppendLine("----------------------------------------------------------------");
                stringBuilder.AppendLine($"\t\tPrice: {Convert.ToString(GetPrice())}$");
            }
            return stringBuilder.ToString();
        }

    }
}
