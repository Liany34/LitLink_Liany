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
            command.CommandText = $"SELECT [User].id, [User].firstName, [User].lastName, [User].phoneNumber, [User].email, [User].username, [User].pass, Reader.nickname, Reader.premiumSubscription, Reader.dateOfBirth " +
                $"FROM ([User] INNER JOIN Reader ON [User].id = Reader.id)";
            ListReader pList = new ListReader(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Reader r = entity as Reader;
            r.Nickname = reader["nickname"].ToString();
            r.PremiumSubscription = (bool)reader["premiumSubscription"];
            r.DateOfBirth = (DateTime)reader["dateOfBirth"];
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
                string sqlStr = $"UPDATE Reader SET Nickname=@penName, Genre=@genre, InformationAboutAuthor=@informationAboutAuthor WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@penName", a.PenName));
                command.Parameters.Add(new OleDbParameter("@genre", a.Genre.Id));
                command.Parameters.Add(new OleDbParameter("@informationAboutAuthor", a.InformationAboutAuthor));
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
        public override void Update(BaseEntity entity)
        {
            Author a = entity as Author;
            if (a != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
    }
}
