using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_teste.Controllers
{
    [Route("/")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {
        [HttpGet()]
        public ActionResult Get()
        {
            return Ok("API Tarefas");
        }
        [HttpGet("hello-world")]
        public ActionResult GetHelloWorld()
        {
            return Ok("hello world");
        }
        [HttpGet("autor")]
        public ActionResult GetAutor()
        {
            return Ok("autor");
        }
    }
}
