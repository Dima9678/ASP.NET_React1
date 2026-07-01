using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public Person Get()
        {
            PersonCreator creator = new PersonCreator();

            return creator.CreatePerson();
        }
    }
}