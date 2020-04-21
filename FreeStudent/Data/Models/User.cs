using FreeStudent.Data.Models.Relationships;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Balance { get; set; } = 0;        
        public override string ToString() => Name + " " + SurName;

        public List<OrderExecutorRelation> ExecutorRelations { get; set; }
        public List<OrderCustomerRelation> CustomerRelations { get; set; }

    }
}
