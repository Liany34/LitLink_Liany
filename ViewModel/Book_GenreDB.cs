using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Book_GenreDB : BaseDB
    {
        public ListBook_Genre SelectAll()
        {
            command.CommandText = $"SELECT * FROM Book_Genre";
            ListBook_Genre bgList = new ListBook_Genre(base.Select());
            return bgList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Book_Genre bg = entity as Book_Genre;
            bg.IdGenre = GenreDB.SelectById((int)(reader["idGenre"]));
            bg.IdBook = BookDB.SelectById((int)(reader["idBook"]));
            base.CreateModel(entity);
            return bg;
        }
        public override BaseEntity NewEntity()
        {
            return new Book_Genre();
        }
        static private ListBook_Genre list = new ListBook_Genre();
        public static Book_Genre SelectById(int id)
        {
            Book_GenreDB db = new Book_GenreDB();
            list = db.SelectAll();

            Book_Genre g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_Genre bg = entity as Book_Genre;
            if (bg != null)
            {
                string sqlStr = $"DELETE FROM Book_Genre WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", bg.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_Genre bg = entity as Book_Genre;
            if (bg != null)
            {
                string sqlStr = $"Insert INTO Book_Genre (IdGenre, IdBook) VALUES (@idGenre, @idBook)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idGenre", bg.IdGenre.Id));
                command.Parameters.Add(new OleDbParameter("@idBook", bg.IdBook.Id));
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_Genre bg = entity as Book_Genre;
            if (bg != null)
            {
                string sqlStr = $"UPDATE Book_Genre SET IdGenre=@idGenre, IdBook=@idBook WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idGenre", bg.IdGenre.Id));
                command.Parameters.Add(new OleDbParameter("@idBook", bg.IdBook.Id));
                command.Parameters.Add(new OleDbParameter("@id", bg.Id));
            }
        }
    }
}
