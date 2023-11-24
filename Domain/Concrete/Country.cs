using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Country : Identity
    {
        public string Name { get; set; }
        public string Leader { get; set; }
        public string Description { get; set; }
        public string Flag { get; set; }
        public int TotalSoldier { get; set; }
        public List<Country> Country_Categories { get; set; }
        public Country()
        {
            Country_Categories = new();
        }
    }
}
