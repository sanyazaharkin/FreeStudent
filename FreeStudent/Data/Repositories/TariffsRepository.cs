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

        public async Task Add(Tariff tariff)
        {
            _context.Tariffs.Add(tariff);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Tariff> All() => _context.Tariffs;

        public async Task DeleteById(int id)
        {
            _context.Tariffs.Remove(GetById(id));
            await _context.SaveChangesAsync();
        }

        public Tariff GetById(int id)
        {
            return _context.Tariffs.FirstOrDefault(c => c.Id == id);
        }

        public Tariff GetByName(string name)
        {
            return _context.Tariffs.FirstOrDefault(c => c.Name == name);
        }
    }
}
