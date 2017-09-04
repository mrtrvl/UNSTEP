using UNSTEP.API.Models;
using UNSTEP.SchoolAdmin.Data.Models;
using UNSTEP.SchoolAdmin.Data.ViewModels;

namespace UNSTEP.API.Controllers
{
    using System;

    using Microsoft.AspNetCore.Mvc;

    using SchoolAdmin.Data;

    // TODO: Authentication & Authorization
    public class TeachersController : Controller
    {
        public ISchoolRepository SchoolRepository { get; }

        public TeachersController(ISchoolRepository schoolRepository)
        {
            SchoolRepository = schoolRepository;
        }

        [HttpGet("api/schools/{schoolId}/teachers")]
        public IActionResult GetTeachersForSchool(Guid schoolId)
        {
            return this.Ok(new TeacherViewModel());
        }

        [HttpGet("api/schools/{schoolId}/teachers/{id}")]
        public IActionResult GetTeacherForSchool(Guid schoolId, Guid id)
        {
            return this.Ok(new TeacherViewModel());
        }

        [HttpPost("api/schools/{schoolId}/teachers", Name = "CreateTeacherForSchool")]
        public IActionResult CreateTeacherForSchool(Guid schoolId, [FromBody] TeacherModel teacher)
        {
            return this.CreatedAtRoute("CreateTeacherForSchool", new { schoolId, teacherId = Guid.NewGuid() }, new TeacherViewModel());
        }
    }
}
