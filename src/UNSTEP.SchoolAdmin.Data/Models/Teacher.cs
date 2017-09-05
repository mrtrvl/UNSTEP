﻿using System;
using System.ComponentModel.DataAnnotations;

namespace UNSTEP.SchoolAdmin.Data.Models
{
    public class Teacher : PersistentObject<Guid>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Guid SchoolId { get; set; }

        public School School { get; set; }
    }
}
