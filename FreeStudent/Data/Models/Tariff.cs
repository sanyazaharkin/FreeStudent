using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class Tariff
    {
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
        public string Name { get; set; }
    }
}
