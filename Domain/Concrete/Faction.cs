using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Faction : Identity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Flag { get; set; }
        public string Chief { get; set; }
        public List<Faction> Faction_Categories { get; set; }
        public Faction()
        {
            Faction_Categories = new();
        }
    }
}
