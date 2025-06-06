//============================================================================
// Copyright (c) Coalition of the Good-Hearted Engineers
// Free to Use and Distribute
//============================================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => Ok("Assalom alaykum");

    }
}
