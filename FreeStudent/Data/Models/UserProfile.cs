using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class UserProfile
    {
        [Required]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }


        public string Name { get; set; }
        public string SurName { get; set; }
        public int Balance { get; set; } = 0;
        public override string ToString() => Name + " " + SurName;

        public List<Order> IsExecutorInOrders { get; set; }
        public List<Order> IsCustomerInOrders { get; set; }
    }
}
