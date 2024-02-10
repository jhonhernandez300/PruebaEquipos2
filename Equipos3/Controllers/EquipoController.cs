using Equipos3.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Equipos3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly ApplicationDbContext _context; 

        public EquipoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Equipo/mes/año
        [HttpGet("EquiposPorMes/{mes}")]        
        public ActionResult<IEnumerable<Equipo>> EquiposPorMes(int mes)
        {
            if (mes == 0)
            {
                return BadRequest("Data vacío");
            }
            else
            {
                try
                {
                    var equipos = _context.Equipos                        
                        .Where(e => e.Fecha.Month == mes)
                        .ToList();

                    return equipos;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
                }
            }       

        }
    }
}
