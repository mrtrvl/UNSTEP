namespace UNSTEP.API.Controllers
{
    using System;

    using Microsoft.AspNetCore.Mvc;

    using UNSTEP.API.Models;

    // TODO: Authentication & Authorization
    public class TeachersController : Controller
    {
        [HttpGet("api/schools/{schoolId}/teachers")]
        public IActionResult GetTeachersForSchool(Guid schoolId)
        {
            return this.Ok(new TeacherReturn());
        }

        [HttpGet("api/schools/{schoolId}/teachers/{id}")]
        public IActionResult GetTeacherForSchool(Guid schoolId, Guid id)
        {
            return this.Ok(new TeacherReturn());
        }

        [HttpPost("api/schools/{schoolId}/teachers", Name = "CreateTeacherForSchool")]
        public IActionResult CreateTeacherForSchool(Guid schoolId, [FromBody] TeacherCreate teacher)
        {
            return this.CreatedAtRoute("CreateTeacherForSchool", new { schoolId, teacherId = Guid.NewGuid() }, new TeacherReturn());
        }
    }
}
