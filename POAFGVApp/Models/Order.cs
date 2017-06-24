using POAFGVApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace POAFGVApp.Models
{
    public class Order
    {
        [OneToMany]
        public List<OrderDetail> OrdersDetail { get; set; }
        public EnumPaymentType PaymentType { get; set; }
    }
}
