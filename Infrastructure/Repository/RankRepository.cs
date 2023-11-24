using Core;
using Core.Repositories;
using Domain.Concrete;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RankRepository : Repository<Rank>
    {
        public RankRepository(Context context) : base(context)
        {
        }
    }
}
