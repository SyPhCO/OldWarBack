using Domain.Concrete;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ByHourRepository : Repository<ByHour>
    {
        public ByHourRepository(Context context) : base(context)
        {
        }
    }
}
