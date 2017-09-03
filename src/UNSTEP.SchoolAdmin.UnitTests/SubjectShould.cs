using System;
using UNSTEP.SchoolAdmin.Core.Models;
using Xunit;

namespace UNSTEP.SchoolAdmin.UnitTests
{
    public class SubjectShould
    {
        [Fact]
        public void ThrowArgumentNullException_WhenInitialized_WithNullParameters()
        {
            Assert.Throws<ArgumentNullException>(() => new Subject(null));
            Assert.Throws<ArgumentNullException>(() => new Subject(string.Empty));
        }
    }
}
