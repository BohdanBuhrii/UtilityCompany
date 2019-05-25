using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace DataModels
{
    public partial class User:IInformable
    {
        public long Id;
        public string Name;
        public string Email;
        public string HashPassword;
        public bool IsEmployee;
        public string AccessLevel;

        public string[] GetFieldsName()
        {
            return new string[] {
                "Id", "Name", "Email", "HashPassword", "IsEmployee", "AccessLevel"};
        }

        public string[] GetFieldsValue()
        {
            return new string[] {
                Id.ToString(), Name, Email, HashPassword,
                IsEmployee.ToString(), AccessLevel};
        }

        public string GetTable()
        {
            throw new NotImplementedException();
        }
    }
}
