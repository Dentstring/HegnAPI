using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HegnTilbudApi.Data;
using HegnTilbudApi.Model;

namespace HegnTilbudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaftHegnsController : ControllerBase
    {
        private readonly HegnTilbudContext _context;

        public RaftHegnsController(HegnTilbudContext context)
        {
            _context = context;
        }

        // GET: api/RaftHegns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaftHegn>>> GetrafHegn()
        {
            return await _context.rafHegn.ToListAsync();
        }

        // GET: api/RaftHegns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaftHegn>> GetRaftHegn(int id)
        {
            var raftHegn = await _context.rafHegn.FindAsync(id);

            if (raftHegn == null)
            {
                return NotFound();
            }

            return raftHegn;
        }

        // PUT: api/RaftHegns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaftHegn(int id, RaftHegn raftHegn)
        {
            if (id != raftHegn.ID)
            {
                return BadRequest();
            }

            _context.Entry(raftHegn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaftHegnExists(id))
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

        // POST: api/RaftHegns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaftHegn>> PostRaftHegn(RaftHegn raftHegn)
        {
            _context.rafHegn.Add(raftHegn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRaftHegn", new { id = raftHegn.ID }, raftHegn);
        }

        // DELETE: api/RaftHegns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaftHegn(int id)
        {
            var raftHegn = await _context.rafHegn.FindAsync(id);
            if (raftHegn == null)
            {
                return NotFound();
            }

            _context.rafHegn.Remove(raftHegn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaftHegnExists(int id)
        {
            return _context.rafHegn.Any(e => e.ID == id);
        }
    }
}
