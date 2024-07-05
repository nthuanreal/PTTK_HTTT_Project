using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_winform.utils;

namespace UI_winform.DoanhNghiep
{
    public class NguoiDaiDien
    {
        public string mandd;
        public string tenndd;
        public string ngsinh;
        public string gioitinh;
        public string sdt;
        public string diachi;
        public string email;
        
        public NguoiDaiDien()
        {
            mandd = "";
            tenndd = "";
            ngsinh = "";
            gioitinh = "";
            sdt = "";
            diachi = "";
            email = "";
        }

        public void getInfo(string ma)
        {
            string query_sql = $"SELECT TO_CHAR(MANDD), HOTEN, TO_CHAR(NGSINH), GIOITINH, SDT, DIACHI, EMAIL FROM QLHSUT.QLHSUT_NGUOI_DAI_DIEN WHERE TO_CHAR(MANDD) = '{ma}'";
            OracleCommand cmd = new OracleCommand(query_sql, Session.Instance.OracleConnection);
            try
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.mandd = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(MANDD)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(MANDD)"));
                        this.tenndd = reader.IsDBNull(reader.GetOrdinal("HOTEN")) ? "" : reader.GetString(reader.GetOrdinal("HOTEN"));
                        this.gioitinh = reader.IsDBNull(reader.GetOrdinal("GIOITINH")) ? "" : reader.GetString(reader.GetOrdinal("GIOITINH"));
                        this.ngsinh = reader.IsDBNull(reader.GetOrdinal("TO_CHAR(NGSINH)")) ? "" : reader.GetString(reader.GetOrdinal("TO_CHAR(NGSINH)"));
                        this.diachi = reader.IsDBNull(reader.GetOrdinal("DIACHI")) ? "" : reader.GetString(reader.GetOrdinal("DIACHI"));
                        this.sdt = reader.IsDBNull(reader.GetOrdinal("SDT")) ? "" : reader.GetString(reader.GetOrdinal("SDT"));
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
