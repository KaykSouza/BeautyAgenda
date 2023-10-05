using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelezaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        public ClientesController(Contexto ctx)
        {


        }
        [HttpPost]
        public ActionResult Post(ClientesController cli)
        {
            return Created($"\Clientes/{cli.Id}", cli);
        }
    }
}
