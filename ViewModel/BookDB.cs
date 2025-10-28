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
            b.PublicationDate = DateTime.Parse(reader["publicationDate"].ToString());
            b.Price = int.Parse(reader["price"].ToString());
            b.IdAuthor = AuthorDB.SelectById((int)reader["idAuthor"]);
            b.IdGenre = GenreDB.SelectById((int)reader["idGenre"]);
            b.Discount = (bool)reader["discount"];
            b.Information = reader["information"].ToString();
            b.Cover = reader["cover"].ToString();
            b.Language = LanguageDB.SelectById((int)reader["idLanguage"]);
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
    }
}
