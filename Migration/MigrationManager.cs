using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.IO;

namespace Migration
{
    public static class MigrationManager
    {
        static readonly int version = 1;

        static readonly string[] migrationPriority = new string[] { "tarrifs", "users", "meters", "realty",  "version" };
        
        /*
        static MigrationManager()
        {
            Migrate();
        }*/
        static void CreateTables()
        {
            using (ConnectionManager connection = new ConnectionManager())
            {
                List<object> tables = connection.GetKeys();

                //string[] scripts = Directory.GetFiles(
                //    @"..\..\..\Migration\Scripts\CreateTables");

                

                bool exist;
                foreach (string script in migrationPriority)
                {
                    exist = false;

                    foreach (string table in tables)
                    {
                        if (script.Contains((string)table)) exist = true;
                    }

                    if (!exist) connection.ExecuteNonQuery(File.ReadAllText(
                        @"..\..\..\Migration\Scripts\CreateTables\"+script+".sql")); 
                }
            }
        }

        public static void Migrate()
        {
            using (ConnectionManager connection = new ConnectionManager())
            {
                CreateTables();

                int dbVersion = (int)connection.ExecuteScalar("SELECT current_version FROM version");

                //Directory.GetFiles(@"D:\USERS\Buhrii_B\C#\Бази даних\UtilityCompany\Migration\Scripts");

                for (int v = dbVersion + 1; v <= version; v++)
                {
                    connection.ExecuteNonQuery(File.ReadAllText(string.Format(
                        @"D:\USERS\Buhrii_B\C#\Бази даних\UtilityCompany\Migration\Scripts\{0}.sql",v)));
                }
            }
        }
    }
}
