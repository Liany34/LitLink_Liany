using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ViewModel
{
    public class AuthorDB : UserDB
    {
        public ListAuthor SelectAll()
        {
            command.CommandText = $"SELECT [User].id, [User].firstName, [User].lastName, [User].phoneNumber, [User].email, [User].username, [User].pass, [User].birthdate, Author.penName, Author.genre, Author.informationAboutAuthor " +
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

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Author a = entity as Author;
            if (a != null)
            {
                string sqlStr = $"UPDATE Author SET PenName=@penName, Genre=@genre, InformationAboutAuthor=@informationAboutAuthor WHERE ID=@id";

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
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Author a = entity as Author;
            if (a != null)
            {
                string sqlStr = $"INSERT INTO Author (Id, PenName, Genre, InformationAboutAuthor) VALUES (@id, @penName, @genre, @informationAboutAuthor)";
                
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
                command.Parameters.Add(new OleDbParameter("@penName", a.PenName));
                command.Parameters.Add(new OleDbParameter("@genre", a.Genre.Id));
                command.Parameters.Add(new OleDbParameter("@informationAboutAuthor", a.InformationAboutAuthor));
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
            Author a = entity as Author;
            if (a != null)
            {
                string sqlStr = $"DELETE FROM Author WHERE ID=@id";
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
