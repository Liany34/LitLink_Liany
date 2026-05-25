using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Genre_ReaderDB : BaseDB
    {
        public ListGenre_Reader SelectAll()
        {
            command.CommandText = $"SELECT * FROM Genre_Reader";
            ListGenre_Reader irList = new ListGenre_Reader(base.Select());
            return irList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Genre_Reader ir = entity as Genre_Reader;
            ir.IdReader = ReaderDB.SelectById((int)reader["idReader"]);
            ir.IdGenre = GenreDB.SelectById((int)reader["idGenre"]);
            base.CreateModel(entity);
            return ir;
        }
        public override BaseEntity NewEntity()
        {
            return new Genre_Reader();
        }
        static private ListGenre_Reader list = new ListGenre_Reader();
        public static Genre_Reader SelectById(int id)
        {
            Genre_ReaderDB db = new Genre_ReaderDB();
            list = db.SelectAll();

            Genre_Reader g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Genre_Reader ir = entity as Genre_Reader;
            if (ir != null)
            {
                string sqlStr = $"DELETE FROM Genre_Reader WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", ir.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Genre_Reader ir = entity as Genre_Reader;
            if (ir != null)
            {
                string sqlStr = $"Insert INTO Genre_Reader (IdReader, IdGenre) VALUES (@idReader, @idGenre)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idReader", ir.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@idGenre", ir.IdGenre.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Genre_Reader ir = entity as Genre_Reader;
            if (ir != null)
            {
                string sqlStr = $"UPDATE Genre_Reader SET idReader=@IdReader, idGenre=@IdGenre WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IdReader", ir.IdReader.Id));
                command.Parameters.Add(new OleDbParameter("@IdGenre", ir.IdGenre.Id));
                command.Parameters.Add(new OleDbParameter("@id", ir.Id));
            }
        }
    }
}
