using _06_SingletonWithDependencyInjection.Db;
using Microsoft.AspNetCore.Mvc;

namespace _06_SingletonWithDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IAppDatabase appDatabase;

        public ValuesController(IAppDatabase appDatabase)
        {
            this.appDatabase = appDatabase;
        }

        [HttpGet]
        public IActionResult Get()
        {
             
            return Ok("ok");
        }

    }
}
