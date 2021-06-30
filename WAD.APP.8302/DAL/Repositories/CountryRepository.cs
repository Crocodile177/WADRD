using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class CountryRepository : BaseRepository, IRepository<Country>
    {
        public CountryRepository(Context context) : base(context) { }
        public async Task CreateAsync(Country entity)
        {
            _context.Country.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var country = await _context.Country.FindAsync(id);
            _context.Country.Remove(country);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Country>> GetAllAsync()
        {
            return await _context.Country.ToListAsync();
        }

        public async Task<Country> GetByIdAsync(int id)
        {
            var country = await _context.Country.FindAsync(id);
            return country;
        }

        public async Task UpdateAsync(Country entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}