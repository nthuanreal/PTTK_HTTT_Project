using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_winform.DAO
{
    public class DataProvider
    {
        private static DataProvider _instance;
        
        public static DataProvider Instance
        {
            get { if (_instance == null) _instance = new DataProvider(); return DataProvider._instance; }
            private set { DataProvider._instance = value; }
        }
        private DataProvider() { }

        private string _connectionString = @$"DATA SOURCE = localhost:1521/XEPDB1; USER ID=" + "QLHSUT" + ";PASSWORD=" + "123456";
        // private string _connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=xe)));User Id=SYS;Password=ngoc123;DBA Privilege=SYSDBA;";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            OracleConnection connection = new OracleConnection();
            
                connection.ConnectionString = _connectionString;
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            
                
            return data;
        }
        public void ExecuteNonQuery(string query, object[] parameter = null)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            string[] listParam = query.Split(' ');
                            int i = 0;
                            foreach (string item in listParam)
                            {
                                if (item.Contains(':'))
                                {
                                    command.Parameters.Add(new OracleParameter(item, parameter[i]));
                                    i++;
                                }
                            }
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while executing the query", ex);
            }
        }
    }
}
