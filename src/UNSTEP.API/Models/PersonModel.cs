using System.Collections.Generic;

namespace UNSTEP.API.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<ContactModel> Contacts { get; set; }
    }
}
