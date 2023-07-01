using BuilderPattern.Products;
using BuilderPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderPattern
{
    public class OrderBuilder : IOrderBuilder
    {

        private IOrder _orderPlace;

        private Order _order; //Отчет который получим

        private readonly IEnumerable<IOrderItem> _orders;//Список заказов, которые получим в конструкторе

        public OrderBuilder(IEnumerable<IOrderItem> orders, IOrder orderPlace)
        {
            _orders = orders;
            _order = new();
            _orderPlace = orderPlace;
        }

        public IOrderBuilder BuildHeader()
        {
            _order.Header = $"ORDER REPORT ON DATE: {DateTime.Now}\n";

            _order.Header += "\n-----------------------------------------------------------------------------------------------------------\n";

            return this;
        }

        public IOrderBuilder BuildBody()
        {
            _order.Body = "\t\t\tORDERS:\n";
            _order.Body += string.Join(Environment.NewLine, _orders.Select(x => $"{x.ToString()}"));

            return this;
        }

        public IOrderBuilder BuildFooter()
        {
            _order.Footer = "\n-----------------------------------------------------------------------------------------------------------\n";
            _order.Footer += $"\nTOTAL PRICE: {_orders.Sum(x => x.GetPrice())}$";

            return this;
        }

        public void SelectPlace()
        {
            Console.WriteLine(">>>");

            if (_orderPlace is null)
            {
                Console.WriteLine($"This order can't have user. Set orderPlace.");
                return;
            }

            Console.WriteLine("Thanks for order in CoffeClub!");

            _orderPlace.OrderPlace();

            Console.WriteLine("Don't forget to pay for the order <з");
        }

        public Order GetOrder()
        {
            Order order = _order;

            _order = new();

            return order;
        }

    }
}
