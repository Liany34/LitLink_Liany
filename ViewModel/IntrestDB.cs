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
    }
}
