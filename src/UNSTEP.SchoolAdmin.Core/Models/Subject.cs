namespace UNSTEP.SchoolAdmin.Core.Models
{
    using Common;

    public class Subject
    {
        public Subject(string name)
        {
            ThrowIf.IsNullOrEmpty(name, nameof(name));

            this.Name = name;
        }

        public string Name { get; }
    }
}
