using DataModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using Helper;


namespace Repository.ConcreteTablesLogic
{
    public class MetersRepo : ConnectionManager
    {
        /*
        meter_id bigserial,
        kind_of_services char (20) REFERENCES tariffs(kind_of_services),
        last_paid_readings decimal
        current_readings decimal
        last_check_date date
        */
        //private string tableName = "Meters";

        public MetersRepo() : base() { }
                

        public override List<object> GetKeys()
        {
            List<object> result = new List<object>();

            DbDataReader reader = ExecuteReader("SELECT meter_id FROM meters");
            while (reader.Read())
            {
                result.Add(reader["meter_id"]);
            }
            return result;
        }


        public Meter GetMeterInfo(long meter_id)
        {
            Meter meterInfo = new Meter();

            DbDataReader reader = ExecuteReader(string.Format(
                "SELECT meter_id, kind_of_services, last_paid_readings, current_readings, last_check_date " +
                "FROM meters WHERE meter_id = {0}",
                meter_id));

            if (reader.Read())
            {
                meterInfo.meter_id = (long)reader["meter_id"];
                meterInfo.kind_of_services = (string)reader["kind_of_services"];
                meterInfo.last_paid_readings = (decimal)reader["last_paid_readings"];
                meterInfo.current_readings = (decimal)reader["current_readings"];
                meterInfo.last_check_date = (string)reader["last_check_date"];
            }

            RefreshDataReader();

            return meterInfo;
        }


        public void AddMeter(long meter_id, string kind_of_services)
        {
            ExecuteNonQuery(string.Format(
                "INSERT INTO meters ( meter_id, kind_of_services, last_paid_readings, current_readings, last_check_date ) " +
                "VALUES ({0},'{1}',0,0, NOW())",
                meter_id, kind_of_services));
        }


        public void UpdateLastPaidReadings(long meter_id, decimal new_paid_readings)
        {
            decimal old_paid_readings = (decimal)ExecuteScalar(string.Format(
                "SELECT last_paid_readings FROM meters WHERE meter_id = {0}",
                meter_id));

            decimal current_readings = (decimal)ExecuteScalar(string.Format(
                "SELECT current_readings FROM meters WHERE meter_id = {0}",
                meter_id));


            if (new_paid_readings <= current_readings && new_paid_readings > old_paid_readings)
            {
                ExecuteNonQuery(string.Format(
                    "UPDATE meters SET last_paid_readings = {0} WHERE meter_id = {1}",
                    StringHelper.ToString(new_paid_readings), meter_id));
            }
            else throw new Exception("Paid readings exception");
        }


        public void UpdateCurrentReadings(long meter_id, decimal current_readings)
        {
            decimal old_readings = (decimal)ExecuteScalar(string.Format(
                "SELECT current_readings FROM meters WHERE meter_id = {0}",
                meter_id));

            if (current_readings >= old_readings)
            {
                ExecuteNonQuery(string.Format(
                    "UPDATE meters SET current_readings = {0} WHERE meter_id = {1}",
                    StringHelper.ToString(current_readings), meter_id));
            }
            else throw new Exception("Uncorrect meter readings");
        }


        public void UpdateCheckDate(long meter_id)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE meters SET last_check_date = NOW() WHERE meter_id = {0}",
                meter_id));
        }

        //todo if (current_readings!=last_paid_readings) ...
        public void DeleteMeterUnsafe(long meter_id)
        {
            ExecuteNonQuery(string.Format(
                "DELETE FROM " +
                "WHERE meter_id = {0}",
                meter_id));
        }
    }
}

