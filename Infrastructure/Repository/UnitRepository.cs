using Domain.Abstract;
using Domain.Concrete;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UnitRepository : Repository<Unit>
    {
        public UnitRepository(Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Unit>> GetAllAsync()
        {
            return await _context.Unit
                .Include(m => m.Rank)
                .Include(m => m.Category)
                .Include(m => m.Faction)
                .Include(m => m.Country)
                .ToListAsync();
        }
    }
}
