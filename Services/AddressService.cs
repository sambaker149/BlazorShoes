using BlazorShoes.Data;
using BlazorShoes.Models;
using Microsoft.AspNetCore.Mvc;
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

        private bool AddressExists(int id)
        {
            return _context.Addresses.Any(e => e.AddressId == id);
        }

        public Address GetAddress(int id)
        {
            return _context.Addresses.Find(id);
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

        public void UpdateAddress(Address address)
        {
            _context.Entry(address).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(address.AddressId))
                {
                    // should not happen
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
