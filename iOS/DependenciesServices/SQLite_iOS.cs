using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Foundation;
using UIKit;
using SQLite;
using POAFGVApp.DependenciesServices;

namespace POAFGVApp.iOS.DependenciesServices
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConn()
        {
            var sqliteFilename = "poafgvdb.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFilename);
            var conn = new SQLiteConnection(path);

            return conn;
        }
    }
}