using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models.Relationships
{
    public class OrderExecutorRelation
    {
        public OrderExecutorRelation()
        {

        }
        public OrderExecutorRelation(Order order, User user)
        {
            Order = order;
            User = user;
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
