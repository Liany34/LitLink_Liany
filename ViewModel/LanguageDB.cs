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
            if (list.Count == 0)
            {
                list = db.SelectAll();
            }

            Language g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Language l = entity as Language;
            if (l != null)
            {
                string sqlStr = $"DELETE FROM [Language] WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", l.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Language l = entity as Language;
            if (l != null)
            {
                string sqlStr = $"INSERT INTO [Language] ([Name]) VALUES (@name)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@name", l.Name));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Language l = entity as Language;
            if (l != null)
            {
                string sqlStr = $"UPDATE [Language] SET [Name]=@name WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@name", l.Name));
                cmd.Parameters.Add(new OleDbParameter("@id", l.Id));
            }
        }
    }
}
