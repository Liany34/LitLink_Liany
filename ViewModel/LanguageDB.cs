using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LanguageDB : BaseDB
    {
        public ListLanguage SelectAll()
        {
            command.CommandText = $"SELECT [Language].*  FROM  [Language]";
            ListLanguage groupList = new ListLanguage(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Language l = entity as Language;
            l.Name = reader["name"].ToString();
            base.CreateModel(entity);
            return l;
        }
        public override BaseEntity NewEntity()
        {
            return new Language();
        }
        static private ListLanguage list = new ListLanguage();

        public static Language SelectById(int id)
        {
            LanguageDB db = new LanguageDB();
            list = db.SelectAll();

            Language g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Language l = entity as Language;
            if (l != null)
            {
                string sqlStr = $"UPDATE [Language] SET Name=@name WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@name", l.Name));
                command.Parameters.Add(new OleDbParameter("@id", l.Id));
            }
        }
    }
}
