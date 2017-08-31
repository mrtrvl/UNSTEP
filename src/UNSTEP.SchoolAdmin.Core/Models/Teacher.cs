namespace UNSTEP.SchoolAdmin.Core.Models
{
    using UNSTEP.Common;

    public class Teacher
    {
        public Teacher(PersonName name)
        {
            ThrowIf.IsNull(name, nameof(name));

            this.Name = name;
        }

        public PersonName Name { get; }
    }
}
