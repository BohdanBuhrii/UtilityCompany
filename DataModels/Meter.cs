using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace DataModels
{
    public class Meter:IInformable
    {
        public long Id;
        public string KindOfServices;
        public decimal LastPaidReadings;
        public decimal CurrentReadings;
        public string LastCheckDate;

        public string[] GetFieldsName()
        {
            return new string[] {
                "Id", "KindOfServices", "LastPaidReadings",
                "CurrentReadings", "LastCheckDate" };
        }

        public string[] GetFieldsValue()
        {
            return new string[] {
                Id.ToString(), KindOfServices, StringHelper.ToString(LastPaidReadings),
                StringHelper.ToString(CurrentReadings), LastCheckDate };
        }

        public string GetTable()
        {
            throw new NotImplementedException();
        }
    }
}
