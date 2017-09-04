using System.ComponentModel.DataAnnotations;

namespace UNSTEP.SchoolAdmin.Data
{
    public abstract class PersistentObject<TId>
    {
        [Key]
        public TId Id { get; protected set; }

        // Entity Frameork requires an empty constructor
        protected PersistentObject()
        {
            
        }
    }
}
