using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AG_Notes_Gateway.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesController : ControllerBase
{
    [HttpGet]
    [Route("/hello_world")]
    public ActionResult<String> HelloWorld()
    {
        return "Hello World";
    }
}