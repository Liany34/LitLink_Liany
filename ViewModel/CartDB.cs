using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CartDB : BaseDB
    {
        public ListCart SelectAll()
        {
            command.CommandText = "SELECT * FROM Cart";
            ListCart groupList = new ListCart(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Cart c = entity as Cart;
            c.IdReader = ReaderDB.SelectById((int)reader["idReader"]);
            c.DiscountCode = reader["discountCode"].ToString();
            c.TotalPrice = Convert.ToDouble(reader["totalPrice"]);
            base.CreateModel(entity);
            return c;
        }

        public override BaseEntity NewEntity()
        {
            return new Cart();
        }
        static private ListCart list = new ListCart();


        public static Cart SelectById(int id)
        {
            CartDB db = new CartDB();
            list = db.SelectAll();

            Cart c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart c = entity as Cart;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Cart WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart c = entity as Cart;
            if (c != null)
            {
                string sqlStr = $"Insert INTO Cart (IdReader, DiscountCode, TotalPrice) VALUES (@idReader, @discountCode, @totalPrice)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idReader", c.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@discountCode", c.DiscountCode));
                command.Parameters.Add(new OleDbParameter("@totalPrice", c.TotalPrice));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart c = entity as Cart;
            if (c != null)
            {
                string sqlStr = $"UPDATE Cart SET IdReader=@idReader, DiscountCode=@discountCode, TotalPrice=@totalPrice WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idReader", c.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@discountCode", c.DiscountCode));
                command.Parameters.Add(new OleDbParameter("@totalPrice", c.TotalPrice));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
}
