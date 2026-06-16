using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

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
            if (reader["publicationDate"] != DBNull.Value)
                b.PublicationDate = Convert.ToDateTime(reader["publicationDate"]).Date;
            else
                b.PublicationDate = null;
            if (reader["price"] != DBNull.Value)
                b.Price = int.Parse(reader["price"].ToString());
            else
                b.Price = null;
            b.Information = reader["information"].ToString();
            int authorId = Convert.ToInt32(reader["idAuthor"]);
            Author a = AuthorDB.SelectById(authorId);
            if (a != null)
                b.IdAuthor = a;
            else
                b.IdAuthor = new Author { Id = authorId };
            int languageId = Convert.ToInt32(reader["idLanguage"]);
            Language l = LanguageDB.SelectById(languageId);
            if (l != null)
                b.IdLanguage = l;
            else
                b.IdLanguage = new Language { Id = languageId };
            if (reader["bookLink"] != DBNull.Value)
                b.BookLink = reader["bookLink"].ToString();
            else
                b.BookLink = null;
            b.IsFlaged = (bool)reader["isFlaged"];

            string savedPicturePath = reader["coverPath"] == DBNull.Value
            ? ""
            : reader["coverPath"].ToString();

            if (string.IsNullOrWhiteSpace(savedPicturePath))
            {
                b.Cover = null;
                b.CoverPath = null;
            }
            else
            {
                string fileName = System.IO.Path.GetFileName(savedPicturePath);

                string fullPath = System.IO.Path.Combine(BaseDB.Path(), "Covers", fileName);

                b.CoverPath = fileName;

                if (File.Exists(fullPath))
                {
                    b.Cover = ImageToBase64Converter.ImageToBase64(fullPath);
                }
                else
                {
                    b.Cover = null;
                    System.Diagnostics.Debug.WriteLine("Book cover not found: " + fullPath);
                }
            }

            //if (reader["cover"] == DBNull.Value)
            //{
            //    b.Cover = reader["cover"]?.ToString() ?? "";
            //    b.CoverPath = null;
            //}
            //else
            //{
            //    b.CoverPath = Path() + "\\Covers\\" + reader["coverPath"].ToString();
            //    string fileName = b.CoverPath;
            //    if (!string.IsNullOrEmpty(fileName))
            //    {
            //        string base64Result = ImageToBase64Converter.ImageToBase64(fileName);

            //        if (!string.IsNullOrEmpty(base64Result))
            //        {
            //            b.Cover = base64Result;
            //        }
            //        else
            //        {
            //            b.Cover = "Missing resource" + fileName;
            //        }
            //    }
            //}

            //string fileName = reader["cover"]?.ToString();

            //string imagePath = System.IO.Path.Combine(
            //    @"C:\Users\yahal\source\repos\Liany34\LitLink_Liany\ViewModel\Covers",
            //    fileName
            //);

            //Console.WriteLine("fileName = " + fileName);
            //Console.WriteLine("imagePath = " + imagePath);
            //Console.WriteLine("exists = " + File.Exists(imagePath));

            //if (File.Exists(imagePath))
            //{
            //    string base64String = ImageToBase64Converter.ImageToBase64(imagePath);
            //    b.Cover = base64String;
            //}
            //else
            //{
            //    b.Cover = null;
            //}

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

            if (b == null)
                return null;

            return b.Cover;
        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book b = entity as Book;
            if (b != null)
            {
                string sqlStr = $"DELETE FROM Book WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", b.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book b = entity as Book;
            if (b != null)
            {
                string sqlStr = $"Insert INTO Book (BookName, PublicationDate, Price, IdAuthor, IdLanguage, IsFlaged, Information, Cover, CoverPath, BookLink) VALUES (@bookName, @publicationDate, @price, @idAuthor, @idLanguage, @isFlaged, @information, @cover, @coverPath, @bookLink)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@bookName", b.BookName));
                if (b.PublicationDate.HasValue)
                    cmd.Parameters.Add("@publicationDate", OleDbType.Date).Value = b.PublicationDate.Value.Date;
                else
                    cmd.Parameters.Add("@publicationDate", OleDbType.Date).Value = DBNull.Value;
                if (b.Price.HasValue)
                    cmd.Parameters.Add("@price", OleDbType.Double).Value = b.Price.Value;
                else
                    cmd.Parameters.Add("@price", OleDbType.Double).Value = DBNull.Value;
                cmd.Parameters.Add(new OleDbParameter("@idAuthor", b.IdAuthor.Id));
                cmd.Parameters.Add(new OleDbParameter("@idLanguage", b.IdLanguage.Id));
                cmd.Parameters.Add(new OleDbParameter("@isFlaged", b.IsFlaged));
                cmd.Parameters.Add(new OleDbParameter("@information", b.Information));
                cmd.Parameters.Add(new OleDbParameter("@cover", !string.IsNullOrEmpty(b.Cover) ? b.Cover : (object)DBNull.Value));
                cmd.Parameters.Add(new OleDbParameter("@coverPath", !string.IsNullOrEmpty(b.CoverPath) ? b.CoverPath : (object)DBNull.Value));
                if (b.BookLink != null)
                    cmd.Parameters.Add("@bookLink", OleDbType.VarChar).Value = b.BookLink;
                else
                    cmd.Parameters.Add("@bookLink", OleDbType.VarChar).Value = DBNull.Value;
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book b = entity as Book;

            if (b != null)
            {
                string sqlStr =
                    "UPDATE Book SET " +
                    "BookName=@bookName, " +
                    "PublicationDate=@publicationDate, " +
                    "Price=@price, " +
                    "IdAuthor=@idAuthor, " +
                    "IdLanguage=@idLanguage, " +
                    "IsFlaged=@isFlaged, " +
                    "Information=@information, " +
                    "BookLink=@bookLink, " +
                    "CoverPath=@coverPath " +
                    "WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new OleDbParameter("@bookName", b.BookName));

                if (b.PublicationDate.HasValue)
                    cmd.Parameters.Add("@publicationDate", OleDbType.Date).Value = b.PublicationDate.Value.Date;
                else
                    cmd.Parameters.Add("@publicationDate", OleDbType.Date).Value = DBNull.Value;

                if (b.Price.HasValue)
                    cmd.Parameters.Add("@price", OleDbType.Double).Value = b.Price.Value;
                else
                    cmd.Parameters.Add("@price", OleDbType.Double).Value = DBNull.Value;

                cmd.Parameters.Add(new OleDbParameter("@idAuthor", b.IdAuthor.Id));
                cmd.Parameters.Add(new OleDbParameter("@idLanguage", b.IdLanguage.Id));
                cmd.Parameters.Add(new OleDbParameter("@isFlaged", b.IsFlaged));
                cmd.Parameters.Add(new OleDbParameter("@information", b.Information));

                if (!string.IsNullOrWhiteSpace(b.BookLink))
                    cmd.Parameters.Add("@bookLink", OleDbType.VarChar).Value = b.BookLink;
                else
                    cmd.Parameters.Add("@bookLink", OleDbType.VarChar).Value = DBNull.Value;

                string coverFileName = string.IsNullOrEmpty(b.CoverPath)
                    ? null
                    : System.IO.Path.GetFileName(b.CoverPath);

                cmd.Parameters.Add(new OleDbParameter("@coverPath",
                    !string.IsNullOrEmpty(coverFileName) ? coverFileName : (object)DBNull.Value));

                cmd.Parameters.Add(new OleDbParameter("@id", b.Id));
            }
        }
    }
}