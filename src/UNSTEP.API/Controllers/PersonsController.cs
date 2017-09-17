using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using UNSTEP.API.Models;

namespace UNSTEP.API.Controllers
{
    public class PersonsController : Controller
    {
        [HttpGet]
        [Route("api/persons", Name = "GetPersons")]
        [ProducesResponseType(typeof(List<PersonViewModel>), (int)HttpStatusCode.OK)]
        public IActionResult GetPersons()
        {
            return Ok();
        }

        [HttpGet]
        [Route("api/persons/{id}", Name = "GetPerson")]
        [ProducesResponseType(typeof(PersonViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult GetPerson(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            // TODO: Get from database and convert to list of PersonViewModel

            return Ok();
        }

        [HttpPost]
        [Route("api/persons", Name = "CreatePerson")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult CreatePerson([FromBody] PersonModel person)
        {
            // TODO: Implement correct input validation
            if (person == null)
                return BadRequest();


            // TODO: Get from database and convert to PersonViewModel
            var viewModel = new PersonViewModel
            {
                Id = Guid.NewGuid(),
                Name = $"{person.FirstName} {person.LastName}",
                Contacts = person.Contacts
            };

            return CreatedAtRoute("GetPerson", new { id = viewModel.Id }, viewModel);
        }

        [HttpPatch]
        [Route("api/persons/{id}", Name = "PatchPerson")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult PatchPerson(Guid id, [FromBody] JsonPatchDocument<PersonModel> patchDoc)
        {
            if (id == Guid.Empty || patchDoc == null)
                return BadRequest();

            return NoContent();
        }

        [HttpDelete]
        [Route("api/persons/{id}", Name = "DeletePerson")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult DeletePerson(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            return NoContent();
        }

    }
}
