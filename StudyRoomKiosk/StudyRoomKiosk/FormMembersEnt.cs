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
    public partial class FormMembersEnt : Form
    {
        Sql sql = new Sql();
        public FormMembersEnt()
        {
            InitializeComponent();

            if (Sql.pageType == 1)
            {
                this.Text = "비회원 입장";
            }
            else if (Sql.pageType == 2)
            {
                this.Text = "자리이동";
            }
            else if (Sql.pageType == 3)
            {
                this.Text = "퇴실하기";
            }

            //groupBox_seat 내 모든 버튼에 대한 클릭 이벤트 설정
            foreach (Button numButton in groupBox_numPad.Controls.OfType<Button>())
            {
                numButton.Click += numPad_Click;
            }
        }
        
        

        //완료 버튼
        private void button_check_Click(object sender, EventArgs e)
        {
            //번호를 다 입력하지 입력하지 않으면 창이 안넘어가게 if문 사용
            if (textBox_numRight.TextLength < 4)
            {
                MessageBox.Show("번호를 정확히 입력해주세요");
            }
            else
            {
                //번호 입력
                string phonenum = "";
                phonenum += textBox_numLeft.Text + "-";
                phonenum += textBox_numCenter.Text + "-";
                phonenum += textBox_numRight.Text;
                TblMember.phoneNum = phonenum;  //TblMember클래스의 phoneNum에 텍스트박스에 입력된 번호 set
                MessageBox.Show(phonenum); // 입력한 전화번호 확인용 메세지 - 추후 삭제

                //DB에 번호 있는지 없는지 확인
                string checkPhonenumStr = "phonenum = '" + phonenum + "'";
                bool phoneNumcheck = sql.Query_Select_Bool("tbl_member", checkPhonenumStr);
                bool checkNoMember = sql.Query_Select_Bool("tbl_member", checkPhonenumStr + " and  memberbool = 0");
                //DB에 이용 중인 자리 있는지 없는지 확인
                string checkSeatStr = "seatNo is not null and phoneNum = '" + phonenum + "'";
                bool checkSeat = sql.Query_Select_Bool("tbl_member", checkSeatStr);

                //자리이동 페이지
                if (Sql.pageType == 2)
                {
                    //DB에 저장된 번호가 있고 이용 중인 자리가 있을 경우                
                    if (phoneNumcheck&&checkSeat)
                    {
                        FormSelectSeatTime form = new FormSelectSeatTime();
                        this.Visible = false;
                        form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        form.ShowDialog();
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        MessageBox.Show("이용 중인 사용자가 아닙니다.");
                    }
                }
                //퇴장하기
                else if (Sql.pageType == 3)
                {
                    //이용 중인 자리
                    try
                    {
                        String seatNo;
                        seatNo = sql.Query_Select_DataSet("seatNo", " where phonenum = '" + phonenum + "'", "tbl_member").Tables[0].Rows[0][0].ToString();
                                    
                    //비회원 퇴장
                    
                    if (checkNoMember)
                    {
                        sql.Query_Modify("update tbl_seat set status = 0 where seatNo = " + seatNo);
                        sql.Query_Modify("delete  from tbl_member where phoneNum = '" + phonenum + "' and memberBool = 0");
                        
                        DialogResult result = MessageBox.Show("퇴실 처리 되었습니다.");
                        if ( result==DialogResult.OK) { //5초 지나면 넘어가게 해야함
                           
                        }
                    }

                    //회원 퇴장
                    bool checkMember = sql.Query_Select_Bool("tbl_member", checkPhonenumStr + " and  memberbool = 1");
                    if (checkMember)
                    {
                        DialogResult checkOut = MessageBox.Show("장기 이용 자인 경우 사용 중인 시간이 사라지게 됩니다. 정말 퇴실하겠습니까?", "확인", MessageBoxButtons.YesNo);
                        if (checkOut == DialogResult.Yes)
                        {
                            sql.Query_Modify("update tbl_member set expiredtime = null, seatNo = null where seatNo = " + seatNo);
                            sql.Query_Modify("update tbl_seat set status = 0 where seatNo = " + seatNo);

                            DialogResult result = MessageBox.Show("퇴실 처리 되었습니다.");
                            if (result == DialogResult.OK)
                            { //5초 지나면 넘어가게 해야함

                            }
                        }                      
                    }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("이용중인 사용자가 아닙니다. 번호를 다시한번 확인해주세요");
                    }



                    FormHome formHome = new FormHome();
                    this.Visible = false;
                    formHome.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    formHome.ShowDialog();
                    Process.GetCurrentProcess().Kill();


                }
                //회원입장 비회원 입장
                else
                {                 
                    try
                    {                                      
                        MessageBox.Show(phoneNumcheck.ToString()); // 불값 참인지 확인용 메세지 - 추후 삭제
                        //회원입장
                        if (Sql.pageType == 0)
                        {
                            if (phoneNumcheck)
                            {
                                //이용 중 자리가 있는 경우 바로 입장                              
                                if (checkSeat)
                                {
                                    DataSet ds = sql.Query_Select_DataSet("*", " where " + checkSeatStr, "TBL_MEMBER");
                                    TblMember.seatNo = ds.Tables[0].Rows[0]["seatNo"].ToString();
                                    MessageBox.Show(TblMember.seatNo + "로입장하십시오.");
                                    FormHome formHome = new FormHome();
                                    this.Visible = false;
                                    formHome.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                                    formHome.ShowDialog();
                                    Process.GetCurrentProcess().Kill();
                                }
                                //이용 중 자리가 없는 경우 결제 자리 선택으로 이동
                                else
                                {
                                    FormSelectSeatTime form = new FormSelectSeatTime();
                                    this.Visible = false;
                                    form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                                    form.ShowDialog();
                                    Process.GetCurrentProcess().Kill();
                                }
                            }
                            //회원입장 실패 시
                            else
                            {
                                DialogResult result = MessageBox.Show("일치하는 번호가 없습니다. 회원가입으로 이동하시겠습니까?", "이동알림창", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    FormMembersJoin form = new FormMembersJoin();
                                    this.Visible = false;
                                    form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                                    form.ShowDialog();
                                    Process.GetCurrentProcess().Kill();

                                }
                            }
                        }
                        //비회원입장
                        else
                        {
                            //회원인데 비회원으로 입장하여 실패 시
                            if (phoneNumcheck&&!(checkNoMember))
                            {
                                DialogResult result = MessageBox.Show("이미 가입된 번호 입니다. 회원 입장으로 이동하시겠습니까?", "이동알림창", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    Sql.pageType = 0;
                                    this.Text = "회원 입장";
                                }
                            }
                            //비회원 입장
                            else if(!phoneNumcheck)
                            {
                                FormSelectSeatTime form = new FormSelectSeatTime();
                                this.Visible = false;
                                form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                                form.ShowDialog();
                                Process.GetCurrentProcess().Kill();

                            }
                            else
                            {
                                DataSet ds = sql.Query_Select_DataSet("*", " where " + checkSeatStr, "TBL_MEMBER");
                                TblMember.seatNo = ds.Tables[0].Rows[0]["seatNo"].ToString();
                                MessageBox.Show(TblMember.seatNo + "로입장하십시오.");
                                FormHome formHome = new FormHome();
                                this.Visible = false;
                                formHome.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                                formHome.ShowDialog();
                                Process.GetCurrentProcess().Kill();
                            }
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("알 수 없는 문제가 발생했습니다.");
                    }
                }
            }
        }


        //처음으로 가기 버튼
        private void button_goHome_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }




        //텍스트박스 문자 입력 제한
        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }


        //재입력
        private void button_reEnter_Click(object sender, EventArgs e)
        {
            textBox_numLeft.Text = "";
            textBox_numCenter.Text = "";
            textBox_numRight.Text = "";
        }

        //백스페이스
        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (textBox_numCenter.Text.Length == 0)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("{Backspace}");
            }
            else
            {
                if (textBox_numRight.Text.Length == 0)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("{Backspace}");
                }
                else
                {
                    if (textBox_numRight.Text.Length <= 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("{Backspace}");
                    }
                }
            }
        }


        //groupBox_seat 내 번호버튼 클릭시 텍스트박스에 값 입력되는 이벤트.
        //텍스트박스에 입력된 숫자 수에 따라 포커스 자동 넘김
        private void numPad_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string keyNum = "";

            if (clickedButton.Text == "1" || clickedButton.Text == "2" || clickedButton.Text == "3" || clickedButton.Text == "4" ||
                clickedButton.Text == "5" || clickedButton.Text == "6" || clickedButton.Text == "7" || clickedButton.Text == "8" ||
                clickedButton.Text == "9" || clickedButton.Text == "0")
            {
                keyNum = clickedButton.Text;
                if (textBox_numLeft.Text.Length != 3)
                {
                    textBox_numLeft.Focus();
                    SendKeys.Send(keyNum);
                }
                else if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send(keyNum);
                }
                else if (textBox_numRight.Text.Length != 4)
                {
                    textBox_numRight.Focus();
                    SendKeys.Send(keyNum);
                }
            }
        }

        
    }
}
      



