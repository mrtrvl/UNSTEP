namespace UNSTEP.SchoolAdmin.UnitTests
{
    using System;

    using Core.Models;

    using Xunit;

    public class DateTimeRangeShould
    {
        [Fact]
        public void ThrowArgumentException_WhenInitialized_WithEndDateTimeLessThanStartDateTime()
        {
            Assert.Throws<ArgumentException>(() => new DateTimeRange(DateTime.UtcNow, DateTime.Now.AddHours(-1)));
        }
    }
}
