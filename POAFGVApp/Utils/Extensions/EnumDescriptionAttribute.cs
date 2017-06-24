using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POAFGVApp.Utils.Extensions
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumDescriptionAttribute : Attribute
    {
        readonly string _description;
        public string Description { get { return _description; } }

        public EnumDescriptionAttribute(string description)
        {
            _description = description;
        }
    }
}
