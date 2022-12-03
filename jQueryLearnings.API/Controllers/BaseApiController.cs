using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryLearnings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected IActionResult HandleException(Exception ex, string msg)
        {
            IActionResult ret;

            // MYTODO: Publish Exceptions here

            // Create new exception with generic message
            ret = StatusCode(StatusCodes.Status500InternalServerError, new Exception(msg));
            return ret;
        }
    }
}
