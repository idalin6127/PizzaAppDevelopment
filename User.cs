using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LING_Pizza
{
    internal class User
    {
        /* Project Name: Pizza App Development */
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string EatingHabbit { get; set; }
        public string Seasoning { get; set; }
        public string PizzaSize { get; set; }
        public string PizzaQuantity { get; set; }

        public User()
        {

        }

        public User(string name, int phoneNumber, string eatingHabbit, string seasoning, string pizzaSize, string pizzaQuantity)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EatingHabbit = eatingHabbit;
            this.Seasoning = seasoning;
            this.PizzaSize = pizzaSize;
            this.PizzaQuantity = pizzaQuantity;
        }

        public override string ToString()
        {
            return $"{this.Name} --- {this.PhoneNumber} --- {this.EatingHabbit}" +
                $" --- {this.Seasoning} --- {this.PizzaSize} --- {this.PizzaQuantity}";
        }
    }
}