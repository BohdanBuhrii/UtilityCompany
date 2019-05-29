using DataModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ConcreteTablesLogic
{
    public class RealtyRepo : ConnectionManager
    {
        public override List<object> GetKeys()
        {
            List<object> result = new List<object>();

            DbDataReader reader = ExecuteReader("SELECT Id FROM realty");
            while (reader.Read())
            {
                result.Add(reader["Id"]);
            }

            RefreshDataReader();

            return result;
        }

        public List<Realty> GetByOwner(long id, long? limit=null, long? offset=null)
        {
            List<Realty> result = new List<Realty>();

            string command = "SELECT * FROM realty WHERE OwnerId=" + id.ToString()+" ";
            if (limit.HasValue) command += "LIMIT " + limit.ToString();
            if (offset.HasValue) command += " OFFSET " + offset.ToString();

            DbDataReader reader = ExecuteReader(command);
            while (reader.Read())
            {
                result.Add(new Realty {
                    Address = (string)reader["Address"],
                    AvailableMeters =(long[])reader["AvailableMeters"],
                    District =(string)reader["District"],
                    Ownership=(string)reader["Ownership"],
                    OwnerId=(long)reader["OwnerId"],
                    Id=(long)reader["Id"],
                    Type=(string)reader["Type"],
                    Status=(string)reader["Status"]
                });
            }

            RefreshDataReader();

            return result;
        }
    }
}
