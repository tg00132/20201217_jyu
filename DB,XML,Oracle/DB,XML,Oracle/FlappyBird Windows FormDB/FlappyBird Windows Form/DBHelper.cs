using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_Windows_Form
{
    class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
       
        public static DataSet ds;
        public static DataTable dt_rank;
        
        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                    "Initial Catalog = {1};" +
                    "Integrated Security = {2};" +
                    "Timeout = 3"
                    , "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void selectQuery()
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM dt_rank";


            SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
            ds = new DataSet();
            da.Fill(ds, "dt_rank");


            dt_rank = ds.Tables[0]; //select 결과값을 테이블에 넣는다.




            conn.Close(); //연결 해제


        }
        public static void insertQuery(int ranks, int score, string name)
        {

            try
            {
                ConnectDB();
                string sqlcommand;
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태로 선언함
                //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                sqlcommand = "Insert Into dt_rank (ranks, score, name) values (@parameter1,@parameter2,@parameter3)";
                cmd.Parameters.AddWithValue("@parameter1", ranks);
                cmd.Parameters.AddWithValue("@parameter2", score);
                cmd.Parameters.AddWithValue("@parameter3", name);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
        }
        public static void deleteQuery()
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text; // 입력 방식을 text로 
            string sqlcommand;
            sqlcommand = "Delete dt_rank"; // Ranking 테이블의 내용을 삭제 한다고 입력값을 줌
            cmd.CommandText = sqlcommand; //받은 입력값을 text에 집어넣음
            cmd.ExecuteNonQuery(); //집어넣은 입력값에 대한 쿼리 실행
            conn.Close(); // 종료

        }

    }
}
