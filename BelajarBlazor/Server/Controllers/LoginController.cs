using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelajarBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public LoginController(DataContext  dataContext)
        {
            _dataContext = dataContext; 
        }

        [HttpPost]
        public async Task<ActionResult<User>> Login(User userParam)
        {
            try
            {
                var user = _dataContext.Users.FirstOrDefault(x => x.username == userParam.username
                                       && x.password == userParam.password);
                if (user == null)
                {
                    return NotFound("Sorry, Your username or password not found");
                }
                return Ok(user);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}
