using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{

    public enum FileType { Doc, Arj, TXT, Img}
    public class File : TableBase
    {
        public Guid UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public byte[] bytes { get; set; }
        public string Name { get; set; }
        public FileType FileType { get; set; }
 
    
    
    
    }
}
