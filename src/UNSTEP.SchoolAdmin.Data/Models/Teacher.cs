using System;

namespace UNSTEP.SchoolAdmin.Data.Models
{
    public class Teacher : PersistentObject<Guid>
    {
        // Entity Frameork requires an empty constructor
        protected Teacher()
        {
            
        }
    }
}
