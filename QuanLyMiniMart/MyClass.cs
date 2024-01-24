using DevExpress.Charts.Native;
using System;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMiniMart
{
    internal class MyClass
    {
        private static MyClass _STT;
        private MyClass() { }
        public static MyClass STT
        {
            get
            {
                if (_STT != null) return _STT;
                _STT = new MyClass();
                return _STT;
            }
            private set { _STT = value; }
        }
        public void TaoCotSTT(RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            // e.Info.Filter = "STT";
            e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        public static DataTable getData(string query)
        {
            SqlConnection conn = Databasehelper.getConnection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void execquery(string query)
        {
            SqlConnection conn = Databasehelper.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public static DataTable getData1(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = Databasehelper.getConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static object execqueryScalar(string query)
        {
            SqlConnection conn = Databasehelper.getConnection();
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);


            // Thực hiện truy vấn và trả về giá trị đầu tiên
            return command.ExecuteScalar();

        }
        
    }
}
