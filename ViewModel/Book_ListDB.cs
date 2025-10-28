using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Book_ListDB : BaseDB
    {
        public ListBook_List SelectAll()
        {
            command.CommandText = $"SELECT * FROM Book_List";
            ListBook_List blList = new ListBook_List(base.Select());
            return blList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Book_List bl = entity as Book_List;
            bl.IdReader = ReaderDB.SelectById((int)reader["idReader"]);
            bl.ListName = reader["listName"].ToString();
            bl.IsPublic = (bool)reader["isPublic"];
            base.CreateModel(entity);
            return bl;
        }
        public override BaseEntity NewEntity()
        {
            return new Book_List();
        }
        static private ListBook_List list = new ListBook_List();
        public static Book_List SelectById(int id)
        {
            Book_ListDB db = new Book_ListDB();
            list = db.SelectAll();

            Book_List g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
