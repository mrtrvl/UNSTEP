using System;
using UNSTEP.SchoolAdmin.Core.Models;
using Xunit;

namespace UNSTEP.SchoolAdmin.UnitTests
{
    public class PersonNameShould
    {
        [Fact]
        public void ThrowArgumentNullException_WhenInitialized_WithNullParameters()
        {
            Assert.Throws<ArgumentNullException>(() => new PersonName(null, null));
            Assert.Throws<ArgumentNullException>(() => new PersonName(string.Empty, string.Empty));
        }
    }
}
