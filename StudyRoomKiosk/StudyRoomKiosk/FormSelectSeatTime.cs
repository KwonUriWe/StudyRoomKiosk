using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRoomKiosk
{
    public partial class FormSelectSeatTime : Form
    {
        Button[] seat = new Button[42];
        static int margin = 10;
        static int btnWidth = 90;
        static int btnHeight = 85;

        public FormSelectSeatTime()
        {
            InitializeComponent();
            whoIs();
            seatStatus();

            for (int i = 0; i < seat.Length; i++)
            {
                seat[i] = new Button();
                seat[i].Text = (1 + i).ToString();
                seat[i].Size = new Size(btnWidth, btnHeight);
                seat[i].BackColor = Color.FromArgb(255, 255, 255);
                seat[i].Location = new Point(margin + i % 6 * seat[i].Width, 10 + margin + i / 6 * seat[i].Height);
                seat[i].Click += seat_Click;
                groupBox_seat.Controls.Add(seat[i]);
            }

            button_goJoin.Visible = false;
        }

    

        //자리 선택 시 색상 변경 메소드
        private void seat_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            //자리를 이미 선택해 둔 상태에서 다른 자리 선택시 기 선택 자리 색상 초기화
            for (int i = 0; i < seat.Length; i++)
            {
                if (seat[i].BackColor == Color.FromArgb(255, 220, 0))
                {
                    seat[i].BackColor = Color.FromArgb(255, 255, 255);
                }
            }
            //선택한 자리 색상 변경
            clicked.BackColor = Color.FromArgb(255, 220, 0);
        }

        //비회원 입장시 장기이용권 결제 못하도록 하는 메소드
        private void whoIs()
        {
            Sql sql = new Sql();
            
            string str = "where phonenum = " + TblMember.phoneNum;
            DataSet ds = sql.Query_Select_DataSet("memberno", str, "tbl_member");
            //비회원 입장일 경우
            //장기 이용권 그룹박스 텍스트 내용 변경, 박스 내 라디오 버튼 클릭 비활성화, 클릭 시 가입여부 팝업 이벤트 호출
            if (ds.Tables[0].Rows.ToString().Substring(0, 3) == "000")
            {
                button_goJoin.Visible = true;
                groupBox_longTime.Text = "장기 이용권 _ 정회원만 선택 가능합니다.";
                foreach (RadioButton controlInGroupBox in groupBox_longTime.Controls.OfType<RadioButton>())
                {
                    controlInGroupBox.Enabled = false;
                }
            } 
            else
            {
                //정회원 입장일 경우 수행할 내용
            }
            groupBox_longTime.Click += unableClick;
        }

        //비회원 입장 후 장기이용권 클릭 시 가입여부 팝업 이벤트
        private void unableClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("장기 이용권은 정회원만 선택 가능합니다. 회원가입 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormMembersJoin form = new FormMembersJoin();
                this.Visible = false;
                form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                form.ShowDialog();
                Process.GetCurrentProcess().Kill();
            }
        }

        //자리의 상태에 따라 색상 변경, 선택 불가하도록 하는 메소드
        private void seatStatus()
        {
            //아래는 배열로 생성한 자리가 아닐 경우 사용
            //Sql sql = new Sql();
            //string str = "where seatNo = button_seat1";
            //DataSet ds = sql.Query_Select_DataSet("status", str, "TBL_SEAT");
            //if (ds.Tables[0].Rows.ToString() == "1")
            //{
            //    button_seat1.BackColor = Color.FromArgb(255, 128, 0);
            //}
            //
            //string str = "where seatNo = button_seat2";
            //DataSet ds = sql.Query_Select_DataSet("status", str, "TBL_SEAT");
            //if (ds.Tables[0].Rows.ToString() == "1")
            //{
            //    button_seat2.BackColor = Color.FromArgb(255, 128, 0);
            //}

            for (int i = 0; i < seat.Length; i++)
            {
                Sql sql = new Sql();
                string str = "where seatNo = " + i + 1;
                DataSet ds = sql.Query_Select_DataSet("status", str, "TBL_SEAT");
                if (ds.Tables[0].Rows.ToString() == "1")
                {
                    seat[i].BackColor = Color.FromArgb(255, 128, 0);
                    seat[i].Enabled = false;
                }
            }
        }

        //처음으로 버튼 클릭 이벤트
        private void button_goHome_Click(object sender, EventArgs e)
        {
            FormMembersEnt form = new FormMembersEnt();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }
    }
}
