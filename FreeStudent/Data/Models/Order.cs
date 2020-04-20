using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class Order
    {
        [Key] public Guid Id { get; set; }   
        public string Name { get; set; }
        public Guid CustomerId { get; set; }
        public User Customer { get; set; }
        public Guid ExecutorId { get; set; }
        public User Executor { get; set; }
        public int TariffId { get; set; }
        public Tariff Tariff { get; set; }

    }
}
