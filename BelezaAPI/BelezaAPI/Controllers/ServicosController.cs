using BelezaAPI.Dados;
using Microsoft.AspNetCore.Mvc;

namespace BelezaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicosController : Controller
    {
        private readonly Contexto _contexto;
        public ServicosController(Contexto ctx)
        {
            this._contexto = ctx;
        }

        [HttpPost]

        public ActionResult<Servico> Post(Servico serv)
        {
            _contexto.Servicos.Add(serv);

            if (_contexto.SaveChanges() > 0)
            {
                return Created($"/Servicos/{serv.Id}", serv);
            }

            return BadRequest();
        }
    }
}
