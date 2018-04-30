using Microsoft.AspNetCore.Mvc;
using Seriado.AcessoADados.ModeloVisao;
using Seriado.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seriado.api.Controllers
{
    [Route("api/[controller]")]
    public class SeriadoController : Controller
    {
        private ISeriadoRN _seriadoRN;

        public SeriadoController(ISeriadoRN seriadoRN)
        {
            this._seriadoRN = seriadoRN;
        }

        [HttpPost]
        public IActionResult Post([FromBody] SeriadoModeloVisao seriadoModelView)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var seriadoRN = _seriadoRN.Inserir(seriadoModelView);
                    return Created("api/Seriado/" + seriadoRN.Id, seriadoRN.Id);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpGet("{idSeriado}")]
        public IActionResult Get(Guid idSeriado)
        {
            try
            {
                return Json(_seriadoRN.Obter(idSeriado));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpPut("{idSeriado}")]
        public IActionResult Put(Guid idSeriado, [FromBody] SeriadoModeloVisao seriadoModelView)
        {
            try
            {
                return Json(_seriadoRN.Obter(idSeriado));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
