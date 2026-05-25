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
            b.Information = reader["information"].ToString();
            int authorId = (int)reader["idAuthor"];
            b.IdAuthor = AuthorDB.SelectById(authorId);
            int languageId = (int)reader["idLanguage"];
            b.IdLanguage = LanguageDB.SelectById(languageId);
            if (reader["bookLink"] != DBNull.Value)
                b.BookLink = reader["bookLink"].ToString();
            else
                b.BookLink = null;
            b.IsFlaged = (bool)reader["isFlaged"];

            string imagePath = Path() + "\\BookCovers\\" + reader["cover"].ToString();
            string base64String = ImageToBase64Converter.ImageToBase64(imagePath);
            b.Cover = base64String;

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
        public string SelectBookCoverByBookID(int id)
        {
            ListBook bList = SelectAll();
            Book b = bList.Find(item => item.Id == id);

            string pic = b.Cover;
            return pic;
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
                string sqlStr = $"Insert INTO Book (BookName, PublicationDate, Price, IdAuthor, IdLanguage, IsFlaged, Information, Cover, BookLink) VALUES (@bookName, @publicationDate, @price, @idAuthor, @idLanguage, @isFlaged, @information, @cover, @bookLink)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@@bookName", b.BookName));
                command.Parameters.Add(new OleDbParameter("@publicationDate", b.PublicationDate));
                command.Parameters.Add(new OleDbParameter("@price", b.Price));
                command.Parameters.Add(new OleDbParameter("@idAuthor", b.IdAuthor.Id));
                command.Parameters.Add(new OleDbParameter("@idLanguage", b.IdLanguage.Id));
                command.Parameters.Add(new OleDbParameter("@isFlaged", b.IsFlaged));
                command.Parameters.Add(new OleDbParameter("@information", b.Information));
                command.Parameters.Add(new OleDbParameter("@cover", b.Cover));
                command.Parameters.Add(new OleDbParameter("@bookLink", b.BookLink));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book b = entity as Book;
            if (b != null)
            {
                string sqlStr = $"UPDATE Book SET bookName=@BookName, publicationDate=@PublicationDate, price=@Price, idAuthor=@IdAuthor, isFlaged=@IsFlaged, information=@Information, cover=@Cover, idLanguage=@IdLanguage, bookLink=@BookLink WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@BookName", b.BookName));
                command.Parameters.Add(new OleDbParameter("@PublicationDate", b.PublicationDate));
                command.Parameters.Add(new OleDbParameter("@Price", b.Price));
                command.Parameters.Add(new OleDbParameter("@IdAuthor", b.IdAuthor.Id));
                command.Parameters.Add(new OleDbParameter("@IsFlaged", b.IsFlaged));
                command.Parameters.Add(new OleDbParameter("@Information", b.Information));
                command.Parameters.Add(new OleDbParameter("@Cover", b.Cover));
                command.Parameters.Add(new OleDbParameter("@IdLanguage", b.IdLanguage.Id));
                command.Parameters.Add(new OleDbParameter("@BookLink", b.BookLink));
                command.Parameters.Add(new OleDbParameter("@id", b.Id));
            }
        }
    }
}
