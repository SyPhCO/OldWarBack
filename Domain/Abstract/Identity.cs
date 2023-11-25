using Domain.Interface;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Domain.Abstract
{
    [DataContract]
    public abstract class Identity : InterfaceIdentity
    {
        [Key]
        [DataMember(Name = "Id")]
        public long Id { get; set; }

        public string UserCreation { get; set; }
        public DateTime DateCreation { get; set; }
        public string UserModification { get; set; }
        public DateTime DateModification { get; set; }
    }
}
