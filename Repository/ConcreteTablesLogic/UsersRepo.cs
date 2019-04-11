using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;
using Helper;

namespace Repository.ConcreteTablesLogic
{
    public class UsersRepo : ConnectionManager //todo
    {
        /*
        user_id bigserial PRIMARY KEY
        user_name varchar(100)
        email varchar(100) PRIMARY KEY
        hash_password varchar(88)
        is_employee boolean
        //type (фізична,юридична особа і т. д.)
        access_level varchar(50)
        */


        public UsersRepo() : base() { }

        
        public override List<object> GetKeys()
        {
            List<object> result = new List<object>();

            DbDataReader reader = ExecuteReader("SELECT user_id FROM users");
            while (reader.Read())
            {
                result.Add(reader["user_id"]);
            }

            RefreshDataReader();

            return result;
        }


        public User GetUserInfo(long user_id)
        {
            User userInfo = new User();

            DbDataReader reader = ExecuteReader(string.Format(
                "SELECT user_id, user_name, email, hash_password, is_employee, access_level " +
                "FROM users WHERE user_id = {0}",
                user_id));


            if (reader.Read())
            {
                userInfo.user_id = (long)reader["user_id"];
                userInfo.user_name = (string)reader["user_name"];
                userInfo.email = (string)reader["email"];
                userInfo.hash_password = (string)reader["hash_password"];
                userInfo.is_employee = (bool)reader["is_employee"];
                userInfo.access_level = (string)reader["access_level"];
            }

            RefreshDataReader();

            return userInfo;
        }

        public void AddUser(string user_name, string email, string password, bool is_employee = false, string access_level = "guest")
        {
            ExecuteNonQuery(string.Format(
                "INSERT INTO users (user_name, email, hash_password, is_employee, access_level ) " +
                "VALUES ('{0}','{1}','{2}',{3},'{4}')",
                user_name, email, HashHelper.GetHashStringSHA256(password), is_employee, access_level));
        }

        public void DeleteUserUnsafe(long user_id)
        {

            ExecuteNonQuery(string.Format(
                "DELETE FROM users WHERE user_id = {0}",
                user_id));
        }

    }
}
