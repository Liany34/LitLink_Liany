using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class IntrestDB : BaseDB
    {
        public ListIntrest SelectAll()
        {
            command.CommandText = $"SELECT * FROM Intrest";
            ListIntrest groupList = new ListIntrest(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Intrest i = entity as Intrest;
            i.Name = reader["name"].ToString();
            base.CreateModel(entity);
            return i;
        }
        public override BaseEntity NewEntity()
        {
            return new Intrest();
        }
        static private ListIntrest list = new ListIntrest();

        public static Intrest SelectById(int id)
        {
            IntrestDB db = new IntrestDB();
            list = db.SelectAll();

            Intrest g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Intrest i = entity as Intrest;
            if (i != null)
            {
                string sqlStr = $"DELETE FROM Intrest WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", i.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Intrest i = entity as Intrest;
            if (i != null)
            {
                string sqlStr = $"Insert INTO Intrest (Name) VALUES (@name)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@name", i.Name));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Intrest i = entity as Intrest;
            if (i != null)
            {
                string sqlStr = $"UPDATE Intrest SET Name=@name WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@name", i.Name));
                command.Parameters.Add(new OleDbParameter("@id", i.Id));
            }
        }
    }
}
