using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public MenuItemType Type { get; set; }

        public MenuItem(string name, string description, decimal price, MenuItemType type)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Type = type;
        }
    }
}
