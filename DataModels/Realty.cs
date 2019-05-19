using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Realty : IInformable
    {
        public long realty_id;
        public string address;
        public string district;
        public string realty_type;
        //string[] available_services;
        public string[] available_meters;
        public string[] ownership;
        public long owner_id;
        public long status;

        public string[] GetFieldsName()
        {
            throw new NotImplementedException();
        }

        public string[] GetFieldsValue()
        {
            throw new NotImplementedException();
        }

        public string GetTable()
        {
            throw new NotImplementedException();
        }
    }
}
