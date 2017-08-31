﻿namespace UNSTEP.SchoolAdmin.Core.Models
{
    using UNSTEP.Common;

    public class School
    {
        public School(SchoolName name)
        {
            ThrowIf.IsNull(name, nameof(name));

            this.Name = name;
        }

        public SchoolName Name { get; }
    }
}
