using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class UserProfile
    {
        enum Genders { Woman ,Man };
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public List<Order> ExecutorOnOrders { get; set; }
        public List<Order> CustomerOnOrders { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        Genders Gender { get; set; }
        public bool Anonymous { get; set; }
        public byte[] Avatar { get; set; }
        public DateTimeOffset TimeZone { get; set; }
        public DateTime LastTimeOnline { get; set; }      
        
        public Specialization Specialization { get; set; }
        public List<ForumsUserProfilesRelationship> Forums { get; set; }
        public List<Chat> Chats { get; set; }
        public List<OrdersHistory> OrdersHistories { get; set; }
        public List<RatingAndReviewsHistory> RatingAndReviews { get; set; }
        public List<ForumMessage> ForumTopics { get; set; }

        public int Balance { get; set; } = 0;
        public override string ToString() => Name + " " + SurName;
    }
}
