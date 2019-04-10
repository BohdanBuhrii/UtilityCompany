using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public partial class User
    {
        public long user_id;
        public string user_name;
        public string email;
        public string hash_password;
        public bool is_employee;
        public string access_level;
    }
}
