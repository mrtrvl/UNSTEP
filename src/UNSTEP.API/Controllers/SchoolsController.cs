using UNSTEP.API.Models;
using UNSTEP.SchoolAdmin.Data.Models;
using UNSTEP.SchoolAdmin.Data.ViewModels;

namespace UNSTEP.API.Controllers
{
    using System;

    using Microsoft.AspNetCore.Mvc;

    using SchoolAdmin.Data;

    // TODO: Authentication & Authorization
    public class SchoolsController : Controller
    {
        public ISchoolRepository SchoolRepository { get; }

        public SchoolsController(ISchoolRepository schoolRepository)
        {
            SchoolRepository = schoolRepository;
        }

        [HttpGet("api/schools")]
        public IActionResult GetSchools()
        {
            return this.Ok(new SchoolViewModel());
        }

        [HttpGet("api/schools/{id}")]
        public IActionResult GetSchool(Guid id)
        {
            return this.Ok(new SchoolViewModel());
        }

        [HttpPost("api/schools", Name = "CreateSchool")]
        public IActionResult CreateSchool([FromBody] SchoolModel school)
        {
            return this.CreatedAtRoute("CreateSchool", new { schoolId = Guid.NewGuid() }, new SchoolViewModel());
        }
    }
}
