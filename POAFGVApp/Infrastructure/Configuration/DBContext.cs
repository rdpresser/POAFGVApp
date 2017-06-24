using POAFGVApp.DependenciesServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POAFGVApp.Infrastructure.Configuration
{
    public sealed class DBContext
    {
        static object _lock = new object();
        static volatile DBContext instance;
        static SQLite.SQLiteConnection conn = null;

        DBContext()
        {
            conn = Xamarin.Forms.DependencyService.Get<ISQLite>(Xamarin.Forms.DependencyFetchTarget.GlobalInstance).GetConn();
        }

        public static SQLite.SQLiteConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        instance = new DBContext();
                    }
                }

                return conn;
            }
        }
    }
}
