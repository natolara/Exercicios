using System;
using System.Collections.Generic;
using System.Text;

namespace ExrComposicaoEnumeracao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus  Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }
        public Order(DateTime moment,Client client, OrderStatus status)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in items)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

    }
}
