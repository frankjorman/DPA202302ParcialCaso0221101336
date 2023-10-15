using DPA202302ParcialCaso0221101336.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0221101336.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerrotoryController : ControllerBase
    {

        private readonly Dpa202302parcialCaso0221101336Context _context;

        public TerrotoryController(Dpa202302parcialCaso0221101336Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Territory>> ResgistrarTerritorio(Territory territory)
        {
            if (territory == null)
            {
                return BadRequest();
            }

            _context.Territory.Add(territory);
            var resultado = await _context.SaveChangesAsync();

            if (resultado == 1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public async Task<IActionResult> ActualizarTerritorio(Territory territory)
        {
            if (territory == null)
            {
                return BadRequest();
            }

            _context.Territory.Update(territory);

            var resultado = await _context.SaveChangesAsync();

            if (resultado == 1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarTerritorio(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            
            var territory = await _context.Territory.FindAsync(id);
            if (territory == null)
            {
                return NotFound();
            }

            _context.Territory.Remove(territory);
            var resultado = await _context.SaveChangesAsync();

            if (resultado == 1)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Territory>>> ListarTerritorios()
        {
            return await _context.Territory.ToListAsync();
        }
    }
}
