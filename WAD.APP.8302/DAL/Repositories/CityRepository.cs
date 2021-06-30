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

    public class CityRepository : BaseRepository, IRepository<City>
    {
        public CityRepository(Context context) : base(context) { }

        public async Task CreateAsync(City entity)
        {
            _context.City.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var city = await _context.City.FindAsync(id);
            _context.City.Remove(city);
            await _context.SaveChangesAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.City.ToListAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            var city = await _context.City.Include(c => c.Country).FirstOrDefaultAsync(c => c.Id == id);
            return city;
        }

        public async Task UpdateAsync(City entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}