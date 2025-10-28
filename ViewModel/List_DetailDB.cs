﻿using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class List_DetailDB : BaseDB
    {
        public ListList_Detail SelectAll()
        {
            command.CommandText = $"SELECT * FROM List_Detail";
            ListList_Detail ldList = new ListList_Detail(base.Select());
            return ldList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            List_Detail ld = entity as List_Detail;
            ld.IdList = Book_ListDB.SelectById((int)reader["idList"]);
            ld.IdBook = BookDB.SelectById((int)reader["idBook"]);
            base.CreateModel(entity);
            return ld;
        }
        public override BaseEntity NewEntity()
        {
            return new List_Detail();
        }
        static private ListList_Detail list = new ListList_Detail();
        public static List_Detail SelectById(int id)
        {
            List_DetailDB db = new List_DetailDB();
            list = db.SelectAll();

            List_Detail g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
