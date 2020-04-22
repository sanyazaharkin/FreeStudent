using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string Topic { get; set; }
        [Required]
        public string Description { get; set; }

        public string CustomerId { get; set; }
        public UserProfile Customer { get; set; }
        public string ExecutorId { get; set; }
        public UserProfile Executor { get; set; }
    }
}
