using api_teste.models;
using Microsoft.AspNetCore.Mvc;

namespace api_teste.Controllers
{

    [Route("veiculo")]
    public class VeiculoController : Controller
    {
        List<Veiculo> listaVeiculo = new List<Veiculo>();
        public VeiculoController()
        {
            var veiculo1 = new Veiculo()
            {
                Marca = "teste",
                Modelo = "estudo 1"
            };
            var veiculo2 = new Veiculo()
            {
                Marca = "teste",
                Modelo = "estudo 2"
            };
            var veiculo3 = new Veiculo()
            {
                Marca = "teste",
                Modelo = "estudo 3"
            };
            listaVeiculo.Add(veiculo1);
            listaVeiculo.Add(veiculo2);
            listaVeiculo.Add(veiculo3);
        }

        [HttpGet]
        public ActionResult Getveiculo()
        {
            return Ok(listaVeiculo);
        }

        [HttpPost]


        public IActionResult Post([FromBody] Veiculo item)
        {
            var veiculo = new Veiculo();
            veiculo.Marca = item.Marca;
            veiculo.Modelo = item.Modelo;
            veiculo.AnoFab = item.AnoFab;
            veiculo.AnoModelo = item.AnoModelo;
            veiculo.Placa = item.Placa;

            listaVeiculo.Add(veiculo);

            return StatusCode(StatusCodes.Status201Created, veiculo);

        }

    }
}
