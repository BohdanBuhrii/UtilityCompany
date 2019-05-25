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
        Id bigserial,
        KindOfServices char (20) REFERENCES tariffs(KindOfServices),
        LastPaidReadings decimal
        CurrentReadings decimal
        LastCheckDate date
        */
        //private string tableName = "Meters";

        public MetersRepo() : base() { }
                

        public override List<object> GetKeys()
        {
            List<object> result = new List<object>();

            DbDataReader reader = ExecuteReader("SELECT id FROM meters");
            while (reader.Read())
            {
                result.Add(reader["id"]);
            }
            return result;
        }


        public Meter GetMeterInfo(long id)
        {
            Meter meterInfo = new Meter();

            DbDataReader reader = ExecuteReader(string.Format(
                "SELECT id, kindofservices, lastpaidreadings, currentreadings, lastcheckdate " +
                "FROM meters WHERE id = {0}",
                id));

            if (reader.Read())
            {
                meterInfo.Id = (long)reader["id"];
                meterInfo.KindOfServices = (string)reader["kindofservices"];
                meterInfo.LastPaidReadings = (decimal)reader["lastpaidreadings"];
                meterInfo.CurrentReadings = (decimal)reader["currentreadings"];
                meterInfo.LastCheckDate = (DateTime)reader["lastcheckdate"];
            }

            RefreshDataReader();

            return meterInfo;
        }


        public void AddMeter(long id, string kindOfServices)
        {
            ExecuteNonQuery(string.Format(
                "INSERT INTO meters ( Id, KindOfServices, LastPaidReadings, CurrentReadings, LastCheckDate ) " +
                "VALUES ({0},'{1}',0,0, NOW())",
                id, kindOfServices));
        }


        public void UpdateLastPaidReadings(long id, decimal newPaidReadings)
        {
            decimal oldPaidReadings = (decimal)ExecuteScalar(string.Format(
                "SELECT LastPaidReadings FROM meters WHERE Id = {0}",
                id));

            decimal currentReadings = (decimal)ExecuteScalar(string.Format(
                "SELECT CurrentReadings FROM meters WHERE Id = {0}",
                id));


            if (newPaidReadings <= currentReadings && newPaidReadings > oldPaidReadings)
            {
                ExecuteNonQuery(string.Format(
                    "UPDATE meters SET LastPaidReadings = {0} WHERE Id = {1}",
                    StringHelper.ToString(newPaidReadings), id));
            }
            else throw new Exception("Paid readings exception");
        }


        public void UpdateCurrentReadings(long id, decimal currentReadings)
        {
            decimal oldReadings = (decimal)ExecuteScalar(string.Format(
                "SELECT CurrentReadings FROM meters WHERE Id = {0}",
                id));

            if (currentReadings >= oldReadings)
            {
                ExecuteNonQuery(string.Format(
                    "UPDATE meters SET CurrentReadings = {0} WHERE Id = {1}",
                    StringHelper.ToString(currentReadings), id));
            }
            else throw new Exception("Uncorrect meter readings");
        }


        public void UpdateCheckDate(long id)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE meters SET LastCheckDate = NOW() WHERE Id = {0}",
                id));
        }

        //todo if (current_readings!=LastPaidReadings) ...
        public void DeleteMeterUnsafe(long id)
        {
            ExecuteNonQuery(string.Format(
                "DELETE FROM " +
                "WHERE Id = {0}",
                id));
        }
    }
}

