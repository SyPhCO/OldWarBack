using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Rank_Category : Identity
    {
        public long RankId { get; set; }
        [ForeignKey("RankId")]
        public virtual Rank Rank { get; set; }
        public long CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public Rank_Category() { }
    }
}
