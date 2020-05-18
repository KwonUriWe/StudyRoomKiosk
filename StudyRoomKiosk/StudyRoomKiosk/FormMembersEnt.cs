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

            //groupBox_seat 내 모든 버튼에 대한 클릭 이벤트 설정
            //foreach (Button numButton in groupBox_numPad.Controls.OfType<Button>())
            //{
            //    numButton.Click += numPad_Click;
            //}
        }

        //groupBox_seat 내 번호버튼 클릭시 텍스트박스에 값 입력되는 이벤트.
        //텍스트박스에 입력된 숫자 수에 따라 포커스 자동 넘김
        //private void numPad_Click(object sender, EventArgs e)
        //{
        //    Button clickedButton = sender as Button;
        //    string keyNum = "";

        //    if (clickButton.Text == "1" || clickButton.Text == "2" || clickButton.Text == "3" || clickButton.Text == "4" ||
        //        clickButton.Text == "5" || clickButton.Text == "6" || clickButton.Text == "7" || clickButton.Text == "8" ||
        //        clickButton.Text == "9" || clickButton.Text == "0")
        //    {
        //        keyNum = clickButton.Text;
        //    }

        //    if (textBox_numLeft.Text.Length != 3)
        //    {
        //        textBox_numLeft.Focus();
        //        SendKeys.Send(keyNum);
        //    }
        //    else
        //    {
        //        if (textBox_numCenter.Text.Length != 4)
        //        {
        //            textBox_numCenter.Focus();
        //            SendKeys.Send(keyNum);
        //        }
        //        else
        //        {
        //            if (textBox_numRight.Text.Length != 4)
        //            {
        //                textBox_numRight.Focus();
        //                SendKeys.Send(keyNum);
        //            }
        //        }
        //    }
        //}

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

                    string str = "phonenum = '" + phonenum+"'";
                    bool check = sql.Query_Select_Bool("tbl_member", str);

                    MessageBox.Show(check.ToString()); // 불값 참인지 확인용 메세지 - 추후 삭제

                    if (check)
                    {
                        DataSet ds = sql.Query_Select_DataSet("*", "", "TBL_MEMBER");
                        TblMember.memberNo = ds.Tables[0].Rows[0]["memberNo"].ToString();
                        TblMember.name = ds.Tables[0].Rows[0]["name"].ToString();
                        TblMember.phoneNum = ds.Tables[0].Rows[0]["phonenum"].ToString();
                        TblMember.gender = ds.Tables[0].Rows[0]["gender"].ToString();
                        TblMember.newsAgency = ds.Tables[0].Rows[0]["newsAgency"].ToString();
                        TblMember.seatNo = ds.Tables[0].Rows[0]["seatNo"].ToString();
                        TblMember.expiredTime = ds.Tables[0].Rows[0]["expiredTime"].ToString();
                        TblMember.checkInDate = ds.Tables[0].Rows[0]["checkinDate"].ToString();
                        TblMember.dateBirth = ds.Tables[0].Rows[0]["dateBirth"].ToString();

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
                catch (Exception) {
                    MessageBox.Show("알 수 없는 문제가 발생했습니다.");
                }
            }
        }


        private void button_num1_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("1");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("1");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {
                        textBox_numRight.Focus();
                        SendKeys.Send("1");
                    }
                }
            }
        }

        private void button_num2_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("2");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("2");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("2");
                    }
                }
            }
        }

        private void button_num3_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("3");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("3");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("3");
                    }
                }
            }
        }

        private void button_num4_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("4");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("4");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("4");
                    }
                }
            }
        }

        private void button_num5_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("5");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("5");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("5");
                    }
                }
            }
        }

        private void button_num6_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("6");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("6");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("6");
                    }
                }
            }
        }

        private void button_num7_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("7");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("7");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("7");
                    }
                }
            }
        }

        private void button_num8_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("8");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("8");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("8");
                    }
                }
            }
        }

        private void button_num9_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("9");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("9");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("9");
                    }
                }
            }
        }

        private void button_num0_Click(object sender, EventArgs e)
        {
            if (textBox_numLeft.Text.Length != 3)
            {
                textBox_numLeft.Focus();
                SendKeys.Send("0");
            }
            else
            {
                if (textBox_numCenter.Text.Length != 4)
                {
                    textBox_numCenter.Focus();
                    SendKeys.Send("0");
                }
                else
                {
                    if (textBox_numRight.Text.Length != 4)
                    {

                        textBox_numRight.Focus();
                        SendKeys.Send("0");
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
