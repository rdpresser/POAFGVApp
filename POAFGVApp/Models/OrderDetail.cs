using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace POAFGVApp.Models
{
    public class OrderDetail : BaseEntity
    {
        public List<Product> Products { get; set; }

        [ForeignKey(typeof(Order))]
        public int OrderId { get; set; }
    }
}
