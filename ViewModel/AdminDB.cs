using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AdminDB : UserDB
    {
        public ListAdmin SelectAll()
        {
            command.CommandText = $"SELECT [User].id, [User].firstName, [User].lastName, [User].phoneNumber, [User].email, [User].username, [User].birthdate, [User].picture, [User].pass " +
                $"FROM ([User] INNER JOIN [Admin] ON [User].id = [Admin].id)";
            ListAdmin aList = new ListAdmin(base.Select());
            return aList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Admin a = entity as Admin;
            base.CreateModel(entity);
            return a;
        }
        public override BaseEntity NewEntity()
        {
            return new Admin();
        }
        static private ListAdmin list = new ListAdmin();
        public static Admin SelectById(int id)
        {
            AdminDB db = new AdminDB();
            list = db.SelectAll();

            Admin g = list.Find(item => item.Id == id);
            return g;
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin a = entity as Admin;
            if (a != null)
            {
                string sqlStr = $"INSERT INTO Admin (Id) VALUES (@id)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin a = entity as Admin;
            if (a != null)
            {
                string sqlStr = $"DELETE FROM Admin WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
        public override void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
            }
        }
    }
}
