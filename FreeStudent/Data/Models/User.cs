﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data.Models
{
    public class User : IdentityUser
    {
        public UserProfile Profile { get; set; }


        

    }
}
