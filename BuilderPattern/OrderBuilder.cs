using BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class OrderBuilder : IOrderBuilder
    {
        private Order _order; //Отчет который получим

        private readonly IEnumerable<IOrderItem> _orders;//Список заказов, которые получим в конструкторе

        public OrderBuilder(IEnumerable<IOrderItem> orders)
        {
            _orders = orders;
            _order = new();
        }

        public IOrderBuilder BuildHeader()
        {
            _order.Header = $"ORDER REPORT ON DATE: {DateTime.Now}\n";

            _order.Header += "\n-----------------------------------------------------------------------------------------------------------\n";

            return this;
        }

        public IOrderBuilder BuildBody()
        {
            _order.Body = "Orders: \n";
            _order.Body += string.Join(Environment.NewLine, _orders.Select(x => $"{x.ToString()}"));

            return this;
        }

        public IOrderBuilder BuildFooter()
        {
            _order.Footer = "\n-----------------------------------------------------------------------------------------------------------\n";
            _order.Footer += $"\nTOTAL PRICE: {_orders.Sum(x => x.GetPrice())}$";

            return this;
        }

        public Order GetOrder()
        {
            Order order = _order;

            _order = new();

            return order;
        }

    }
}
