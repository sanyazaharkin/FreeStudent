using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class Specialization : TableBase
    {
        public List<UserProfile> UserProfiles { get; set; }
    }
}
