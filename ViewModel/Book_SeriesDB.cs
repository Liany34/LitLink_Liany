using Model;
using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Book_SeriesDB : BaseDB
    {
        public ListBook_Series SelectAll()
        {
            command.CommandText = $"SELECT * FROM Book_Series";
            ListBook_Series bsList = new ListBook_Series(base.Select());
            return bsList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Book_Series bs = entity as Book_Series;
            bs.NameSeries = reader["nameSeries"].ToString();
            int userId = Convert.ToInt32(reader["idUser"]);
            User u = UserDB.SelectById(userId);
            if (u != null)
                bs.IdUser = u;
            else
                bs.IdUser = new User { Id = userId };
            base.CreateModel(entity);
            return bs;
        }
        public override BaseEntity NewEntity()
        {
            return new Book_Series();
        }
        static private ListBook_Series list = new ListBook_Series();
        public static Book_Series SelectById(int id)
        {
            Book_SeriesDB db = new Book_SeriesDB();
            if (list.Count == 0)
            {
                list = db.SelectAll();
            }

            Book_Series g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_Series bs = entity as Book_Series;
            if (bs != null)
            {
                string sqlStr = $"DELETE FROM Book_Series WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", bs.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_Series bs = entity as Book_Series;
            if (bs != null)
            {
                string sqlStr = $"INSERT INTO Book_Series (NameSeries, IdUser) VALUES (@nameSeries, @idUser)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@nameSeries", bs.NameSeries));
                cmd.Parameters.Add(new OleDbParameter("@idUser", bs.IdUser.Id));
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_Series bs = entity as Book_Series;
            if (bs != null)
            {
                string sqlStr = $"UPDATE Book_Series SET nameSeries=@nameSeries, idUser=@idUser WHERE id=@id";
                
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@nameSeries", bs.NameSeries));
                cmd.Parameters.Add(new OleDbParameter("@idUser", bs.IdUser.Id));
                cmd.Parameters.Add(new OleDbParameter("@id", bs.Id));
            }
        }
    }
}
