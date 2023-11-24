using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class GlobalWar : Identity
    {
        public string Name { get; set; }
        public string Genesis { get; set; }
        public List<GlobalWar> GlobalWar_Categories { get; set; }
        public GlobalWar()
        {
            GlobalWar_Categories = new();
        }
    }
}
