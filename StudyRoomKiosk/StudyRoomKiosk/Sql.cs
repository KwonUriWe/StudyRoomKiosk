using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRoomKiosk
{
    

    class Sql
    {
        //홈에서 회원입장 비회원입장 자리이동 퇴살하기 버튼 클릭시 값을 다르게 줘서 페이지 구분
        public static int pageType;

        //가용성 좋게 만들었습니당.
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da;
        public DataSet ds;
        public DataGridView dataGridView = new DataGridView();
        public void ConnectDB()
        {//db연결
            conn.ConnectionString = $"Data Source=({"local"}); Initial Catalog={"StudyRoomKiosk"}; Integrated Security = {"SSPI"}; Timeout=3";
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }
        public DataGridView Query_Select()
        {//dataGridView 띄우기
            ConnectDB();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM TBL_MEMBER";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "TBL_MEMBER");
            conn.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("없는 테이블 입니다.");
                dataGridView = null;
            }
            else
            {
                dataGridView.DataSource = ds;
            }
            return dataGridView;
        }

        public DataGridView Query_Select(string columnStr, string str, string tableStr)
        {// 테이블명 or 조건문써서 dataGridView 띄우기
         //columStr 변수에 넣고 싶은 컬럼명을 입력 columStr = "columStr = 컬럼명 as 별칭, 컬럼명 as 별칭 ..."
         //str 변수에 table 명과 where 조건문을 입력 ex) str = "table명 where = 조건"

            ConnectDB();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT " + columnStr + " FROM" + tableStr + str;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, tableStr);
            conn.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("없는 테이블 입니다.");
                return dataGridView = null;
            }
            else
            {
                dataGridView.DataSource = ds;
                return dataGridView;
            }
        }


        public DataSet Query_Select_DataSet(string columnStr, string str, string tableStr)
        {//검색 결과 값 가져오기
         //columStr 변수에 넣고 싶은 컬럼명을 입력 columStr = "columStr = 컬럼명 as 별칭, 컬럼명 as 별칭 ..."
         //str 변수에 table 명과 where 조건문을 입력 ex) str = "table명 where = 조건"
         // ex) DataSet ds = sql.Query_Select_DataSet(string columnStr, string str, string tableStr); str 변수에 where 조건은 기본키 사용
         // ex) string product_Name = ds.Tables[0].Rows[0]["컬럼명"].ToString(); 가져오고싶은 값의 "컬럼명"을 입력
            ConnectDB();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT " + columnStr + " FROM " + tableStr + str;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, tableStr);
            conn.Close();
            return ds;
        }

        public DataSet Query_Select_Dual(string columnStr)
        {//오라클의 Dual과 같은 가상 테이블 사용하기
            ConnectDB();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT " + columnStr + " A";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public void Query_Modify(string sqlcommand)
        {//update delete insert 등
         //자주 쓸만한 DML문은 따로 Overloading을 하여만드시면 됩니다.
            ConnectDB();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public bool Query_Select_Bool(string tableStr, string str)
        {//(중복된값) 값이 있는지 없는지 확인
         //테이블에 값이 있는지 없는지 확인 테이블안에 값이 없다면 오류 발생 폼이 꺼지는거????꼬이게됌 아무튼 그거 방지용
            ConnectDB();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM " + tableStr + " WHERE " + str;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, tableStr);
            conn.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("없는 테이블 입니다.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

