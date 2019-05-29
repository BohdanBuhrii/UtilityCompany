using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class News : IInformable
    {
        public long Id;
        public string Title;
        public string Content;
        public DateTime CreationDate;

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
