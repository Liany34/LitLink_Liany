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
            command.CommandText = $"SELECT \r\nFROM   Series_Detail";
            ListSeries_Detail sdList = new ListSeries_Detail(base.Select());
            return sdList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Series_Detail sd = entity as Series_Detail;
            sd.IdSeries = Book_SeriesDB.SelectById((int)reader["idSeries"]);
            sd.IdBook = BookDB.SelectById((int)reader["idBook"]);
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
            list = db.SelectAll();

            Series_Detail g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Series_Detail sd = entity as Series_Detail;
            if(sd != null)
            {
                string sqlStr = $"DELETE FROM Series_Detail WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", sd.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Series_Detail sd = entity as Series_Detail;
            if (sd != null)
            {
                string sqlStr = $"Insert INTO Series_Detail (IdSeries, IdBook) VALUES (@idSeries, @idBook)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idSeries", sd.IdSeries.Id));
                command.Parameters.Add(new OleDbParameter("@idBook", sd.IdBook.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Series_Detail sd = entity as Series_Detail;
            if (sd != null)
            {
                string sqlStr = $"UPDATE Series_Detail SET IdSeries=@idSeries, IdBook=@idBook WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idSeries", sd.IdSeries.Id));
                command.Parameters.Add(new OleDbParameter("@idBook", sd.IdBook.Id));
                command.Parameters.Add(new OleDbParameter("@id", sd.Id));
            }
        }
    }
}
