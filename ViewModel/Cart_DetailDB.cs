using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Cart_DetailDB : BaseDB
    {
        public ListCart_Detail SelectAll()
        {
            command.CommandText = $"SELECT * FROM Cart_Detail";
            ListCart_Detail ctList = new ListCart_Detail(base.Select());
            return ctList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Cart_Detail cd = entity as Cart_Detail;
            cd.IdCart = CartDB.SelectById((int)reader["idCart"]);
            cd.IdBook = BookDB.SelectById((int)reader["idBook"]);
            base.CreateModel(entity);
            return cd;
        }
        public override BaseEntity NewEntity()
        {
            return new Cart_Detail();
        }
        static private ListCart_Detail list = new ListCart_Detail();
        public static Cart_Detail SelectById(int id)
        {
            Cart_DetailDB db = new Cart_DetailDB();
            list = db.SelectAll();

            Cart_Detail cd = list.Find(item => item.Id == id);
            return cd;
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart_Detail cd = entity as Cart_Detail;
            if (cd != null)
            {
                string sqlStr = $"UPDATE Cart_Detail SET IdCart=@idCart, IdBook=@idBook WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idCart", cd.IdCart.Id));
                command.Parameters.Add(new OleDbParameter("@idBook", cd.IdBook.Id));
                command.Parameters.Add(new OleDbParameter("@id", cd.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart_Detail cd = entity as Cart_Detail;
            if (cd != null)
            {
                string sqlStr = $"INSERT INTO Cart_Detail (IdCart, IdBook) VALUES (@idCart, @idBook)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idCart", cd.IdCart.Id));
                command.Parameters.Add(new OleDbParameter("@idBook", cd.IdBook.Id));
            }
        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart_Detail cd = entity as Cart_Detail;
            if (cd != null)
            {
                string sqlStr = $"DELETE FROM Cart_Detail WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", cd.Id));
            }
        }
    }
}
