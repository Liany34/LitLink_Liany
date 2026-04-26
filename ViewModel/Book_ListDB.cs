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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_List bl = entity as Book_List;
            if (bl != null)
            {
                string sqlStr = $"DELETE FROM Book_List WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", bl.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_List bl = entity as Book_List;
            if (bl != null)
            {
                string sqlStr = $"Insert INTO Book_List (IdReader, ListName) VALUES (@idReader, @listName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idReader", bl.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@listName", bl.ListName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Book_List bl = entity as Book_List;
            if (bl != null)
            {
                string sqlStr = $"UPDATE Book_List SET idReader=@IdReader, listName=@ListName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IdReader", bl.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@ListName", bl.ListName));
                command.Parameters.Add(new OleDbParameter("@id", bl.Id));
            }
        }
    }
}
