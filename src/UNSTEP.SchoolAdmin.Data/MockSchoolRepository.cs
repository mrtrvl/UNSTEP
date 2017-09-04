using System;
using UNSTEP.SchoolAdmin.Data.Models;
using UNSTEP.SchoolAdmin.Data.ViewModels;

namespace UNSTEP.SchoolAdmin.Data
{
    public class MockSchoolRepository : ISchoolRepository
    {
        public SchoolViewModel GetSchool(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(School school)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
        }
    }
}