using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_winform.DAO;

namespace UI_winform.UngVien
{
    public class BLL
    {
        public void createCandidateAcc(int mauv)
        {
            string username = mauv.ToString();
            string sql = $"CREATE USER \"{username}\" IDENTIFIED BY 123456";
            DataProvider.Instance.ExecuteNonQuery(sql);
            string grant_sql = $"GRANT CONNECT, RESOURCE, RESTRICTED SESSION TO \"{username}\"";
            DataProvider.Instance.ExecuteNonQuery(grant_sql);
            string grant_role = $"GRANT RL_QLHSUT_UNGVIEN TO \"{username}\"";
            DataProvider.Instance.ExecuteNonQuery(grant_role);
        }
        public int GetRowCount(string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            return Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }
        public void insert_data(int MAUV, string HOTEN, string ngaysinh, string GIOITINH, string SDT, string DIACHI, string EMAIL, string TRINHDO)
        {
            string query = @"INSERT INTO QLHSUT.QLHSUT_UNG_VIEN
                    (MAUV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO) 
                    VALUES(:MAUV, :HOTEN, TO_DATE(:NGSINH, 'YYYY-MM-DD'), :GIOITINH, :SDT, :DIACHI, :EMAIL, :TRINHDO)";

            // Parameters for the query
            object[] parameters = { MAUV, HOTEN, ngaysinh, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public DataTable getUVByMaUV(int MAUV)
        {
            string query = "SELECT HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO FROM QLHSUT.QLHSUT_UNG_VIEN WHERE MAUV = :MAUV";
            object[] parameters = { MAUV };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            return data;
        }
         public void update_ttuv(string HOTEN, string NGAYSINH, string GIOITINH, string SDT, string DIACHI, string EMAIL, string TRINHDO, int mauv)
        {

            object[] parameters = { HOTEN, NGAYSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO, mauv };
            string updateQuery = "UPDATE QLHSUT.QLHSUT_UNG_VIEN " +
                                 "SET HOTEN = :HOTEN, " +
                                 "NGSINH = TO_DATE(:NGAYSINH, 'YYYY-MM-DD'), " +
                                 "GIOITINH = :GIOITINH, " +
                                 "SDT = :SDT, " +
                                 "DIACHI = :DIACHI, " +
                                 "EMAIL = :EMAIL, " +
                                 "TRINHDO = :TRINHDO " +
                                 "WHERE MAUV = :MAUV";
            DataProvider.Instance.ExecuteNonQuery(updateQuery, parameters);

        }
        public DataTable getBangCap(int Mahs)
        {
            object[] parameters = { Mahs };
            string query = "select * FROM QLHSUT.QLHSUT_THONG_TIN_BANG_CAP where MAHS = :MAHS";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            return data;
        }
        public DataTable getHoSoUT(int MaUV)
        {
            string query = "select * FROM QLHSUT.QLHSUT_HO_SO_UNG_TUYEN where MAUV = :mauv";
            object[] parameters = { MaUV };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            return data;
        }
        public void insertBangCap(int mahs, int mabc, string tenbc, string noidung, string ngayhh)
        {
            object[] parameters = { mahs, mabc, tenbc, ngayhh, noidung };

            string query = @"INSERT INTO QLHSUT.QLHSUT_THONG_TIN_BANG_CAP
                 (MAHS, MABANGCAP, TENBANGCAP, NGAYHETHAN, ND_BANGCAP)
                 VALUES(:mahs, :mabc, :tenbc, TO_DATE(:ngayhh, 'YYYY-MM-DD'), :noidung)";

            DataProvider.Instance.ExecuteNonQuery(query, parameters);

        }
    }
}
