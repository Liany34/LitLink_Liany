using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GenreDB : BaseDB
    {
        public ListGenre SelectAll()
        {
            command.CommandText = $"SELECT * FROM Genre";
            ListGenre groupList = new ListGenre(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Genre g = entity as Genre;
            g.Name = reader["name"].ToString();
            base.CreateModel(entity);
            return g;
        }
        public override BaseEntity NewEntity()
        {
            return new Genre();
        }
        static private ListGenre list = new ListGenre();

        public static Genre SelectById(int id)
        {
            GenreDB db = new GenreDB();
            list = db.SelectAll();

            Genre g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Genre g = entity as Genre;
            if (g != null)
            {
                string sqlStr = $"DELETE FROM Genre WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", g.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Genre g = entity as Genre;
            if (g != null)
            {
                string sqlStr = $"Insert INTO Genre (Name) VALUES (@name)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@name", g.Name));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Genre g = entity as Genre;
            if (g != null)
            {
                string sqlStr = $"UPDATE Genre SET Name=@name WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@name", g.Name));
                command.Parameters.Add(new OleDbParameter("@id", g.Id));
            }
        }
    }
}
