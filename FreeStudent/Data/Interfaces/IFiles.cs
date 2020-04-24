using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Interfaces
{
    public interface IFiles
    {
        
        public void Add(File file);
        public File GetFileById(string Id);
        public IEnumerable<File> GetFilesBuAuthor(string ProfileID);
        public IEnumerable<File> GetAllFiles();
        public void Del(Guid Id);
        public void Restore(Guid Id);
        public void Update(File file);

    }
}
