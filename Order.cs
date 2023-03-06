using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Order
    {
        private List<MenuItem> items;

        public Order()
        {
            this.items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            items.Remove(item);
        }

        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }
            return total;
        }

        public IEnumerable<MenuItem> Items { get { return items; } }
    }
}
