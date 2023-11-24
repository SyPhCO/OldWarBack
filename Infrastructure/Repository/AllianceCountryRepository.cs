using Domain.Concrete;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class Alliance_CountryRepository : Repository<Alliance_Country>
    {
        public Alliance_CountryRepository(Context context) : base(context)
        {
        }
    }
}
