using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class ForumTopic : TableBase
    {
        public Forum Forum { get; set; }
        
    }
}
