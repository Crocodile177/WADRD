using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;

namespace DAL.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly Context _context;

        protected BaseRepository(Context context)
        {
            _context = context;
        }
    }
}