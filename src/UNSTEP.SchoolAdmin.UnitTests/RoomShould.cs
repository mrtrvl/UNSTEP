using System;
using UNSTEP.SchoolAdmin.Core.Models;
using Xunit;

namespace UNSTEP.SchoolAdmin.UnitTests
{
    public class RoomShould
    {
        [Fact]
        public void ThrowArgumentNullException_WhenInitialized_WithNullParameters()
        {
            Assert.Throws<ArgumentNullException>(() => new Room(null));
            Assert.Throws<ArgumentNullException>(() => new Room(string.Empty));
        }
    }
}
