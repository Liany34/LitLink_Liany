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
            command.CommandText = "SELECT * From Cart";
            ListCart groupList = new ListCart(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Cart c = entity as Cart;
            int readerId = Convert.ToInt32(reader["idReader"]);
            Reader r = ReaderDB.SelectById(readerId);
            if (r != null)
                c.IdReader = r;
            else
                c.IdReader = new Reader { Id = readerId };
            if (reader["discountCode"] != DBNull.Value)
                c.DiscountCode = reader["discountCode"].ToString();
            else
                c.DiscountCode = null;
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

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart c = entity as Cart;
            if (c != null)
            {
                string sqlStr = $"INSERT INTO Cart (IdReader, DiscountCode) VALUES (@idReader, @discountCode)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idReader", c.IdReader.Id));
                if (c.DiscountCode != null)
                    cmd.Parameters.Add("@discountCode", OleDbType.VarChar).Value = c.DiscountCode;
                else
                    cmd.Parameters.Add("@discountCode", OleDbType.VarChar).Value = DBNull.Value;
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Cart c = entity as Cart;
            if (c != null)
            {
                string sqlStr = $"UPDATE Cart SET IdReader=@idReader, DiscountCode=@discountCode WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@idReader", c.IdReader.Id));
                if (c.DiscountCode != null)
                    cmd.Parameters.Add("@discountCode", OleDbType.VarChar).Value = c.DiscountCode;
                else
                    cmd.Parameters.Add("@discountCode", OleDbType.VarChar).Value = DBNull.Value;
                cmd.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}