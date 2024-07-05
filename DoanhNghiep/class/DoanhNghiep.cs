using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_winform.utils;

namespace UI_winform.DoanhNghiep
{
    public class DoanhNghiep
    {
        public string madn;
        public string tendn;
        public string mathue;
        public string ndd;
        public string diachi;
        public string sdt;
        public string email;
        public DoanhNghiep()
        {
            madn = "";
            tendn = "";
            mathue = "";
            ndd = "";
            diachi = "";
            sdt = "";
            email = "";
        }
        public void getInfo(string ma)
        {
            string query_sql = $"SELECT TO_CHAR(MADN), TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL FROM QLHSUT.QLHSUT_DOANH_NGHIEP WHERE TO_CHAR(MADN) = '{ma}'";
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.madn = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MADN)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MADN)"));
                        this.tendn = reader.IsDBNull(reader.GetOrdinal("TENDN")) ? "" : reader.GetString(reader.GetOrdinal("TENDN"));
                        this.mathue = reader.IsDBNull(reader.GetOrdinal("MASOTHUE")) ? "" : reader.GetString(reader.GetOrdinal("MASOTHUE"));
                        this.ndd = reader.IsDBNull(reader.GetOrdinal("NDD")) ? "" : reader.GetString(reader.GetOrdinal("NDD"));
                        this.sdt = reader.IsDBNull(reader.GetOrdinal("SDT")) ? "" : reader.GetString(reader.GetOrdinal("SDT"));
                        this.diachi = reader.IsDBNull(reader.GetOrdinal("DIACHI")) ? "" : reader.GetString(reader.GetOrdinal("DIACHI"));
                        this.email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? "" : reader.GetString(reader.GetOrdinal("EMAIL"));
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu!");
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }

}
