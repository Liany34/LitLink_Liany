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
            command.CommandText = $"SELECT [User].* FROM  [User]";
            ListUser uList = new ListUser(base.Select());
            return uList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            User u = entity as User;
            u.FirstName = reader["firstName"].ToString();
            u.LastName = reader["lastName"].ToString();
            u.PhoneNumber = reader["phoneNumber"].ToString();
            u.Email = reader["email"].ToString();
            u.Username = reader["username"].ToString();
            u.Pass = reader["pass"].ToString();
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
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = $"UPDATE [User] SET FirstName=@firstName, LastName=@lastName, PhoneNumber=@phoneNumber, Email=@email, Username=@username, Pass=@pass WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@firstName", u.FirstName));
                command.Parameters.Add(new OleDbParameter("@lastName", u.LastName));
                command.Parameters.Add(new OleDbParameter("@phoneNumber", u.PhoneNumber));
                command.Parameters.Add(new OleDbParameter("@email", u.Email));
                command.Parameters.Add(new OleDbParameter("@username", u.Username));
                command.Parameters.Add(new OleDbParameter("@pass", u.Pass));
                command.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }
    }
}
