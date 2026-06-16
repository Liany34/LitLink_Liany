using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ViewModel
{
    public abstract class BaseDB
    {
        protected static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
              + System.IO.Path.GetFullPath(
                    System.Reflection.Assembly.GetExecutingAssembly().Location
                    + "/../../../../../ViewModel/MyProject1.accdb");

        private static readonly object dbLock = new object();

        protected OleDbConnection connection;
        protected OleDbCommand command;
        protected OleDbDataReader reader;

        protected List<ChangeEntity> deleted = new List<ChangeEntity>();
        protected List<ChangeEntity> inserted = new List<ChangeEntity>();
        protected List<ChangeEntity> updated = new List<ChangeEntity>();

        public static string Path()
        {
            string[] args = Environment.GetCommandLineArgs();
            string s;

            if (args.Length == 1)
            {
                s = args[0];
            }
            else
            {
                s = args[1];
                s = s.Replace("/service:", "");
            }

            string[] st = s.Split('\\');
            int x = st.Length - 5;

            st[x] = "ViewModel";
            Array.Resize(ref st, x + 1);

            string str = string.Join('\\', st);
            return str;
        }

        public BaseDB()
        {
            connection = new OleDbConnection(connectionString);
            command = new OleDbCommand();
            command.Connection = connection;
        }

        public abstract BaseEntity NewEntity();

        protected List<BaseEntity> Select()
        {
            lock (dbLock)
            {
                List<BaseEntity> list = new List<BaseEntity>();

                try
                {
                    command.Connection = connection;

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BaseEntity entity = NewEntity();
                        list.Add(CreateModel(entity));
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("BASEDB SELECT ERROR:");
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    System.Diagnostics.Debug.WriteLine("SQL: " + command.CommandText);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                        reader.Dispose();
                        reader = null;
                    }

                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

                return list;
            }
        }

        protected async Task<List<BaseEntity>> SelectAsync(string sqlStr)
        {
            List<BaseEntity> list = new List<BaseEntity>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sqlStr, con))
            {
                try
                {
                    await con.OpenAsync();

                    using (OleDbDataReader asyncReader =
                           (OleDbDataReader)await cmd.ExecuteReaderAsync())
                    {
                        reader = asyncReader;

                        while (reader.Read())
                        {
                            BaseEntity entity = NewEntity();
                            list.Add(CreateModel(entity));
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("BASEDB SELECT ASYNC ERROR:");
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    System.Diagnostics.Debug.WriteLine("SQL: " + sqlStr);
                }
                finally
                {
                    reader = null;
                }
            }

            return list;
        }

        protected virtual BaseEntity CreateModel(BaseEntity entity)
        {
            entity.Id = Convert.ToInt32(reader["id"]);
            return entity;
        }

        protected abstract void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd);

        public virtual void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();

            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
            }
        }

        protected abstract void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd);

        public virtual void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();

            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        protected abstract void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd);

        public virtual void Update(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();

            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
            }
        }

        public int SaveChanges()
        {
            lock (dbLock)
            {
                OleDbTransaction trans = null;
                int recordsAffected = 0;

                try
                {
                    command.Connection = connection;

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    trans = connection.BeginTransaction();
                    command.Transaction = trans;

                    foreach (var entity in inserted)
                    {
                        command.Parameters.Clear();

                        entity.CreateSql(entity.Entity, command);

                        recordsAffected += command.ExecuteNonQuery();

                        if (entity.Entity.Id == 0)
                        {
                            command.Parameters.Clear();
                            command.CommandText = "SELECT @@IDENTITY";

                            object scalar = command.ExecuteScalar();

                            if (scalar != null && scalar != DBNull.Value)
                            {
                                entity.Entity.Id = Convert.ToInt32(scalar);
                            }
                        }
                    }

                    foreach (var entity in updated)
                    {
                        command.Parameters.Clear();

                        entity.CreateSql(entity.Entity, command);

                        recordsAffected += command.ExecuteNonQuery();
                    }

                    foreach (var entity in deleted)
                    {
                        command.Parameters.Clear();

                        entity.CreateSql(entity.Entity, command);

                        recordsAffected += command.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    if (trans != null)
                    {
                        try
                        {
                            trans.Rollback();
                        }
                        catch
                        {
                        }
                    }

                    System.Diagnostics.Debug.WriteLine("BASEDB SAVECHANGES ERROR:");
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    System.Diagnostics.Debug.WriteLine("SQL: " + command.CommandText);
                }
                finally
                {
                    inserted.Clear();
                    updated.Clear();
                    deleted.Clear();

                    if (command != null)
                    {
                        command.Parameters.Clear();
                        command.Transaction = null;
                    }

                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

                return recordsAffected;
            }
        }
    }
}