using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Meter
    {
        public long meter_id;
        public string kind_of_services;
        public decimal last_paid_readings;
        public decimal current_readings;
        public string last_check_date;
    }
}
