using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ReviewsDB : BaseDB
    {
        public ListReviews SelectAll()
        {
            command.CommandText = $"SELECT * FROM Reviews";
            ListReviews reviewsList = new ListReviews(base.Select());
            return reviewsList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Reviews r = entity as Reviews;
            r.Text = reader["text"].ToString();
            r.IdReader = ReaderDB.SelectById((int)(reader["idReader"]));
            r.Stars = (int)(reader["stars"]);
            r.IdBook = BookDB.SelectById((int)(reader["idBook"]));
            base.CreateModel(entity);
            return r;
        }
        public override BaseEntity NewEntity()
        {
            return new Reviews();
        }
        static private ListReviews list = new ListReviews();
        public static Reviews SelectById(int id)
        {
            ReviewsDB db = new ReviewsDB();
            list = db.SelectAll();

            Reviews r = list.Find(item => item.Id == id);
            return r;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Reviews r = entity as Reviews;
            if (r != null)
            {
                string sqlStr = $"DELETE FROM Reviews WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Reviews r = entity as Reviews;
            if (r != null)
            {
                string sqlStr = $"Insert INTO Reviews ([Text], IdReader, Stars, IdBook) VALUES (@text, @idReader, @stars, @idBook)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@text", r.Text));
                command.Parameters.Add(new OleDbParameter("@idReader", r.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@stars", r.Stars));
                command.Parameters.Add(new OleDbParameter("@idBook", r.IdBook.Id));
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Reviews r = entity as Reviews;
            if (r != null)
            {
                string sqlStr = $"UPDATE Reviews SET [Text]=@text, IdReader=@idReader, Stars=@stars, IdBook=@idBook WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@text", r.Text));
                command.Parameters.Add(new OleDbParameter("@idReader", r.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@stars", r.Stars));
                command.Parameters.Add(new OleDbParameter("@idBook", r.IdBook.Id));
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }
    }
}
