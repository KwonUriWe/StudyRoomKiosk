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
            }else if(Sql.pageType == 2)
            {
                this.Text = "자리이동";
            }else if(Sql.pageType == 3)
            {
                this.Text = "퇴실하기";
            }


            //groupBox_seat 내 모든 버튼에 대한 클릭 이벤트 설정
            foreach (Button numButton in groupBox_numPad.Controls.OfType<Button>())
            {
                numButton.Click += numPad_Click;
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

        private void button_goHome_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (Sql.pageType == 2)
            {
                //자리이동 페이지
            }else if (Sql.pageType == 3)
            {
                //퇴장하기
            }
            else
            {
                //회원입장 비회원 입장
                //번호를 다 입력하지 입력하지 않으면 창이 안넘어가게 if문 사용
                if (textBox_numRight.TextLength < 4)
                {
                    MessageBox.Show("번호를 정확히 입력해주세요");
                }
                else
                {
                    try
                    {
                        string phonenum = "";
                        phonenum += textBox_numLeft.Text;
                        phonenum += textBox_numCenter.Text;
                        phonenum += textBox_numRight.Text;

                        TblMember.phoneNum = phonenum;  //TblMember클래스의 phoneNum에 텍스트박스에 입력된 번호 set

                        MessageBox.Show(phonenum); // 입력한 전화번호 확인용 메세지 - 추후 삭제

                        string str = "phonenum = " + phonenum;
                        bool check = sql.Query_Select_Bool("tbl_member", str);

                        MessageBox.Show(check.ToString()); // 불값 참인지 확인용 메세지 - 추후 삭제

                        if (check)
                        {
                            DataSet ds = sql.Query_Select_DataSet("memberNo, phoneNum", "", "TBL_MEMBER");
                            TblMember.memberNo = ds.Tables[0].Rows[0]["memberNo"].ToString();
                            TblMember.phoneNum = ds.Tables[0].Rows[0]["phonenum"].ToString();


                            FormSelectSeatTime form = new FormSelectSeatTime(); // 에러! catch문으로 빠짐 
                            this.Visible = false;
                            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                            form.ShowDialog();
                            Process.GetCurrentProcess().Kill();
                        }
                        else
                        {
                            MessageBox.Show("일치하는 번호가 없습니다.");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("알 수 없는 문제가 발생했습니다.");
                    }
                }
            }
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
    }
}
