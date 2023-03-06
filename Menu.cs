using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        private List<MenuItem> items;

        public Menu()
        {
            items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            items.Remove(item);
        }

        public IEnumerable<MenuItem> Items { get { return items; } }
    }
}
