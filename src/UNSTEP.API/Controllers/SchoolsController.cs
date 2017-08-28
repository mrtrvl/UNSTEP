namespace UNSTEP.API.Controllers
{
    using System;

    using Microsoft.AspNetCore.Mvc;

    using UNSTEP.API.Models;

    // TODO: Authentication & Authorization
    public class SchoolsController : Controller
    {
        [HttpGet("api/schools")]
        public IActionResult GetSchools()
        {
            return this.Ok(new SchoolReturn());
        }

        [HttpGet("api/schools/{id}")]
        public IActionResult GetSchool(Guid id)
        {
            return this.Ok(new SchoolReturn());
        }

        [HttpPost("api/schools", Name = "CreateSchool")]
        public IActionResult CreateSchool([FromBody] SchoolCreate school)
        {
            return this.CreatedAtRoute("CreateSchool", new { schoolId = Guid.NewGuid() }, new SchoolReturn());
        }
    }
}
