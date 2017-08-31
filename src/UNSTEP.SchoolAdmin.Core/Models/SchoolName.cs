namespace UNSTEP.SchoolAdmin.Core.Models
{
    using UNSTEP.Common;
    using UNSTEP.SharedKernel;

    public class SchoolName : ValueObject<SchoolName>
    {
        public SchoolName(string name, string abbreviation)
        {
            ThrowIf.IsNullOrEmpty(name, nameof(name));
            ThrowIf.IsNullOrEmpty(abbreviation, nameof(abbreviation));

            this.Name = name;
            this.Abbreviation = abbreviation;
        }

        public string Abbreviation { get; }

        public string Name { get; }

        protected override bool EqualsCore(SchoolName other) =>
            other != null &&
            StringHelper.CompareIgnoreCase(this.Name, other.Name) &&
            StringHelper.CompareIgnoreCase(this.Abbreviation, other.Abbreviation);

        protected override int GetHashCodeCore() =>
            this.Name.GetHashCode() ^
            this.Abbreviation.GetHashCode();
    }
}
