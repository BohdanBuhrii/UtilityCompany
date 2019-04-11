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
    static class MigrationManager
    {
        static readonly int version = 1;


        static void Migrate()
        {
            using (ConnectionManager connection = new ConnectionManager())
            {
                int dbVersion = (int)connection.ExecuteScalar("SELECT current_version FROM version");

                if (version > dbVersion)
                {
                    //todo  connection.ExecuteNonQuery(File.ReadAllText(...
                }
            }
        }
    }
}
