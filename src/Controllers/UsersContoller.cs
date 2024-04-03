using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Newtonsoft.Json;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        User user = new User
        {
            Id = "raul",
            Name = "Raul",
            LastName = "Beltran Gomez",
            Email = "rb58853@gmal.com",
            Images = ["path1", "path2"]
        };
        [HttpGet]
        public string Get()
        {
            string jsonUser = JsonConvert.SerializeObject(user);
            return jsonUser;
        }
    }
}