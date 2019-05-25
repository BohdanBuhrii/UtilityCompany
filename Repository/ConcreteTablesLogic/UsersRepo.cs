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
        Id bigserial PRIMARY KEY
        Name varchar(100)
        Email varchar(100) PRIMARY KEY
        HashPassword varchar(88)
        IsEmployee boolean
        //type (фізична,юридична особа і т. д.)
        AccessLevel varchar(50)
        */


        public UsersRepo() : base() { }

        
        public override List<object> GetKeys()
        {
            List<object> result = new List<object>();

            DbDataReader reader = ExecuteReader("SELECT Id FROM users");
            while (reader.Read())
            {
                result.Add(reader["Id"]);
            }

            RefreshDataReader();

            return result;
        }


        public User GetUserByID(long id)
        {
            User userInfo = new User();

            DbDataReader reader = ExecuteReader(string.Format(
                "SELECT Id, Name, Email, HashPassword, IsEmployee, AccessLevel " +
                "FROM users WHERE Id = {0}",
                id));


            if (reader.Read())
            {
                userInfo.Id = (long)reader["Id"];
                userInfo.Name = (string)reader["Name"];
                userInfo.Email = (string)reader["Email"];
                userInfo.HashPassword = (string)reader["HashPassword"];
                userInfo.IsEmployee = (bool)reader["IsEmployee"];
                userInfo.AccessLevel = (string)reader["AccessLevel"];
            }

            RefreshDataReader();

            return userInfo;
        }

        public User GetUserByEmail(string email)
        {
            return GetUserByID((long)ExecuteScalar(string.Format(
                "SELECT Id FROM users WHERE Email='{0}'",email)));
        }

        public void AddUser(string name, string email, string password, bool isEmployee = false, string accessLevel = "guest")
        {
            ExecuteNonQuery(string.Format(
                "INSERT INTO users (Name, Email, HashPassword, IsEmployee, AccessLevel ) " +
                "VALUES ('{0}','{1}','{2}',{3},'{4}')",
                name, email, HashHelper.GetHashStringSHA256(password), isEmployee, accessLevel));
        }

        public void DeleteUserUnsafe(long id)
        {

            ExecuteNonQuery(string.Format(
                "DELETE FROM users WHERE Id = {0}",
                id));
        }

        public bool EmailExist(string email)
        {
            if (ExecuteScalar(string.Format("SELECT Id FROM users WHERE Email='{0}'", email)) == null) return false;
            else return true;
        }
    }
}
