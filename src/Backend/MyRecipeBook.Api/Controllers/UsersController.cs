using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterUserAccountJson request)
    {

        var temporario = new RequestRegisterUserAccountJson
        {
          
        };
        
        //Registro a conta de uma pessoa
        return Created();
    }
}
