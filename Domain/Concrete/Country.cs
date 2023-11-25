using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    [DataContract]
    public class Country : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember] 
        public string Leader { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Flag { get; set; }

        [DataMember]
        public int TotalSoldier { get; set; }

        [DataMember]
        public ICollection<Country_Alliance> Country_Alliances { get; set; }

        [DataMember]
        public ICollection<Country_Battle> Country_Battles { get; set; }

        public Country() { 
            Country_Alliances = new HashSet<Country_Alliance>();
            Country_Battles = new HashSet<Country_Battle>();
        }
    }
}
