using System;
using System.Collections.Generic;

namespace UNSTEP.API.Models
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<ContactModel> Contacts { get; set; }
    }
}
