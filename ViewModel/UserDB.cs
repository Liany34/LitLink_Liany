using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UserDB : BaseDB
    {
        public ListUser SelectAll()
        {
            command.CommandText = $"SELECT * FROM [User]";
            ListUser groupList = new ListUser(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            User u = entity as User;
            u.FirstName = reader["firstName"].ToString();
            u.LastName = reader["lastName"].ToString();
            u.PhoneNumber = reader["phoneNumber"] != DBNull.Value ? reader["phoneNumber"].ToString() : null;
            u.Email = reader["email"] != DBNull.Value ? reader["email"].ToString() : null;
            u.Pass = reader["pass"].ToString();
            u.Birthdate = (DateTime)reader["birthDate"];
            base.CreateModel(entity);
            return u;
        }
        public override BaseEntity NewEntity()
        {
            return new User();
        }
        static private ListUser list = new ListUser();
        public static User SelectById(int id)
        {
            UserDB db = new UserDB();
            list = db.SelectAll();

            User g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = $"DELETE FROM [User] WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = $"Insert INTO [User] (FirstName, LastName, PhoneNumber, Email, Username, Pass, Birthdate) VALUES (@firstName, @lastName, @phoneNumber, @email, @username, @pass, @birthdate)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@firstName", u.FirstName));
                command.Parameters.Add(new OleDbParameter("@lastName", u.LastName));
                command.Parameters.Add(new OleDbParameter("@phoneNumber", u.PhoneNumber));
                command.Parameters.Add(new OleDbParameter("@email", u.Email));
                command.Parameters.Add(new OleDbParameter("@username", u.Username));
                command.Parameters.Add(new OleDbParameter("@pass", u.Pass));
                command.Parameters.Add(new OleDbParameter("@birthdate", u.Birthdate));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = $"UPDATE [User] SET FirstName=@firstName, LastName=@lastName, PhoneNumber=@phoneNumber, Email=@email, Username=@username, Pass=@pass, Birthdate=@birthdate WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@firstName", u.FirstName));
                command.Parameters.Add(new OleDbParameter("@lastName", u.LastName));
                command.Parameters.Add(new OleDbParameter("@phoneNumber", u.PhoneNumber));
                command.Parameters.Add(new OleDbParameter("@email", u.Email));
                command.Parameters.Add(new OleDbParameter("@username", u.Username));
                command.Parameters.Add(new OleDbParameter("@pass", u.Pass));
                command.Parameters.Add(new OleDbParameter("@birthdate", u.Birthdate));
                command.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }
    }
}
