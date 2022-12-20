using BlazorShoes.Data;
using BlazorShoes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace BlazorShoes.Services
{
    public class AddressService
    {
        private readonly ApplicationDbContext _context;

        public AddressService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Address> GetAddresses()
        {
            var addressList = _context.Addresses.ToList();
            return addressList;
        }
    }
}
