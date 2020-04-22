using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public Guid ExecutorId { get; set; } 
        public Guid CustomerId { get; set; } 
        public UserProfile Customer { get; set; }
        public UserProfile Executor { get; set; }
    }
}
