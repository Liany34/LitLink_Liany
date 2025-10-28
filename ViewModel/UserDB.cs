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
    }
}
