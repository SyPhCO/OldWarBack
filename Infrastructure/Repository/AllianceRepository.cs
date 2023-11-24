using Domain.Concrete;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AllianceRepository : Repository<Alliance>
    {
        public AllianceRepository(Context context) : base(context)
        {
        }
    }
}
