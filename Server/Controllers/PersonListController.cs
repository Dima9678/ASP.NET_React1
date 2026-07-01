using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonListController : ControllerBase
    {
        [HttpGet]
        public List<Person> Get()
        {
            PersonCreator creator = new PersonCreator();

            return creator.CreateList();
        }
    }
}
