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
                if (connection.GetKeys().Contains("version"))
                {
                    int dbVersion = (int)connection.ExecuteScalar("SELECT current_version FROM version");
                    //todo
                }
                else
                {
                    connection.ExecuteNonQuery(File.ReadAllText(@"Scripts\1.0.txt"));//todo
                }

            }
        }
    }
}
