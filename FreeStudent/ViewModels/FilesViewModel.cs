using FreeStudent.Data.Interfaces;
using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.ViewModels
{
    public class FilesViewModel
    {
        public IEnumerable<File> Files { get; set; }
        public List<UserProfile> UserProfiles { get; set; }
    }
}
