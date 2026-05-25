using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (reader["validUntil"] != DBNull.Value)
                dc.ValidUntil = DateTime.Parse(reader["validUntil"].ToString());
            else
                dc.ValidUntil = null;
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
            list = db.SelectAll();

            DiscountCodes g = list.Find(item => item.Id == id);
            return g;
        }
      
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DiscountCodes dc = entity as DiscountCodes;
            if (dc != null)
            {
                string sqlStr = $"DELETE FROM DiscountCodes WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", dc.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DiscountCodes dc = entity as DiscountCodes;
            if (dc != null)
            {
                string sqlStr = $"Insert INTO DiscountCodes (CodeText, ValidUntil, Amount, IsActive) VALUES (@codeText, @validUntil, @amount, @isActive)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@codeText", dc.CodeText));
                command.Parameters.Add(new OleDbParameter("@validUntil", dc.ValidUntil));
                command.Parameters.Add(new OleDbParameter("@amount", dc.Amount));
                command.Parameters.Add(new OleDbParameter("@isActive", dc.IsActive));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DiscountCodes dc = entity as DiscountCodes;
            if (dc != null)
            {
                string sqlStr = $"UPDATE DiscountCodes SET CodeText=@CodeText, ValidUntil=@ValidUntil, Amount=@Amount, IsActive=@IsActive WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@CodeText", dc.CodeText));
                command.Parameters.Add(new OleDbParameter("@ValidUntil", dc.ValidUntil));
                command.Parameters.Add(new OleDbParameter("@Amount", dc.Amount));
                command.Parameters.Add(new OleDbParameter("@IsActive", dc.IsActive));
                command.Parameters.Add(new OleDbParameter("@id", dc.Id));
            }
        }
    }
} 
