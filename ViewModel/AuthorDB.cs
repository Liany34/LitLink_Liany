using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AuthorDB : UserDB
    {
        public ListAuthor SelectAll()
        {
            command.CommandText = $"SELECT [User].id, [User].firstName, [User].lastName, [User].phoneNumber, [User].email, [User].username, [User].pass, Author.penName, Author.genre, Author.informationAboutAuthor " +
                $"FROM ([User] INNER JOIN Author ON [User].id = Author.id)";
            ListAuthor aList = new ListAuthor(base.Select());
            return aList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Author a = entity as Author;
            a.PenName = reader["penName"].ToString();
            a.Genre = GenreDB.SelectById((int)reader["genre"]);
            a.InformationAboutAuthor = reader["informationAboutAuthor"].ToString();
            base.CreateModel(entity);
            return a;
        }
        public override BaseEntity NewEntity()
        {
            return new Author();
        }
        static private ListAuthor list = new ListAuthor();
        public static Author SelectById(int id)
        {
            AuthorDB db = new AuthorDB();
            list = db.SelectAll();

            Author g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
