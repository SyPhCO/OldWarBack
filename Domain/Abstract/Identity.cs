using Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Abstract
{
    public abstract class Identity : InterfaceIdentity
    {
        [Key]
        public long Id { get; set; }

        public string UserCreation { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public string UserModification { get; set; }
    }
}
