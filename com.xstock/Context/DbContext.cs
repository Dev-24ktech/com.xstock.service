using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace Sunco.Context
{
    public class DbContext
    {
        private string ConnectionStrings;
        private string DbConfigName;
        private MySqlConnection conn;
        public DbContext()
        {
            this.DbConfigName = "SuncoDB";
            this.ConnectionStrings = WebConfigurationManager.ConnectionStrings[this.DbConfigName].ConnectionString;
            this.conn=this.initConnection(this.ConnectionStrings);
        }
        public DbContext(string DbConfigName)
        {
            this.ConnectionStrings = WebConfigurationManager.ConnectionStrings[DbConfigName].ConnectionString;
            this.conn = this.initConnection(this.ConnectionStrings);
        }
        public void setConnectionString(string ConnectionStrings)
        {
            this.ConnectionStrings = ConnectionStrings;
        }
        public string getConnectionString()
        {
            return this.ConnectionStrings;
        }
        private MySqlConnection initConnection(string ConnectionStrings)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionStrings);
            return conn;
        }

        public MySqlDataReader runQuery(string q)

        {
            
            try
            {
                this.conn.Open();
                Debug.WriteLine("Database connection staring...");
                MySqlCommand cmd=new MySqlCommand(q,this.conn);
                
                return cmd.ExecuteReader();
               

            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
                
            }
           

            return null;
            
            
        }
        

    }
}