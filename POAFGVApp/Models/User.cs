using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POAFGVApp.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [OneToOne("AddressId")]
        public Address Address { get; set; }

        [ForeignKey(typeof(Address))]
        public int AddressId { get; set; }
    }
}
