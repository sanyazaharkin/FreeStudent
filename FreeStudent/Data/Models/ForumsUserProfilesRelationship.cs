using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class ForumsUserProfilesRelationship
    {
        public Guid UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public Guid ForumId { get; set; }
        public Forum Forum { get; set; }
    }
}
