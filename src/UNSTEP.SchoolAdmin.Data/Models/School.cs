using System;

namespace UNSTEP.SchoolAdmin.Data.Models
{
    public class School : PersistentObject<Guid>
    {
        // Entity Frameork requires an empty constructor
        protected School()
        {
            
        }
    }
}
