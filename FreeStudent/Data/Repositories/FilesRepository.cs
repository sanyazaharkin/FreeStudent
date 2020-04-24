using FreeStudent.Data.Interfaces;
using FreeStudent.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Repositories
{
    public class FilesRepository : IFiles
    {
        AppDbContext _context;
        public FilesRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(File file)
        {
            _context.Files.Add(file);
            _context.SaveChanges();
        }

        public void Del(Guid Id)
        {
            File file = _context.Files.FirstOrDefault(c => c.Id == Id);
            file.MarkedForDeletion = true;
            file.DateOfMarkForDelete = DateTime.UtcNow;
            _context.Files.Update(file);
            _context.SaveChanges();
        }   
        public void Restore(Guid Id)
        {
            File file = _context.Files.FirstOrDefault(c => c.Id == Id);
            file.MarkedForDeletion = false;
            _context.Files.Update(file);
            _context.SaveChanges();
        }

        public IEnumerable<File> GetAllFiles() => _context.Files;
        public File GetFileById(string Id) => _context.Files.FirstOrDefault(c => c.Id.ToString() == Id);

        public IEnumerable<File> GetFilesBuAuthor(string ProfileID) => _context.Files.Include(c => c.UserProfileId.ToString() == ProfileID);

        public void Update(File file)
        {
            throw new NotImplementedException();
        }
    }
}
