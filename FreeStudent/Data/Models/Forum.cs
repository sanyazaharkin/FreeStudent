using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class Forum : TableBase
    {

        public Order Order { get; set; }
        public List<ForumsUserProfilesRelationship> Users  { get; set; }
        public List<ForumMessage> Messages { get; set; }
        public List<File> Files { get; set; }

    }
}
