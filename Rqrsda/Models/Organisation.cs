using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rqrsda.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public State State { get; set; }

        public virtual Address Address { get; set; }
        public virtual Telephone Telephone { get; set; }
        public virtual User Director { get; set; }
        public virtual List<User> Employees { get; set; }
    }
}