using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Battle : Identity
    {
        public string Name { get; set; }
        public string Genesis { get; set; }
        public DateTime BattleStart { get; set; }
        public DateTime BattleEnd { get; set; }

        public List<Battle> Battle_Categories { get; set; }
        public Battle()
        {
            Battle_Categories = new();
        }
    }
}
