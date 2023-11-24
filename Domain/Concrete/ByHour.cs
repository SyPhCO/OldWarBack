using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class ByHour : Identity
    {
        public string TitleHour { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public List<ByHour> ByHour_Categories { get; set; }
        public ByHour()
        {
            ByHour_Categories = new();
        }
    }
}
