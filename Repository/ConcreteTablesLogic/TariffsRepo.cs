using System.Collections.Generic;
using System.Data.Common;
using Helper;

namespace Repository.ConcreteTablesLogic
{
    class TariffsRepo : ConnectionManager
    {
        /*
        kind_of_services char (20) PRIMARY KEY,
        service_fee money,
        unit_of_measurement char (10),
        subscription_fee money,
        period_of_payment_month int
        */
        public TariffsRepo() : base() { }


        public override List<object> GetKeys()
        {
            List<object> result = new List<object>();

            DbDataReader reader = ExecuteReader("SELECT kind_of_services FROM tariffs");
            while (reader.Read())
            {
                result.Add(reader["kind_of_services"]);
            }

            RefreshDataReader();

            return result;
        }


        public struct ServiceInfo
        {
            public string kind_of_services;
            public decimal service_fee;
            public string unit_of_measurement;
            public decimal subscription_fee;
            public int period_of_payment_month;

            public override string ToString()
            {
                return string.Format(
                "kind_of_services: {0}\nservice_fee: {1}\nunit_of_measurement: {2}\nsubscription_fee: {3}\nperiod_of_payment_month: {4}",
                kind_of_services, service_fee, unit_of_measurement, subscription_fee, period_of_payment_month);
            }

        }


        public ServiceInfo GetServiceInfo(string kind_of_services)
        {
            ServiceInfo serviceInfo = new ServiceInfo();

            DbDataReader reader = ExecuteReader(string.Format(
                "SELECT kind_of_services, service_fee, unit_of_measurement, subscription_fee, period_of_payment_month " +
                "FROM tariffs WHERE kind_of_services = '{0}'",
                kind_of_services));

            if (reader.Read())
            {
                serviceInfo.kind_of_services = (string)reader["kind_of_services"];
                serviceInfo.service_fee = (decimal)reader["service_fee"];
                serviceInfo.unit_of_measurement = (string)reader["unit_of_measurement"];
                serviceInfo.subscription_fee = (decimal)reader["subscription_fee"];
                serviceInfo.period_of_payment_month = (int)reader["period_of_payment_month"];
            }

            RefreshDataReader();

            return serviceInfo;
        }


        public void AddServise(string kind_of_services, decimal service_fee,
            string unit_of_measurement, decimal subscription_fee, int period_of_payment_month)
        {
            ExecuteNonQuery(string.Format(
                "INSERT INTO tariffs (kind_of_services, service_fee, unit_of_measurement, subscription_fee, period_of_payment_month) " +
                "VALUES ('{0}',{1},'{2}',{3},{4})",
                kind_of_services, StringHelper.ToString(service_fee), unit_of_measurement,
                StringHelper.ToString(subscription_fee), period_of_payment_month));
        }


        public void EditServiseFee(string kind_of_services, decimal new_fee)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE tariffs SET service_fee = {0} WHERE kind_of_services='{1}'",
                StringHelper.ToString(new_fee), kind_of_services));
        }


        public void EditSubscriptionFee(string kind_of_services, decimal new_subscription_fee)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE tariffs SET subscription_fee = {0} WHERE kind_of_services='{1}'",
                StringHelper.ToString(new_subscription_fee), kind_of_services));
        }


        public void EditPeriodOfPayment(string kind_of_services, int new_period_of_payment)
        {
            ExecuteNonQuery(string.Format(
                "UPDATE tariffs SET period_of_payment_month = {0} WHERE kind_of_services='{1}'",
                new_period_of_payment, kind_of_services));
        }


        public void DeleteServiceUnsafe(string kind_of_services)
        {
            ExecuteNonQuery(string.Format(
                "DELETE FROM tariffs WHERE kind_of_services = '{0}'",
                kind_of_services));
        }

    }
}
