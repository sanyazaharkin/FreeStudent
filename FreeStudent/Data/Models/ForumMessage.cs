using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class ForumMessage : TableBase
    {
        public ForumMessage()
        {

        }

        public ForumMessage(ForumMessage prevMessage)
        {
            PrevForumTopicId = prevMessage.Id;
        }

        public Guid ForimId { get; set; }
        public Forum Forum { get; set; }
        public Guid UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public Guid PrevForumTopicId { get; set; }
        public ForumMessage PrevForumTopic { get; set; }

        public List<ForumMessage> ForumMessages { get; set; }
        public List<File> Files { get; set; }


    }
}
