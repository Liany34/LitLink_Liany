using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ViewModel
{
    public class DiscountCodesDB : BaseDB
    {
        public ListDiscountCodes SelectAll()
        {
            command.CommandText = $"SELECT * FROM DiscountCodes";
            ListDiscountCodes dcList = new ListDiscountCodes(base.Select());
            return dcList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            DiscountCodes dc = entity as DiscountCodes;
            dc.CodeText = reader["codeText"].ToString();
            dc.ValidUntil = Convert.ToDateTime(reader["validUntil"]).Date;
            dc.Amount = int.Parse(reader["amount"].ToString());
            dc.IsActive = (bool)reader["isActive"];
       
            base.CreateModel(entity);
            return dc;
        }
        public override BaseEntity NewEntity()
        {
            return new DiscountCodes();
        }
        static private ListDiscountCodes list = new ListDiscountCodes();
        public static DiscountCodes SelectById(int id)
        {
            DiscountCodesDB db = new DiscountCodesDB();
            if (list.Count == 0)
            {
                list = db.SelectAll();
            }

            DiscountCodes g = list.Find(item => item.Id == id);
            return g;
        }
      
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DiscountCodes dc = entity as DiscountCodes;
            if (dc != null)
            {
                string sqlStr = $"DELETE FROM DiscountCodes WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", dc.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DiscountCodes dc = entity as DiscountCodes;
            if (dc != null)
            {
                string sqlStr = $"INSERT INTO DiscountCodes (CodeText, ValidUntil, Amount, IsActive) VALUES (@codeText, @validUntil, @amount, @isActive)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@codeText", dc.CodeText));
                cmd.Parameters.Add("@validUntil", OleDbType.Date).Value = dc.ValidUntil.Date;
                cmd.Parameters.Add(new OleDbParameter("@amount", dc.Amount));
                cmd.Parameters.Add(new OleDbParameter("@isActive", dc.IsActive));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DiscountCodes dc = entity as DiscountCodes;
            if (dc != null)
            {
                string sqlStr = $"UPDATE DiscountCodes SET CodeText=@codeText, ValidUntil=@validUntil, Amount=@amount, IsActive=@isActive WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@codeText", dc.CodeText));
                cmd.Parameters.Add("@validUntil", OleDbType.Date).Value = dc.ValidUntil.Date;
                cmd.Parameters.Add(new OleDbParameter("@amount", dc.Amount));
                cmd.Parameters.Add(new OleDbParameter("@isActive", dc.IsActive));
                cmd.Parameters.Add(new OleDbParameter("@id", dc.Id));
            }
        }
    }
} 
