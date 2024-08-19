using api_teste.models;
using Microsoft.AspNetCore.Mvc;

namespace api_teste.Controllers
{
    [Route("tarefa")]
    public class TarefasController : Controller
    {
        List<Tarefa> listaTarefa = new List<Tarefa>();
        public TarefasController()
        {
            var tarefa1 = new Tarefa()
            {
                Id = 1,
                Descricao = "estudo 1"
            };
            var tarefa2 = new Tarefa()
            {
                Id = 2,
                Descricao = "estudo 2"
            };
            var tarefa3 = new Tarefa()
            {
                Id = 3,
                Descricao = "estudo 3"
            };
            listaTarefa.Add(tarefa1);
            listaTarefa.Add(tarefa2);
            listaTarefa.Add(tarefa3);
        }

        [HttpGet]
        public ActionResult Getarefas()
        {
            return Ok(listaTarefa);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var tarefa = listaTarefa.Where(item => item.Id == id).FirstOrDefault();
            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPost]

        public IActionResult Post([FromBody] Tarefa item)
        {
            var tarefa = new Tarefa();
                tarefa.Id = item.Id;
            tarefa.Descricao = item.Descricao;
            tarefa.Feito = item.Feito;

            listaTarefa.Add(tarefa) ;

            return StatusCode(StatusCodes.Status201Created, tarefa);
        }

    }
}
