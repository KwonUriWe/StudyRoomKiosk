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
        public FormSelectSeatTime()
        {
            InitializeComponent();
            //whoIs();
            //seatStatus();

            //groupBox_seat 내 모든 버튼에 대한 클릭 이벤트 설정
            foreach (Button seatButton in groupBox_seat.Controls.OfType<Button>())
            {
                seatButton.Click += seat_Click;
            }

            button_goJoin.Visible = false;
        }

        //자리 선택 시 색상 변경되는 이벤트
        private void seat_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            //자리를 이미 선택해 둔 상태에서 다른 자리 선택시 기 선택 자리 색상 초기화
            foreach (Button seatButton in groupBox_seat.Controls.OfType<Button>())
            {
                if (seatButton.BackColor == Color.FromArgb(255, 220, 0))
                {
                    seatButton.BackColor = Color.FromArgb(255, 255, 255);
                }
            }
            //선택한 자리 색상 변경
            clickedButton.BackColor = Color.FromArgb(255, 220, 0);
            TblMember.seatNo = clickedButton.Text;  //선택한 자리번호 저장
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

                //groupBox_longTime 내 모든 라디오 버튼에 대해 비활성화.
                //그룹박스 자체를 비활성화 하면 혹시라도 클릭시 메시지박스가 팝업되도록 할 수 없으므로 아래와 같이 처리
                foreach (RadioButton longTimeRadioButton in groupBox_longTime.Controls.OfType<RadioButton>())
                {
                    longTimeRadioButton.Enabled = false;
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
            foreach (Button seatButton in groupBox_seat.Controls.OfType<Button>())
            {
                try
                {
                    Sql sql = new Sql();
                    string seatNumber = seatButton.Text.Substring(11);  //모든 버튼의 숫자만 추출
                    string str = "seatNo = " + TblMember.seatNo;
                    DataSet ds = sql.Query_Select_DataSet("status", str, "TBL_SEAT");
                    if (ds.Tables[0].Rows.ToString() == "1")
                    {
                        seatButton.BackColor = Color.FromArgb(255, 128, 0);
                        seatButton.Enabled = false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("알 수 없는 문제가 발생했습니다.");
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

        private void button_goJoin_Click(object sender, EventArgs e)
        {
            FormMembersJoin form = new FormMembersJoin();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }
    }
}
