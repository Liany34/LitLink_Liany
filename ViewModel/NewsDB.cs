using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ViewModel
{
    public class NewsDB : BaseDB
    {
        public ListNews SelectAll()
        {
            command.CommandText = $"SELECT * FROM News";
            ListNews newsList = new ListNews(base.Select());
            return newsList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            News n = entity as News;
            n.Content = reader["content"].ToString();
            n.PublishDate = Convert.ToDateTime(reader["publishDate"]).Date;
            n.Titel = reader["titel"].ToString();
            int userId = Convert.ToInt32(reader["idUser"]);
            User u = UserDB.SelectById(userId);
            if (u != null)
                n.IdUser = u;
            else
                n.IdUser = new User { Id = userId };
            base.CreateModel(entity);
            return n;
        }
        public override BaseEntity NewEntity()
        {
            return new News();
        }
        static private ListNews list = new ListNews();
        public static News SelectById(int id)
        {
            NewsDB db = new NewsDB();
            if (list.Count == 0)
            {
                list = db.SelectAll();
            }

            News news = list.Find(item => item.Id == id);
            return news;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            News n = entity as News;
            if (n != null)
            {
                string sqlStr = $"DELETE FROM News WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", n.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            News n = entity as News;

            if (n != null)
            {
                string sqlStr = @"INSERT INTO [News] 
                          ([content], [publishDate], [Titel], [idUser]) 
                          VALUES (@content, @publishDate, @titel, @idUser)";

                cmd.CommandText = sqlStr;

                cmd.Parameters.Add("@content", OleDbType.LongVarWChar).Value = n.Content ?? "";
                cmd.Parameters.Add("@publishDate", OleDbType.Date).Value = n.PublishDate.Date;
                cmd.Parameters.Add("@titel", OleDbType.VarWChar).Value = n.Titel ?? "";
                cmd.Parameters.Add("@idUser", OleDbType.Integer).Value = n.IdUser.Id;
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            News n = entity as News;
            if (n != null)
            {
                string sqlStr = $"UPDATE News SET Content=@content, PublishDate=@publishDate, Titel=@titel, IdUser=@idUser WHERE id=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@content", n.Content));
                cmd.Parameters.Add("@publishDate", OleDbType.Date).Value = n.PublishDate.Date;
                cmd.Parameters.Add(new OleDbParameter("@titel", n.Titel));
                cmd.Parameters.Add(new OleDbParameter("@idUser", n.IdUser.Id));
                cmd.Parameters.Add(new OleDbParameter("@id", n.Id));
            }
        }
    }
}
