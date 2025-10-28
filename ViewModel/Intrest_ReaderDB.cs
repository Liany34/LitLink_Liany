﻿using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Intrest_ReaderDB : BaseDB
    {
        public ListIntrest_Reader SelectAll()
        {
            command.CommandText = $"SELECT * FROM Intrest_Reader";
            ListIntrest_Reader irList = new ListIntrest_Reader(base.Select());
            return irList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Intrest_Reader ir = entity as Intrest_Reader;
            ir.IdReader = ReaderDB.SelectById((int)reader["idReader"]);
            ir.IdIntrest = IntrestDB.SelectById((int)reader["idIntrest"]);
            base.CreateModel(entity);
            return ir;
        }
        public override BaseEntity NewEntity()
        {
            return new Intrest_Reader();
        }
        static private ListIntrest_Reader list = new ListIntrest_Reader();
        public static Intrest_Reader SelectById(int id)
        {
            Intrest_ReaderDB db = new Intrest_ReaderDB();
            list = db.SelectAll();

            Intrest_Reader g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
