﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlazorShoes.Data;
using BlazorShoes.Models;

namespace BlazorShoes.Pages.Addresses
{
    public class DetailsModel : PageModel
    {
        private readonly BlazorShoes.Data.ApplicationDbContext _context;

        public DetailsModel(BlazorShoes.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Address Address { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Addresses == null)
            {
                return NotFound();
            }

            var address = await _context.Addresses.FirstOrDefaultAsync(m => m.AddressId == id);
            if (address == null)
            {
                return NotFound();
            }
            else 
            {
                Address = address;
            }
            return Page();
        }
    }
}
