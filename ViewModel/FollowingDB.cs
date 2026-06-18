using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FollowingDB : BaseDB
    {
        public ListFollowing SelectAll()
        {
            command.CommandText = $"SELECT * FROM Following";
            ListFollowing fList = new ListFollowing(base.Select());
            return fList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Following f = entity as Following;
            int readerId = Convert.ToInt32(reader["idReader"]);
            Reader r = ReaderDB.SelectById(readerId);
            if (r != null)
                f.IdReader = r;
            else
                f.IdReader = new Reader { Id = readerId };
            int authorId = Convert.ToInt32(reader["idAuthor"]);
            Author a = AuthorDB.SelectById(authorId);
            if (a != null)
                f.IdAuthor = a;
            else
                f.IdAuthor = new Author { Id = authorId };
            base.CreateModel(entity);
            return f;
        }
        public override BaseEntity NewEntity()
        {
            return new Following();
        }
        static private ListFollowing list = new ListFollowing();
        public static Following SelectById(int id)
        {
            FollowingDB db = new FollowingDB();
            if (list.Count == 0)
            {
                list = db.SelectAll();
            }

            Following f = list.Find(item => item.Id == id);
            return f;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Following f = entity as Following;
            if (f != null)
            {
                string sqlStr = $"DELETE FROM Following WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", f.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Following  f = entity as Following;
            if (f != null)
            {
                string sqlStr = $"INSERT INTO Following (IdReader, IdAuthor) VALUES (@idReader, @idAuthor)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idReader", f.IdReader.Id));
                cmd.Parameters.Add(new OleDbParameter("@idAuthor", f.IdAuthor.Id));
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Following f = entity as Following;
            if (f != null)
            {
                string sqlStr = $"UPDATE Following SET idReader=@idReader, idAuthor=@idAuthor WHERE id=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idReader", f.IdReader.Id));
                cmd.Parameters.Add(new OleDbParameter("@idAuthor", f.IdAuthor.Id));
                cmd.Parameters.Add(new OleDbParameter("@id", f.Id));
            }
        }
    }
}
