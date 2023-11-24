using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Category : Identity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public List<Rank_Category> Ranks_Category { get; set; }
        public Category() {
        Ranks_Category = new ();
        }
        
    }
}
