using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Entites {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem() {
        }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public double SubTotal() {
            return Price * Quantity;
        }

        public override string ToString() {
            return ($"{product.Name}, ${product.Price}, Quantity: {Quantity}, SubTotal: ${SubTotal()}");
        }
    }
}
