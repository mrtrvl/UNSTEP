using System;
using UNSTEP.SchoolAdmin.Core.Models;
using Xunit;

namespace UNSTEP.SchoolAdmin.UnitTests
{
    public class SchoolNameShould
    {
        [Fact]
        public void ThrowArgumentNullException_WhenInitialized_WithNullParameters()
        {
            Assert.Throws<ArgumentNullException>(() => new SchoolName(null, null));
            Assert.Throws<ArgumentNullException>(() => new SchoolName(string.Empty, string.Empty));
        }
    }
}
