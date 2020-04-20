using FreeStudent.Data.Entities;
using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Repositories
{
    public class OrdersRepository : IOrders
    {
        private AppDbContext _context { get; set; }
        public OrdersRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddOrder(Order order)
        {
            _context.Add(order);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Order> AllOrders() => _context.Orders;

        public Order GetOrder(Guid id) => _context.Orders.FirstOrDefault(c=> c.Id == id);
    }
}
