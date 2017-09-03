namespace UNSTEP.SchoolAdmin.Core.Models
{
    using System;

    using Common;
    using SharedKernel;

    public class DateTimeRange : ValueObject<DateTimeRange>
    {
        public DateTimeRange(DateTime start, DateTime end)
        {
            ThrowIf.IsBefore(end, start, nameof(end));

            this.Start = start;
            this.End = end;
        }

        public DateTime Start { get; }

        public DateTime End { get; }

        protected override bool EqualsCore(DateTimeRange other) =>
            other != null && this.Start == other.Start && this.End == other.End;

        protected override int GetHashCodeCore() => 
            this.Start.GetHashCode() ^ this.End.GetHashCode();
    }
}
