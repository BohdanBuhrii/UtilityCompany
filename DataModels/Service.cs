using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace DataModels
{
    public class Service:IInformable
    {
        public string kind_of_services;
        public decimal service_fee;
        public string unit_of_measurement;
        public decimal subscription_fee;
        public int period_of_payment_month;

        public string[] GetFieldsName()
        {
            return new string[] {
                "kind_of_services", "service_fee", "unit_of_measurement",
                "subscription_fee", "period_of_payment_month"};
        }

        public string[] GetFieldsValue()
        {
            return new string[]{
                kind_of_services, StringHelper.ToString(service_fee), unit_of_measurement,
                StringHelper.ToString(subscription_fee), period_of_payment_month.ToString()};
        }
    }
}
