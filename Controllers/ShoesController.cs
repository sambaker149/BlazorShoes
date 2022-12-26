﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorShoes.Data;
using BlazorShoes.Models;

namespace BlazorShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Shoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shoe>>> GetShoe()
        {
            return await _context.Shoe.ToListAsync();
        }

        // GET: api/Shoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Shoe>> GetShoe(int id)
        {
            var shoe = await _context.Shoe.FindAsync(id);

            if (shoe == null)
            {
                return NotFound();
            }

            return shoe;
        }

        // PUT: api/Shoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoe(int id, Shoe shoe)
        {
            if (id != shoe.ShoeId)
            {
                return BadRequest();
            }

            _context.Entry(shoe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoeExists(id))
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

        // POST: api/Shoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Shoe>> PostShoe(Shoe shoe)
        {
            _context.Shoe.Add(shoe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoe", new { id = shoe.ShoeId }, shoe);
        }

        // DELETE: api/Shoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoe(int id)
        {
            var shoe = await _context.Shoe.FindAsync(id);
            if (shoe == null)
            {
                return NotFound();
            }

            _context.Shoe.Remove(shoe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShoeExists(int id)
        {
            return _context.Shoe.Any(e => e.ShoeId == id);
        }
    }
}