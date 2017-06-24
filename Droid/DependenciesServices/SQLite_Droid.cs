using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using POAFGVApp.DependenciesServices;

namespace POAFGVApp.Droid.DependenciesServices
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConn()
        {
            var sqliteFilename = "poafgvdb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}