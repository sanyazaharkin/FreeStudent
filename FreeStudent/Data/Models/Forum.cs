using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class Forum : TableBase
    {
        public Order Order { get; set; }
        public List<UserProfile> UserProfiles { get; set; }
        public List<ForumTopic> Topics { get; set; }
    }
}
