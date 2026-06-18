using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Series_DetailDB : BaseDB
    {
        public ListSeries_Detail SelectAll()
        {
            command.CommandText = $"SELECT * FROM Series_Detail";
            ListSeries_Detail sdList = new ListSeries_Detail(base.Select());
            return sdList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Series_Detail sd = entity as Series_Detail;
            int seriesId = Convert.ToInt32(reader["idSeries"]);
            Book_Series bs = Book_SeriesDB.SelectById(seriesId);
            if (bs != null)
                sd.IdSeries = bs;
            else
                sd.IdSeries = new Book_Series { Id = seriesId };
            int bookId = Convert.ToInt32(reader["idBook"]);
            Book b = BookDB.SelectById(bookId);
            if (b != null)
                sd.IdBook = b;
            else
                sd.IdBook = new Book { Id = bookId };
            sd.Number = (int)reader["number"];
            base.CreateModel(entity);
            return sd;
        }
        public override BaseEntity NewEntity()
        {
            return new Series_Detail();
        }
        static private ListSeries_Detail list = new ListSeries_Detail();
        public static Series_Detail SelectById(int id)
        {
            Series_DetailDB db = new Series_DetailDB();
            if (list.Count == 0)
            {
                list = db.SelectAll();
            }

            Series_Detail g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Series_Detail sd = entity as Series_Detail;
            if(sd != null)
            {
                string sqlStr = $"DELETE FROM Series_Detail WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", sd.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Series_Detail sd = entity as Series_Detail;
            if (sd != null)
            {
                string sqlStr = $"INSERT INTO Series_Detail (IdSeries, IdBook, [Number]) VALUES (@idSeries, @idBook, @number)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idSeries", sd.IdSeries.Id));
                cmd.Parameters.Add(new OleDbParameter("@idBook", sd.IdBook.Id));
                cmd.Parameters.Add(new OleDbParameter("@number", sd.Number));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Series_Detail sd = entity as Series_Detail;
            if (sd != null)
            {
                string sqlStr = $"UPDATE Series_Detail SET IdSeries=@idSeries, IdBook=@idBook, [Number]=@number WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idSeries", sd.IdSeries.Id));
                cmd.Parameters.Add(new OleDbParameter("@idBook", sd.IdBook.Id));
                cmd.Parameters.Add(new OleDbParameter("@number", sd.Number));
                cmd.Parameters.Add(new OleDbParameter("@id", sd.Id));
            }
        }
    }
}
