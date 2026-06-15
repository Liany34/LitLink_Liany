using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            cd.IdCart = new Cart
            {
                Id = Convert.ToInt32(reader["idCart"])
            };
            cd.IdBook = new Book
            {
                Id = Convert.ToInt32(reader["idBook"])
            };
            if (reader["purchaseDate"] != DBNull.Value)
                cd.PurchaseDate = Convert.ToDateTime(reader["purchaseDate"]).Date;
            else
                 cd.PurchaseDate = null;
            cd.PurchasePrice = (int)reader["purchasePrice"];
            cd.IsPurchased = (bool)reader["isPurchased"];
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
                string sqlStr = $"UPDATE Cart_Detail SET IdCart=@idCart, IdBook=@idBook, PurchasePrice=@purchasePrice, PurchaseDate=@purchaseDate, IsPurchased=@isPurchased WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idCart", cd.IdCart.Id));
                cmd.Parameters.Add(new OleDbParameter("@idBook", cd.IdBook.Id));
                cmd.Parameters.Add(new OleDbParameter("@purchasePrice", cd.PurchasePrice));
                if (cd.PurchaseDate.HasValue)
                    cmd.Parameters.Add("@purchaseDate", OleDbType.Date).Value = cd.PurchaseDate.Value.Date;
                else
                    cmd.Parameters.Add("@purchaseDate", OleDbType.Date).Value = DBNull.Value;
                cmd.Parameters.Add(new OleDbParameter("@isPurchased", cd.IsPurchased));
                cmd.Parameters.Add(new OleDbParameter("@id", cd.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart_Detail cd = entity as Cart_Detail;
            if (cd != null)
            {
                string sqlStr = $"INSERT INTO Cart_Detail (IdCart, IdBook, PurchasePrice, PurchaseDate, IsPurchased) VALUES (@idCart, @idBook, @purchasePrice, @purchaseDate, @isPurchased)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idCart", cd.IdCart.Id));
                cmd.Parameters.Add(new OleDbParameter("@idBook", cd.IdBook.Id));
                cmd.Parameters.Add(new OleDbParameter("@purchasePrice", cd.PurchasePrice));
                if (cd.PurchaseDate.HasValue)
                    cmd.Parameters.Add("@purchaseDate", OleDbType.Date).Value = cd.PurchaseDate.Value.Date;
                else
                    cmd.Parameters.Add("@purchaseDate", OleDbType.Date).Value = DBNull.Value;
                cmd.Parameters.Add(new OleDbParameter("@isPurchased", cd.IsPurchased));
            }
        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart_Detail cd = entity as Cart_Detail;
            if (cd != null)
            {
                string sqlStr = $"DELETE FROM Cart_Detail WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", cd.Id));
            }
        }
    }
}
