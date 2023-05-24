using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rps_Business;
using Rps_Models;

namespace Rps_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RockPaperScissorsController : ControllerBase
    {
        private readonly ILogger<RockPaperScissorsController> _logger;

        public RockPaperScissorsController(ILogger<RockPaperScissorsController> logger)
        {
            _logger = logger;
        }

        // we will add another method
        [HttpPost("Register/")]// define what verb this action method requires
        public ActionResult<Person> GetMyInt([FromBody] Person x)// get a json string object from the body and match it to the defined class.
        {

            if (ModelState.IsValid)
            {
                BusinessLayerClassLibrary rpsb = new BusinessLayerClassLibrary();
                // i'll call a method on the business layer that will do the appropriate thing with the Person object.
                // I will return the  unputted person back to the user along with the URI to GET the person entity so it can be used, if the FE wants to use it.
                Person ret = rpsb.Register(x);


                // string ret = String.Concat(x.Fname, " ", x.Lname, "is", x.age, "years old. His email is ", x.Email, ".");
                // string ret1 = $"{x.Fname} {x.Lname} is {x.age} years old. His email is {x.Email}.";

                // // return the URI for this resource, and a copy of the resource.
                // return Created("http://www.mysite.com/path/to/this/resource/on/the/web", ret1);
            }
            // if something failed, return a message detailing the failure.
            return BadRequest(new { message = "There was a problem with the new registration" });
        }
    }
}