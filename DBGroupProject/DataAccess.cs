using Oracle.ManagedDataAccess.Client;
using System;

namespace DBGroupProject
{
    class DataAccess
    {
        public static void CreateOracleConnection()
        {
        }

        public static OracleConnection con;

        public static void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "Data Source=XE;User Id=system;Password=admin;";
            con.Open();
            Console.WriteLine("Connected to Oracle" + con.ServerVersion);
        }

        public static void Close()
        {
            con.Close();
            con.Dispose();
        }
    }
}
