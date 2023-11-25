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
    public class GlobalWar : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Genesis { get; set; }

        [DataMember]
        public ICollection<Battle> Battles { get; set; }

        public GlobalWar() {
            Battles = new HashSet<Battle>();
        }
    }
}
