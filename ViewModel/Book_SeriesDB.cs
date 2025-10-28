using Model;
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
            list = db.SelectAll();

            Book_Series g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
