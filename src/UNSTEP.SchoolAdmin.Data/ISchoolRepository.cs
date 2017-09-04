using System;
using UNSTEP.SchoolAdmin.Data.Models;
using UNSTEP.SchoolAdmin.Data.ViewModels;

namespace UNSTEP.SchoolAdmin.Data
{
    public interface ISchoolRepository : IDisposable
    {
        SchoolViewModel GetSchool(Guid id);

        void Update(School school);
    }
}
