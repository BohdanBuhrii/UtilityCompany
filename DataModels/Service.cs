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
        public string KindOfServices;
        public decimal ServiceFee;
        public string UnitOfMeasurement;
        public decimal SubscriptionFee;
        public int PeriodOfPaymentMonth;

        public string[] GetFieldsName()
        {
            return new string[] {
                "KindOfServices", "ServiceFee", "UnitOfMeasurement",
                "SubscriptionFee", "PeriodOfPaymentMonth"};
        }

        public string[] GetFieldsValue()
        {
            return new string[]{
                KindOfServices, StringHelper.ToString(ServiceFee), UnitOfMeasurement,
                StringHelper.ToString(SubscriptionFee), PeriodOfPaymentMonth.ToString()};
        }

        public string GetTable()
        {
            throw new NotImplementedException();
        }
    }
}
