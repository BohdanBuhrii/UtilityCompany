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
        public long user_id;
        public string user_name;
        public string email;
        public string hash_password;
        public bool is_employee;
        public string access_level;

        public string[] GetFieldsName()
        {
            return new string[] {
                "user_id", "user_name", "email", "hash_password", "is_employee", "access_level"};
        }

        public string[] GetFieldsValue()
        {
            return new string[] {
                user_id.ToString(), user_name, email, hash_password,
                is_employee.ToString(), access_level};
        }
    }
}
