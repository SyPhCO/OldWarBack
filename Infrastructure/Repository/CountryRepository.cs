using Domain.Concrete;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CountryRepository : Repository<Country>
    {
        public CountryRepository(Context context) : base(context)
        {
        }
    }
}
