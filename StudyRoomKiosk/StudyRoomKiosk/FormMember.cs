using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRoomKiosk
{
    public partial class FormMember : Form
    {
        Sql sql = new Sql();
        public FormMember()
        {

            InitializeComponent();
            if (sql.Query_Select_Bool("TBL_MEMBER", "memberBool = 'true'"))
            {
                dataGridView1.DataSource = sql.DataGridView_Select("SELECT memberNo '번호',name '이름',dateBirth '생일',gender '성별',phoneNum '번호',expiredTime '종료 시간',seatNo '사용 좌석 번호',checkInDate '최근 접속 날짜' FROM TBL_MEMBER where memberbool = 'true'", "TBL_MEMBER").DataSource;
                //dataGridView1.DataSource = sql.DataGridView_Select("select* from TBL_MEMBER where checkInDate < DATEADD(yy, -1, GETDATE())", "TBL_MEMBER").DataSource;
                dataGridView1.DataMember = "TBL_MEMBER";
            }
            else
            {
                MessageBox.Show("회원이 없습니다.");
                FormManager form = new FormManager();
                this.Visible = false;
                form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                form.ShowDialog();
            }

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                label_num.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                label_date.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            }
            catch (Exception)
            {

            }

        }


        private void button_update_Click(object sender, EventArgs e)
        {
            if (sql.Query_Select_Bool("TBL_MEMBER", " checkInDate< DATEADD(yy, -1, GETDATE()) and memberNo="+ label_num .Text))
            {
                sql.Query_Modify("DELETE FROM TBL_MEMBER where memberNo=" + label_num.Text);
                MessageBox.Show("삭제 완료");

            }
            else
            {
                DialogResult result = MessageBox.Show("장기 미접속자가 아닙니다 삭제 하시겠습니까?.", "삭제", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sql.Query_Modify("	DELETE FROM TBL_MEMBER where memberNo="+ label_num.Text);
                    MessageBox.Show("삭제 완료");
                }
                
            }
            dataGridView1.DataSource = sql.DataGridView_Select("SELECT memberNo '번호',name '이름',dateBirth '생일',gender '성별',phoneNum '번호',expiredTime '종료 시간',seatNo '사용 좌석 번호',checkInDate '최근 접속 날짜' FROM TBL_MEMBER where memberbool = 'true'", "TBL_MEMBER").DataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.DataGridView_Select("select memberNo '번호',name '이름',dateBirth '생일',gender '성별',phoneNum '번호',expiredTime '종료 시간',seatNo '사용 좌석 번호',checkInDate '최근 접속 날짜' from TBL_MEMBER where checkInDate < DATEADD(yy, -1, GETDATE()) and memberbool = 'true'", "TBL_MEMBER").DataSource;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.DataGridView_Select("SELECT memberNo '번호',name '이름',dateBirth '생일',gender '성별',phoneNum '번호',expiredTime '종료 시간',seatNo '사용 좌석 번호',checkInDate '최근 접속 날짜' FROM TBL_MEMBER where memberbool = 'true'", "TBL_MEMBER").DataSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            //Process.GetCurrentProcess().Kill();
        }
    }
}
