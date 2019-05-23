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

            DbDataReader reader = ExecuteReader("SELECT realty_id FROM realty");
            while (reader.Read())
            {
                result.Add(reader["realty_id"]);
            }

            RefreshDataReader();

            return result;
        }

        public List<Realty> GetByOwner(long owner_id, int? limit=null, int? offset=null)
        {
            List<Realty> result = new List<Realty>();

            DbDataReader reader = ExecuteReader("SELECT * FROM realty");
            while (reader.Read())
            {
                result.Add(new Realty {
                    address = (string)reader["address"],
                    available_meters =(long[])reader["available_meters"],
                    district =(string)reader["district"],
                    ownership=(string)reader["ownership"],
                    owner_id=(long)reader["owner_id"],
                    realty_id=(long)reader["realty_id"],
                    realty_type=(string)reader["realty_type"],
                    status=(string)reader["status"]
                });
            }

            RefreshDataReader();

            return result;
        }
    }
}
