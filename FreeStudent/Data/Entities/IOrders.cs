using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Entities
{
    public interface IOrders
    {
        public IQueryable<Order> AllOrders();
        public Order GetOrder(Guid id);
        public Task AddOrder(Order order);
    }
    
}
