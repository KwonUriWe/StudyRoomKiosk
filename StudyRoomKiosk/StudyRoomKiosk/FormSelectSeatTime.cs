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
        Sql sql = new Sql();
        string selectTime = null;
        string spanTime = null;

        public FormSelectSeatTime()
        {
            InitializeComponent();
            //whoIs();
            //seatStatus();

            //we_ TBL_TIME에 저장된 데이터를 불러와서 라디오버튼의 텍스트로 대입하도록 수정 필요.. 추후 데이터 수정시 용이하도록.

            DataSet ds = sql.Query_Select_DataSet("seatNo", " Where seatNo is not null", "TBL_MEMBER");
            int count = int.Parse(ds.Tables[0].Rows.Count.ToString());
            String[] seatNo = new String[count];
            DateTime[] Time = new DateTime[count];
            for (int i = 0; i < count; i++)
            {
                // selec해서 카운트만큼 돌린다.
                ds = sql.Query_Select_DataSet("seatNo,expiredTime", " Where seatNo is not null", "TBL_MEMBER ");
                seatNo[i] = ds.Tables[0].Rows[i]["seatNo"].ToString();
                // expiredTime[i]  = (ds.Tables[0].Rows[i]["expiredTime"].ToString()).Substring(13, 5);
                DateTime time = Convert.ToDateTime(ds.Tables[0].Rows[i]["expiredTime"].ToString());
                DateTime eTime = DateTime.Now;
                // 시간 차이 구함
                TimeSpan gapTime2 = time - eTime;
                Time[i] = eTime;
            }

            //groupBox_seat 내 모든 버튼에 대한 클릭 이벤트 설정
            foreach (Button seatButton in groupBox_seat.Controls.OfType<Button>())
            {
                seatButton.Click += seat_Click;
            }
            button_goJoin.Visible = false;
        }

        //자리 선택 시 수행될 메소드
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

        //자리의 상태를 확인 후 출력하는 메소드
        private void seatStatus()
        {
            foreach (Button seatButton in groupBox_seat.Controls.OfType<Button>())
            {
                try
                {
                    Sql sql = new Sql();
                    string seatNumber = seatButton.Text.Substring(11);  //모든 버튼의 숫자만 추출
                    string str = "where seatNo = " + TblMember.seatNo;
                    string endTime = "";
                    
                    DataSet ds = sql.Query_Select_DataSet("status", str, "TBL_SEAT");
                    if (ds.Tables[0].Rows.ToString() == "1")
                    {
                        seatButton.BackColor = Color.FromArgb(255, 128, 0);
                        seatButton.Enabled = false;
                        //we_흘러가는 잔여시간 출력하는 코드 추가하기
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("알 수 없는 문제가 발생했습니다.");
                }
            }
        }

        //시간은 당일과 장기 이용권 중 하나만 선택 되어야 하므로 클릭시 다른 그룹박스의 클릭 해제
        private void groupBox_longTime_Enter(object sender, EventArgs e)
        {
            foreach (RadioButton todayRButton in groupBox_today.Controls.OfType<RadioButton>())
            {
                todayRButton.Checked = false;
            }
        }

        //시간은 당일과 장기 이용권 중 하나만 선택 되어야 하므로 클릭시 다른 그룹박스의 클릭 해제
        private void groupBox_today_Enter(object sender, EventArgs e)
        {
            foreach (RadioButton longTimeRButton in groupBox_longTime.Controls.OfType<RadioButton>())
            {
                longTimeRButton.Checked = false;
            }
        }

        //비회원 입장시 장기이용권 결제 못하도록 하는 메소드
        private void whoIs()
        {
            //비회원 입장일 경우
            //장기 이용권 그룹박스 텍스트 내용 변경, 박스 내 라디오 버튼 클릭 비활성화, 클릭 시 가입여부 팝업 이벤트 호출
            if (Sql.pageType == 1)
            {
                button_goJoin.Visible = true;
                groupBox_longTime.Text = "장기 이용권 _ 정회원만 선택 가능합니다.";

                //groupBox_longTime 내 모든 라디오 버튼에 대해 비활성화.
                //그룹박스 자체를 비활성화 하면 혹시라도 클릭시 메시지박스가 팝업되도록 할 수 없으므로 아래와 같이 처리
                foreach (RadioButton longTimeRButton in groupBox_longTime.Controls.OfType<RadioButton>())
                {
                    longTimeRButton.Enabled = false;
                }
            }
            groupBox_longTime.Click += unableClick;
        }

        //비회원 입장 후 장기이용권 클릭 시 가입여부 팝업 이벤트
        private void unableClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("장기 이용권은 정회원만 선택 가능합니다. \n회원가입 하시겠습니까?", "장기 이용권 안내", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormMembersJoin form = new FormMembersJoin();
                this.Visible = false;
                form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                form.ShowDialog();
                Process.GetCurrentProcess().Kill();
            }
        }

        private string EndTime()
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            //we_ time += (클릭한 라디오버튼의 시간값)
            return time;
        }

        private void updateMember()
        {
            Sql sql = new Sql();
            
            //we_결제 후 DB에 결제내용 저장기능 구현 필요
            sql.Query_Modify("UPDATE TBL_MEMBER SET seatNo="+ TblMember.seatNo + "expiredTime=");
        }

        //결제하기 버튼 클릭시 결제 진행
        private void button_payment_Click(object sender, EventArgs e)
        {
            //we_ selectTime에 클릭한 라디오버튼의 텍스트값 저장
            if (TblMember.seatNo == null || selectTime == null)
            {
                MessageBox.Show("시간과 좌석 모두 선택해야 합니다.");
            }
            else
            {
                string str = "좌석 : " + TblMember.seatNo + "\n시간 : " + selectTime + "\n결제하시겠습니까?";
                if (MessageBox.Show(str, "결제정보", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //we_결제기능 추후 구현 필요
                    MessageBox.Show("결제되었습니다.\n입장하십시오.");
                    updateMember();
                }
                else
                {
                    MessageBox.Show("결제가 취소되었습니다.");
                }
            }
        }

        //처음으로 버튼 클릭시 해당 폼으로 이동
        private void button_goHome_Click(object sender, EventArgs e)
        {
            FormMembersEnt form = new FormMembersEnt();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }

        //회원가입 버튼 클릭시 해당 폼으로 이동
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
