using Oracle.ManagedDataAccess.Client;
using System;
using Oracle.DataAccess.Types;


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
            try
            {
                string oradb = "Data Source=//localhost:1521/xe;User Id=system;Password=admin;";

                con = new OracleConnection(oradb);  // C#

                con.Open();
            }
            catch (Exception)
            {

                throw;
            }        
        }

        public static void Close()
        {
            con.Close();
            con.Dispose();
        }
    }
}
