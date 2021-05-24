﻿using Microsoft.AspNetCore.Identity;
using System;


namespace leave_management.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
