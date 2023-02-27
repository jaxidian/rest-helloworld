using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestHelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public string CustomGreeting => Configuration["CustomGreeting"];


        public HelloController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // GET: api/<HelloController>
        [HttpGet]
        public string Get()
        {
            return $"{CustomGreeting} Mystery User!";
        }

        // GET api/<HelloController>/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return $"{CustomGreeting} {name}!";
        }
    }
}
