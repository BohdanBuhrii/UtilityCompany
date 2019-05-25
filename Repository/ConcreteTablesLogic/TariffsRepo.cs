using System.Collections.Generic;
using System.Data.Common;
using DataModels;
using Helper;

namespace Repository.ConcreteTablesLogic
{
    public class TariffsRepo : ConnectionManager
    {
        /*
        KindOfServices char (20) PRIMARY KEY,
        ServiceFee money,
        UnitOfMeasurement char (10),
        SubscriptionFee money,
        PeriodOfPaymentMonth int
        */
        public TariffsRepo() : base() { }


        public override List<object> GetKeys()
        {
            List<object> result = new List<object>();

            DbDataReader reader = ExecuteReader("SELECT KindOfServices FROM tariffs");
            while (reader.Read())
            {
                result.Add(reader["KindOfServices"]);
            }

            RefreshDataReader();

            return result;
        }


        public Service GetServiceInfo(string kindOfServices)
        {
            Service serviceInfo = new Service();

            DbDataReader reader = ExecuteReader(string.Format(
                "SELECT KindOfServices, ServiceFee, UnitOfMeasurement, SubscriptionFee, PeriodOfPaymentMonth " +
                "FROM tariffs WHERE KindOfServices = '{0}'",
                kindOfServices));

            if (reader.Read())
            {
                serviceInfo.KindOfServices = (string)reader["KindOfServices"];
                serviceInfo.ServiceFee = (decimal)reader["ServiceFee"];
                serviceInfo.UnitOfMeasurement = (string)reader["UnitOfMeasurement"];
                serviceInfo.SubscriptionFee = (decimal)reader["SubscriptionFee"];
                serviceInfo.PeriodOfPaymentMonth = (int)reader["PeriodOfPaymentMonth"];
            }

            RefreshDataReader();

            return serviceInfo;
        }


        public void AddServise(string kindOfServices, decimal serviceFee,
            string unitOfMeasurement, decimal subscriptionFee, int periodOfPaymentMonth)
        {
            ExecuteNonQuery(string.Format(
                "INSERT INTO tariffs (KindOfServices, ServiceFee, UnitOfMeasurement, SubscriptionFee, PeriodOfPaymentMonth) " +
                "VALUES ('{0}',{1},'{2}',{3},{4})",
                kindOfServices, StringHelper.ToString(serviceFee), unitOfMeasurement,
                StringHelper.ToString(subscriptionFee), periodOfPaymentMonth));
        }


        public void EditServiseFee(string kindOfServices, decimal newFee)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE tariffs SET ServiceFee = {0} WHERE KindOfServices='{1}'",
                StringHelper.ToString(newFee), kindOfServices));
        }


        public void EditSubscriptionFee(string kindOfServices, decimal newSubscriptionFee)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE tariffs SET SubscriptionFee = {0} WHERE KindOfServices='{1}'",
                StringHelper.ToString(newSubscriptionFee), kindOfServices));
        }


        public void EditPeriodOfPayment(string kindOfServices, int newPeriodOfPayment)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE tariffs SET PeriodOfPaymentMonth = {0} WHERE KindOfServices='{1}'",
                newPeriodOfPayment, kindOfServices));
        }


        public void DeleteServiceUnsafe(string kindOfServices)
        {
            ExecuteNonQuery(string.Format(
                "DELETE FROM tariffs WHERE KindOfServices = '{0}'",
                kindOfServices));
        }

    }
}
