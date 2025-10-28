﻿using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Permissions_for_AdministratorDB : BaseDB
    {
        public ListPermissions_for_Administrator SelectAll()
        {
            command.CommandText = $"SELECT * FROM Permissions_for_Administrator";
            ListPermissions_for_Administrator paList = new ListPermissions_for_Administrator(base.Select());
            return paList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Permissions_for_Administrator pa = entity as Permissions_for_Administrator;
            pa.IdAdministrator = UserDB.SelectById((int)reader["idAdministrator"]);
            pa.IdPermission = PermissionDB.SelectById((int)reader["idPermission"]);
            base.CreateModel(entity);
            return pa;
        }
        public override BaseEntity NewEntity()
        {
            return new Permissions_for_Administrator();
        }
        static private ListPermissions_for_Administrator list = new ListPermissions_for_Administrator();
        public static Permissions_for_Administrator SelectById(int id)
        {
            Permissions_for_AdministratorDB db = new Permissions_for_AdministratorDB();
            list = db.SelectAll();

            Permissions_for_Administrator g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
