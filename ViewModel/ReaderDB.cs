using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ReaderDB : UserDB
    {
        public ListReader SelectAll()
        {
            command.CommandText = $"SELECT [User].id, [User].firstName, [User].lastName, [User].phoneNumber, [User].email, [User].username, [User].pass, [User].birthdate, Reader.nickname, Reader.premiumSubscription\r\nFROM   (Reader INNER JOIN\r\n             [User] ON Reader.id = [User].id)";
            ListReader pList = new ListReader(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Reader r = entity as Reader;
            r.Nickname = reader["nickname"].ToString();
            r.PremiumSubscription = (bool)reader["premiumSubscription"];
            base.CreateModel(entity);
            return r;
        }
        public override BaseEntity NewEntity()
        {
            return new Reader();
        }
        static private ListReader list = new ListReader();
        public static Reader SelectById(int id)
        {
            ReaderDB db = new ReaderDB();
            list = db.SelectAll();

            Reader g = list.Find(item => item.Id == id);
            return g;
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Reader r = entity as Reader;
            if (r != null)
            {
                string sqlStr = $"UPDATE Reader SET Nickname=@nickname, PremiumSubscription=@premiumSubscription WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@nickname", r.Nickname));
                command.Parameters.Add(new OleDbParameter("@premiumSubsciption", r.PremiumSubscription));
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }
        public override void Update(BaseEntity entity)
        {
            Reader r = entity as Reader;
            if (r != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Reader r = entity as Reader;
            if (r != null)
            {
                string sqlStr = $"Insert INTO Reader (Id, Nickname, PremiumSubscription) VALUES (@id, @nickname, @premiumSubscription)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
                command.Parameters.Add(new OleDbParameter("@nickname", r.Nickname ));
                command.Parameters.Add(new OleDbParameter("@premiumSubscription", r.PremiumSubscription));
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
            Reader r = entity as Reader;
            if (r != null)
            {
                string sqlStr = $"DELETE FROM Reader WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
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
