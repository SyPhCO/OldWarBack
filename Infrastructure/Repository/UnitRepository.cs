using Domain.Concrete;
using Infrastructure.Data;
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
    }
}
