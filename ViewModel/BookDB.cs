using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BookDB : BaseDB
    {
        public ListBook SelectAll()
        {
            command.CommandText = $"SELECT * FROM Book";
            ListBook bList = new ListBook(base.Select());
            return bList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Book b = entity as Book;
            b.BookName = reader["bookName"].ToString();
            if(reader["publicationDate"] != DBNull.Value)
                b.PublicationDate = DateTime.Parse(reader["publicationDate"].ToString());
            else
                b.PublicationDate = null;
            if(reader["price"] != DBNull.Value)
                b.Price = int.Parse(reader["price"].ToString());
            else
                b.Price = null;
            b.Discount = (bool)reader["discount"];
            b.Information = reader["information"].ToString();
            b.Cover = reader["cover"].ToString();
            int authorId = (int)reader["idAuthor"];
            b.IdAuthor = AuthorDB.SelectById(authorId);
            int genreId = (int)reader["idgenre"];
            b.IdGenre = GenreDB.SelectById(genreId);
            int languageId = (int)reader["idLanguage"];
            b.IdLanguage = LanguageDB.SelectById(languageId);
            //b.IdAuthor = new Author { Id = (int)reader["idAuthor"], PenName = reader["penName"].ToString() };
            //b.IdGenre = new Genre { Id = (int)reader["idGenre"], Name = reader["name"].ToString() };
            //b.IdLanguage = new Language { Id = (int)reader["idLanguage"], Name = reader["name"].ToString() };
            base.CreateModel(entity);
            return b;
        }
        public override BaseEntity NewEntity()
        {
            return new Book();
        }
        static private ListBook list = new ListBook();
        public static Book SelectById(int id)
        {
            BookDB db = new BookDB();
            list = db.SelectAll();

            Book g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book b = entity as Book;
            if (b != null)
            {
                string sqlStr = $"DELETE FROM Book WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", b.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book b = entity as Book;
            if (b != null)
            {
                string sqlStr = $"Insert INTO Book (BookName, PublicationDate, Price, IdAuthor, IdGenre, Discount, Information, Cover, IdLanguage) VALUES (@bookName, @publicationDate, @price, @idAuthor, @idGenre, @discount, @information, @cover, @idLanguage)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@bookName", b.BookName));
                command.Parameters.Add(new OleDbParameter("@publicationDate", b.PublicationDate));
                command.Parameters.Add(new OleDbParameter("@price", b.Price));
                command.Parameters.Add(new OleDbParameter("@idAuthor", b.IdAuthor.Id));
                command.Parameters.Add(new OleDbParameter("@idGenre", b.IdGenre.Id));
                command.Parameters.Add(new OleDbParameter("@discount", b.Discount));
                command.Parameters.Add(new OleDbParameter("@information", b.Information));
                command.Parameters.Add(new OleDbParameter("@cover", b.Cover));
                command.Parameters.Add(new OleDbParameter("@idLanguage", b.IdLanguage.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book b = entity as Book;
            if (b != null)
            {
                string sqlStr = $"UPDATE Book SET bookName=@BookName, publicationDate=@PublicationDate, price=@Price, idAuthor=@IdAuthor, idGenre=@IdGenre, discount=@Discount, information=@Information, cover=@Cover, idLanguage=@IdLanguage WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@BookName", b.BookName));
                command.Parameters.Add(new OleDbParameter("@PublicationDate", b.PublicationDate));
                command.Parameters.Add(new OleDbParameter("@Price", b.Price));
                command.Parameters.Add(new OleDbParameter("@IdAuthor", b.IdAuthor.Id));
                command.Parameters.Add(new OleDbParameter("@IdGenre", b.IdGenre.Id));
                command.Parameters.Add(new OleDbParameter("@Discount", b.Discount));
                command.Parameters.Add(new OleDbParameter("@Information", b.Information));
                command.Parameters.Add(new OleDbParameter("@Cover", b.Cover));
                command.Parameters.Add(new OleDbParameter("@IdLanguage", b.IdLanguage.Id));
                command.Parameters.Add(new OleDbParameter("@id", b.Id));
            }
        }
    }
}
