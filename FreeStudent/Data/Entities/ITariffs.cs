using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Entities
{
    public interface ITariffs
    {
        public IEnumerable<Tariff> All();
        public Tariff GetById(int id);
        public Tariff GetByName(string name);
        public Task Add(Tariff tariff);
        public Task DeleteById(int id);

    }
}
