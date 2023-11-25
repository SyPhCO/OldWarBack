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
    public class ByHour : Identity
    {
        [DataMember]
        public string TitleHour { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Picture { get; set; }

        [DataMember]
        public ICollection<Battle_ByHour> Battle_ByHours { get; set; }

        [DataMember]
        public ICollection<Faction_ByHour> Faction_ByHours { get; set; }

        public ByHour()
        {
            Battle_ByHours = new HashSet<Battle_ByHour>();
            Faction_ByHours = new HashSet<Faction_ByHour>();
        }
    }
}
