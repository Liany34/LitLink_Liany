using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PermissionDB : BaseDB
    {
        public ListPermission SelectAll()
        {
            command.CommandText = $"SELECT * FROM Permission";
            ListPermission groupList = new ListPermission(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Permission p = entity as Permission;
            p.Name = reader["name"].ToString();
            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Permission();
        }
        static private ListPermission list = new ListPermission();

        public static Permission SelectById(int id)
        {
            PermissionDB db = new PermissionDB();
            list = db.SelectAll();

            Permission g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
