using System;
using Microsoft.AspNetCore.Mvc;

namespace UNSTEP.API.Controllers
{
    public class HealthController : Controller
    {
        [HttpGet("api/health")]
        public IActionResult GetHealth()
        {
            return this.Ok();
        }
    }
}