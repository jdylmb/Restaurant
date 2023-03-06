using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Table
    {
        public int Number { get; set; }
        private List<Order> orders;

        public Table(int number)
        {
            this.Number = number;
            this.orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            orders.Remove(order);
        }

        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var order in orders)
            {
                total += order.TotalPrice();
            }
            return total;
        }
    }
}
