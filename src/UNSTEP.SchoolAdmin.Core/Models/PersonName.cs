namespace UNSTEP.SchoolAdmin.Core.Models
{
    using UNSTEP.Common;
    using UNSTEP.SharedKernel;

    public class PersonName : ValueObject<PersonName>
    {
        // TODO: Rules about which values can be used to construct a valid PersonName.. Is "James-" a valid first name? How about #%@@%?
        public PersonName(string firstName, string lastName)
        {
            ThrowIf.IsNullOrEmpty(firstName, nameof(firstName));
            ThrowIf.IsNullOrEmpty(lastName, nameof(lastName));

            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Name => $"{this.FirstName} + {this.LastName}";

        private string LastName { get; }

        private string FirstName { get; }

        protected override bool EqualsCore(PersonName other) =>
            other != null &&
            StringHelper.CompareIgnoreCase(this.FirstName, other.FirstName) &&
            StringHelper.CompareIgnoreCase(this.LastName, other.LastName);

        protected override int GetHashCodeCore() =>
            this.FirstName.GetHashCode() ^
            this.LastName.GetHashCode();
    }
}
