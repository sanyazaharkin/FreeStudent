using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Entities
{
    public interface ITariffs
    {
        public IQueryable<Tariff> AllTariffs(); 
    }
}
