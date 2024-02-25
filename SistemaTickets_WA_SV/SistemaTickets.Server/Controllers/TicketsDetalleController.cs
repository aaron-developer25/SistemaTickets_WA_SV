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
    public class TicketsDetalleController : ControllerBase
    {
        private readonly Contexto _context;

        public TicketsDetalleController(Contexto context)
        {
            _context = context;
        }

        // GET: api/TicketsDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketsDetalle>>> GetTicketsDetalle()
        {
            return await _context.TicketsDetalle.ToListAsync();
        }

        // GET: api/TicketsDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketsDetalle>> GetTicketsDetalle(int id)
        {
            var ticketsDetalle = await _context.TicketsDetalle.FindAsync(id);

            if (ticketsDetalle == null)
            {
                return NotFound();
            }

            return ticketsDetalle;
        }

        // PUT: api/TicketsDetalle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicketsDetalle(int id, TicketsDetalle ticketsDetalle)
        {
            if (id != ticketsDetalle.Id)
            {
                return BadRequest();
            }

            _context.Entry(ticketsDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketsDetalleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TicketsDetalle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TicketsDetalle>> PostTicketsDetalle(TicketsDetalle ticketsDetalle)
        {
            _context.TicketsDetalle.Add(ticketsDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicketsDetalle", new { id = ticketsDetalle.Id }, ticketsDetalle);
        }

        // DELETE: api/TicketsDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicketsDetalle(int id)
        {
            var ticketsDetalle = await _context.TicketsDetalle.FindAsync(id);
            if (ticketsDetalle == null)
            {
                return NotFound();
            }

            _context.TicketsDetalle.Remove(ticketsDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketsDetalleExists(int id)
        {
            return _context.TicketsDetalle.Any(e => e.Id == id);
        }
    }
}
