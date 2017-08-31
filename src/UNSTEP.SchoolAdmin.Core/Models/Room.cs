﻿namespace UNSTEP.SchoolAdmin.Core.Models
{
    using UNSTEP.Common;

    public class Room
    {
        public Room(string name)
        {
            ThrowIf.IsNullOrEmpty(name, nameof(name));

            this.Name = name;
        }

        public string Name { get;  }
    }
}