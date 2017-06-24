using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POAFGVApp.Theme
{
    public static class MainTheme
    {
        public static Color OverImageTextColor = Color.White;

        public static Style DefaultLabel = new Style(typeof(Label))
        {
            Setters =
            {
                new Setter()
                {
                    Property = Label.FontSizeProperty,
                    Value = 22
                },
                new Setter()
                {
                    Property = Label.HorizontalOptionsProperty,
                    Value = LayoutOptions.CenterAndExpand
                }
            }
        };
    }
}
