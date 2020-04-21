using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeStudent.Data.Models.Relationships;

namespace FreeStudent.Data.Models
{
    public class Order
    {
        public Order(string topic, string description)
        {
            Topic = topic;
            Description = description;
        }

        public int Id { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public OrderCustomerRelation OrderCustomer { get; set; }
        public OrderExecutorRelation OrderExecutor { get; set; }
    }
}
