using Model;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ViewModel
{
    public class UserDB : BaseDB
    {
        public ListUser SelectAll()
        {
            command.CommandText = $"SELECT * FROM [User]";
            ListUser groupList = new ListUser(base.Select());
            return groupList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            User u = entity as User;
            u.FirstName = reader["firstName"].ToString();
            u.LastName = reader["lastName"].ToString();
            u.PhoneNumber = reader["phoneNumber"].ToString();
            u.Email = reader["email"].ToString();
            u.Pass = reader["pass"].ToString();
            u.Birthdate = Convert.ToDateTime(reader["birthDate"]).Date;
            u.Username = reader["username"].ToString();

            string savedPicturePath = reader["picturePath"] == DBNull.Value
            ? ""
            : reader["picturePath"].ToString();

            if (string.IsNullOrWhiteSpace(savedPicturePath))
            {
                u.Picture = null;
                u.PicturePath = null;
            }
            else
            {
                string fileName = System.IO.Path.GetFileName(savedPicturePath);

                string fullPath = System.IO.Path.Combine(BaseDB.Path(), "Covers", fileName);

                u.PicturePath = fileName;

                if (File.Exists(fullPath))
                {
                    u.Picture = ImageToBase64Converter.ImageToBase64(fullPath);
                }
                else
                {
                    u.Picture = null;
                    System.Diagnostics.Debug.WriteLine("User image not found: " + fullPath);
                }
            }

            //if(reader["picture"] == DBNull.Value)
            //{
            //    u.Picture = reader["picture"]?.ToString() ?? "";
            //    u.PicturePath = null;
            //}
            //else
            //{
            //    u.PicturePath = Path() + "\\Covers\\" + reader["picturePath"].ToString();
            //    string fileName = u.PicturePath;
            //    if(!string.IsNullOrEmpty(fileName))
            //    {
            //        string base64Result = ImageToBase64Converter.ImageToBase64(fileName);

            //        if(!string.IsNullOrEmpty(base64Result))
            //        {
            //            u.Picture = base64Result;
            //        }
            //        else
            //        {
            //            u.Picture = "Missing resource" + fileName;
            //        }
            //    }
            //string fileName = reader["picture"]?.ToString();

            //string imagePath = System.IO.Path.Combine(
            //    @"C:\Users\yahal\source\repos\Liany34\LitLink_Liany\ViewModel\Covers",
            //    fileName
            //);

            //Console.WriteLine("fileName = " + fileName);
            //Console.WriteLine("imagePath = " + imagePath);
            //Console.WriteLine("exists = " + File.Exists(imagePath));

            //if (File.Exists(imagePath))
            //{
            //    string base64String = ImageToBase64Converter.ImageToBase64(imagePath);
            //    u.Picture = base64String;
            //}
            //else
            //{
            //    u.Picture = null;
            //}

            base.CreateModel(entity);
            return u;
        }
        public override BaseEntity NewEntity()
        {
            return new User();
        }
        static private ListUser list = new ListUser();
        public static User SelectById(int id)
        {
            UserDB db = new UserDB();
            list = db.SelectAll();

            User g = list.Find(item => item.Id == id);
            return g;
        }
        public string SelectPRPByUserID(int id)
        {
            ListUser uList = SelectAll();
            User u = uList.Find(item => item.Id == id);

            if (u == null)
                return null;

            return u.Picture;
        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = $"DELETE FROM [User] WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = $"INSERT INTO [User] (FirstName, LastName, PhoneNumber, Email, Username, Pass, Birthdate, Picture, PicturePath) VALUES (@firstName, @lastName, @phoneNumber, @email, @username, @pass, @birthdate, @picture, @picturePath)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new OleDbParameter("@firstName", u.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lastName", u.LastName));
                cmd.Parameters.Add(new OleDbParameter("@phoneNumber", u.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@email", u.Email));
                cmd.Parameters.Add(new OleDbParameter("@username", u.Username));
                cmd.Parameters.Add(new OleDbParameter("@pass", u.Pass));
                cmd.Parameters.Add("@birthdate", OleDbType.Date).Value = u.Birthdate.Date;
                string pictureFileName = string.IsNullOrEmpty(u.PicturePath)
                ? null
                : System.IO.Path.GetFileName(u.PicturePath);
                cmd.Parameters.Add(new OleDbParameter("@picturePath",
                    !string.IsNullOrEmpty(pictureFileName) ? pictureFileName : (object)DBNull.Value));
                cmd.Parameters.Add(new OleDbParameter("@picturePath", !string.IsNullOrEmpty(u.PicturePath) ? u.PicturePath : (object)DBNull.Value));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;

            if (u != null)
            {
                string sqlStr =
                    "UPDATE [User] SET " +
                    "FirstName=@firstName, " +
                    "LastName=@lastName, " +
                    "Birthdate=@birthdate, " +
                    "PhoneNumber=@phoneNumber, " +
                    "Email=@email, " +
                    "Username=@username, " +
                    "Pass=@pass, " +
                    "PicturePath=@picturePath " +
                    "WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Clear();

                string pictureFileName = string.IsNullOrEmpty(u.PicturePath)
                    ? null
                    : System.IO.Path.GetFileName(u.PicturePath);

                cmd.Parameters.Add(new OleDbParameter("@firstName", u.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lastName", u.LastName));
                cmd.Parameters.Add("@birthdate", OleDbType.Date).Value = u.Birthdate.Date;
                cmd.Parameters.Add(new OleDbParameter("@phoneNumber", u.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@email", u.Email));
                cmd.Parameters.Add(new OleDbParameter("@username", u.Username));
                cmd.Parameters.Add(new OleDbParameter("@pass", u.Pass));
                cmd.Parameters.Add(new OleDbParameter("@picturePath",
                    !string.IsNullOrEmpty(pictureFileName) ? pictureFileName : (object)DBNull.Value));
                cmd.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }
    }
}
