using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CBSData
{
    public class DataBase
    {
        #region private fields
        private SqlConnection _connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\localDB.mdf;Integrated Security=True");

        #endregion

        public DataBase()
        {
            try
            {
                this._connection.Open();
                Globals.Log.AddLog(new LogBB.LogMessage(LogBB.LogType.info, "verbinding met database gemaakt"));
            }
            catch
            {
                Globals.Log.AddLog(LogBB.LogType.Fetal, "connection met database failed");
            }
        }
    
        public SqlConnection Connection
        {
            get
            {
                return this._connection;
            }
        }

        public SqlDataReader Select(string query, Dictionary<string, string> vars)
        {
            SqlCommand cmd = this._connection.CreateCommand();

            cmd.CommandText = query;
            foreach(var binding in vars)
            {
                cmd.Parameters[binding.Key].Value = binding.Value;
            }
            return cmd.ExecuteReader();
        }

        public void Insert(string query, Dictionary<string, string> vars)
        {
            SqlCommand cmd = this._connection.CreateCommand();

            cmd.CommandText = query;
            foreach (var binding in vars)
            {
                cmd.Parameters[binding.Key].Value = binding.Value;
            }
            cmd.ExecuteScalar(); 
        }

        public void Update(string query, Dictionary<string, string> vars)
        {
            SqlCommand cmd = this._connection.CreateCommand();

            cmd.CommandText = query;
            foreach (var binding in vars)
            {
                cmd.Parameters[binding.Key].Value = binding.Value;
            }
            cmd.ExecuteScalar(); 
        }
    }
}
