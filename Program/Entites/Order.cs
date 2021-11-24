using Program.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Entites {
    class Order {
        // momento da compra
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();
        public Client client { get; set; }

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            this.moment = moment;
            this.status = status;
            this.client = client;
        }

        public void AddItem(OrderItem item) {
            items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            items.Remove(item);
        }

        public double Total() {

            double sum = 0;
            foreach (OrderItem item in items) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + moment);
            sb.AppendLine("Order status: " + status);
            sb.AppendLine(client.ToString());
            sb.AppendLine("\nOrder items: ");
            foreach (OrderItem item in items) {
                sb.AppendLine($"{item.product.Name}, ${item.product.Price}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal()}");
            }
            sb.Append("Total price: $" + Total());
            return sb.ToString();
        }
    }
}
