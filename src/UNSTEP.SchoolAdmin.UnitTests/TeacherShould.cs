using System;
using UNSTEP.SchoolAdmin.Core.Models;
using Xunit;

namespace UNSTEP.SchoolAdmin.UnitTests
{
    public class TeacherShould
    {
        [Fact]
        public void ThrowArgumentNullException_WhenInitialized_WithNullParameters()
        {
            Assert.Throws<ArgumentNullException>(() => new Teacher(null));
        }
    }
}
