using FreeStudent.Data.Interfaces;
using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Repositories
{
    public class UserProfileRepository : IUserProfiles
    {
        AppDbContext _context { get; set; }
        public UserProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        public UserProfile GetUserProfileByUserId(string UserId) => _context.UserProfiles.FirstOrDefault(c => c.UserId == UserId);

        public void Add(UserProfile profile)
        {
            _context.UserProfiles.Add(profile);
            _context.SaveChanges();
        }
    }
}
