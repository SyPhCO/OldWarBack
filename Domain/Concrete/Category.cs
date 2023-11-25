using Domain.Abstract;
using System.Runtime.Serialization;

namespace Domain.Concrete
{
    [DataContract]
    public class Category : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Role { get; set; }
    }
}
