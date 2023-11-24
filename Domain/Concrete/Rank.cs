using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Rank : Identity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureRank { get; set; }

        public List<Rank_Category> Rank_Categories { get; set; }
        public Rank() {
            Rank_Categories = new();
                }
    }
}
