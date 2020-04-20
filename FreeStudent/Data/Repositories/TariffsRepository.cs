using FreeStudent.Data.Entities;
using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Repositories
{
    public class TariffsRepository : ITariffs
    {
        private AppDbContext _context;
        public TariffsRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<Tariff> AllTariffs() => _context.Tariffs;
    }
}
