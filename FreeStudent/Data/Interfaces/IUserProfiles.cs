using FreeStudent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Interfaces
{
    public interface IUserProfiles
    {
        public UserProfile GetUserProfileByUserId(string UserId);
        public void Add(UserProfile profile);
    }
}
