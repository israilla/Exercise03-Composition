using System;
using System.Collections.Generic;
using Exercise_03.Entities.Enums;
using System.Text;
using System.Globalization;

namespace Exercise_03.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; }  = new List <OrderItem>();
        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItem (OrderItem items)
        {
            Items.Add(items);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString());
            return sb.ToString();
        }
    }
}
