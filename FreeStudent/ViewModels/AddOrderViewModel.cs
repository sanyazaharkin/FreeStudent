using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.ViewModels
{
    public class AddOrderViewModel
    {

        public string Name { get; set; }
        public Guid CustomerId { get; set; }        
        public Guid ExecutorId { get; set; }        
        public int TariffId { get; set; }        

    }
}
