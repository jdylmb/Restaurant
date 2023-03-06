using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Restaurant 
    {
        public string? Name { get; private set; }
        public string? Address { get; private set; }
        public string? PhoneNumber { get; private set; }
        public List<MenuItem>? Menu { get; set; }

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }

        public void RemoveMenuItem(MenuItem item)
        {
            Menu.Remove(item);
        }

        public void UpdateRestaurantInfo(string name, string address, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}
