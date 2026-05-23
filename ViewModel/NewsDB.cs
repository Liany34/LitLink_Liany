using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            News news = entity as News;
            news.Content = reader["Content"].ToString();
            news.PublishDate = DateTime.Parse(reader["PublishDate"].ToString());
            news.Titel = reader["Titel"].ToString();
            news.IdUser = UserDB.SelectById((int)(reader["idUser"]));
            base.CreateModel(entity);
            return news;
        }
        public override BaseEntity NewEntity()
        {
            return new News();
        }
        static private ListNews list = new ListNews();
        public static News SelectById(int id)
        {
            NewsDB db = new NewsDB();
            list = db.SelectAll();

            News news = list.Find(item => item.Id == id);
            return news;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            News n = entity as News;
            if (n != null)
            {
                string sqlStr = $"DELETE FROM News WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", n.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            News n = entity as News;
            if (n != null)
            {
                string sqlStr = $"INSERT INTO News (Content, PublishDate, Titel, IdUser) VALUES (@content, @publishDate, @titel, @idUser)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@content", n.Content));
                command.Parameters.Add(new OleDbParameter("@publishDate", n.PublishDate));
                command.Parameters.Add(new OleDbParameter("@titel", n.Titel));
                command.Parameters.Add(new OleDbParameter("@idUser", n.IdUser.Id));
            }
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            News n = entity as News;
            if (n != null)
            {
                string sqlStr = $"UPDATE News SET Content=@content, PublishDate=@publishDate, Titel=@titel, IdUser=@idUser WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@content", n.Content));
                command.Parameters.Add(new OleDbParameter("@publishDate", n.PublishDate));
                command.Parameters.Add(new OleDbParameter("@titel", n.Titel));
                command.Parameters.Add(new OleDbParameter("@idUser", n.IdUser.Id));
                command.Parameters.Add(new OleDbParameter("@id", n.Id));
            }
        }
    }
}
