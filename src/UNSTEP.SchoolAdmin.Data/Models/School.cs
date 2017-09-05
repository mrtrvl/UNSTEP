using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UNSTEP.SchoolAdmin.Data.Models
{
    public class School : PersistentObject<Guid>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Abbreviation { get; set; }

        public IList<Teacher> Teachers { get; set; }

        public IList<Room> Rooms { get; set; }

        public IList<Subject> Subjects { get; set; }
    }
}
