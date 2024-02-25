using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;
using SistemaTickets.Server.DAL;

namespace SistemaTickets.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrioridadesController : ControllerBase
    {
        private readonly Contexto _context;

        public PrioridadesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Prioridades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prioridades>>> GetPrioridades()
        {
            return await _context.Prioridades.ToListAsync();
        }

        // GET: api/Prioridades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prioridades>> GetPrioridades(int id)
        {
            var prioridades = await _context.Prioridades.FindAsync(id);

            if (prioridades == null)
            {
                return NotFound();
            }

            return prioridades;
        }

        // PUT: api/Prioridades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<ActionResult<Prioridades>> PutPrioridades(Prioridades prioridades)
        {
            if (PrioridadesExists(prioridades.PrioridadId))
            {
                _context.Prioridades.Update(prioridades);
            }
            await _context.SaveChangesAsync();
            return Ok(prioridades);
        }

        // POST: api/Prioridades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prioridades>> PostPrioridades(Prioridades prioridades)
        {
            _context.Prioridades.Add(prioridades);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrioridades", new { id = prioridades.PrioridadId }, prioridades);
        }

        // DELETE: api/Prioridades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrioridades(int id)
        {
            var prioridades = await _context.Prioridades.FindAsync(id);
            if (prioridades == null)
            {
                return NotFound();
            }

            _context.Prioridades.Remove(prioridades);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrioridadesExists(int id)
        {
            return _context.Prioridades.Any(e => e.PrioridadId == id);
        }
    }
}
