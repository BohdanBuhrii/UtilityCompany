using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Realty : IInformable
    {
        public long Id;
        public string Address;
        public string District;
        public string Type;
        public long[] AvailableMeters;
        public string Ownership;
        public long OwnerId;
        public string Status;

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
