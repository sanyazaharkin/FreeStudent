using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class OrdersHistory : TableBase
    {
        public Order Order { get; set; }
    }
}
