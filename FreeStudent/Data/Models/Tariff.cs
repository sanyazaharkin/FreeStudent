using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class Tariff
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public double Discount { get; set; }
        public int ExecutorPays { get; set; }
        public int CustomerPays { get; set; }        
 


        public override string ToString() => Name;
    }
}
