using Domain.Concrete;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BattleRepository : Repository<Battle>
    {
        public BattleRepository(Context context) : base(context) {
        }
    }
}
