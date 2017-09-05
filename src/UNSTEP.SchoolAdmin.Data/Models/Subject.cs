using System;
using System.ComponentModel.DataAnnotations;

namespace UNSTEP.SchoolAdmin.Data.Models
{
    public class Subject : PersistentObject<Guid>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid SchoolId { get; set; }

        public School School { get; set; }
    }
}
