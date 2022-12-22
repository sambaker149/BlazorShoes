using BlazorShoes.Data;
using BlazorShoes.Models;
using Microsoft.AspNetCore.Mvc;

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

        public void CreateAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public bool RemoveAddress(int id)
        {
            var address = _context.Addresses.Find(id);
            
            if (address == null)
            {
                return false;
            }

            _context.Addresses.Remove(address);
            _context.SaveChanges();

            return true;
        }

    }
}
