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
    public class Rank_CategoryRepository : Repository<Rank_Category>
    {
        public Rank_CategoryRepository(Context context) : base(context)
        {
        }
    }
}
