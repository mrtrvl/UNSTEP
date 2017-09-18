using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace UNSTEP.API.Controllers
{
    public class HealthController : Controller
    {
        [HttpGet]
        [Route("api/health", Name = "GetHealth")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult GetHealth()
        {
            return this.Ok();
        }
    }
}