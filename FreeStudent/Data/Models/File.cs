using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{


    public class File : TableBase
    {
        public File(Guid userProfileId, byte[] bytes, string name, string format, string contentType)
        {
            UserProfileId = userProfileId;
            this.bytes = bytes;
            Name = name;
            Format = format;
            ContentType = contentType;
            MarkedForDeletion = false;
            DateOfDownload = DateTime.UtcNow;
        }

        public Guid UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        [Required]
        public byte[] bytes { get; set; }
        [Required]
        public string Name { get; set; }
        [Required] 
        public string Format { get; set; }
        [Required] 
        public string ContentType { get; set; }
        public DateTime DateOfDownload { get; set; }
        public DateTime DateOfMarkForDelete { get; set; }

        public bool MarkedForDeletion { get; set; }




    }
}
