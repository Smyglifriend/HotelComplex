using Auth.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers;

[ApiController]
[Route("api/accommodations")]
public class AuthenticationController: ControllerBase
{


    public AuthenticationController()
    {
        
    }

    public async Task<ActionResult<bool>> Registration([FromBody] RegistrationVm model)
        => Ok();
}