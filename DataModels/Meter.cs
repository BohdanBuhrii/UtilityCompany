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
        public long meter_id;
        public string kind_of_services;
        public decimal last_paid_readings;
        public decimal current_readings;
        public string last_check_date;

        public string[] GetFieldsName()
        {
            return new string[] {
                "meter_id", "kind_of_services", "last_paid_readings",
                "current_readings", "last_check_date" };
        }

        public string[] GetFieldsValue()
        {
            return new string[] {
                meter_id.ToString(), kind_of_services, StringHelper.ToString(last_paid_readings),
                StringHelper.ToString(current_readings), last_check_date };
        }
    }
}
