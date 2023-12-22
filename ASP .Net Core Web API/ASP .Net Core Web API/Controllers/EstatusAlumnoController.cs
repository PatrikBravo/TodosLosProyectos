using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_.Net_Core_Web_API.Models.Context;
using ASP_.Net_Core_Web_API.Models.Entities;

namespace ASP_.Net_Core_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstatusAlumnoController : ControllerBase
    {
        private readonly EstatusContext _context;

        public EstatusAlumnoController(EstatusContext context)
        {
            _context = context;
        }

        // GET: api/EstatusAlumno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstatusAlumno>>> GetEstatusAlumno()
        {
          if (_context.EstatusAlumno == null)
          {
              return NotFound();
          }
            return await _context.EstatusAlumno.ToListAsync();
        }

        // GET: api/EstatusAlumno/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstatusAlumno>> GetEstatusAlumno(short id)
        {
          if (_context.EstatusAlumno == null)
          {
              return NotFound();
          }
            var estatusAlumno = await _context.EstatusAlumno.FindAsync(id);

            if (estatusAlumno == null)
            {
                return NotFound();
            }

            return estatusAlumno;
        }

        // PUT: api/EstatusAlumno/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstatusAlumno(short id, EstatusAlumno estatusAlumno)
        {
            if (id != estatusAlumno.Id)
            {
                return BadRequest();
            }

            _context.Entry(estatusAlumno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstatusAlumnoExists(id))
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

        // POST: api/EstatusAlumno
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstatusAlumno>> PostEstatusAlumno(EstatusAlumno estatusAlumno)
        {
          if (_context.EstatusAlumno == null)
          {
              return Problem("Entity set 'EstatusContext.EstatusAlumno'  is null.");
          }
            _context.EstatusAlumno.Add(estatusAlumno);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstatusAlumnoExists(estatusAlumno.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstatusAlumno", new { id = estatusAlumno.Id }, estatusAlumno);
        }

        // DELETE: api/EstatusAlumno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstatusAlumno(short id)
        {
            if (_context.EstatusAlumno == null)
            {
                return NotFound();
            }
            var estatusAlumno = await _context.EstatusAlumno.FindAsync(id);
            if (estatusAlumno == null)
            {
                return NotFound();
            }

            _context.EstatusAlumno.Remove(estatusAlumno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstatusAlumnoExists(short id)
        {
            return (_context.EstatusAlumno?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
