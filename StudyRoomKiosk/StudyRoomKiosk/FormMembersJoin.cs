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
    public partial class FormMembersJoin : Form
    {
        Sql sql = new Sql();
        Random random = new Random();
        int randomNum;
        bool numberB = false;
        //시간 증가
        int time = 0;
        int minute = 0;
        public FormMembersJoin()
        {
            InitializeComponent();
        }


        private void button_goHome_Click(object sender, EventArgs e)
        {

            FormHome form = new FormHome();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }

        private void button_join_Click(object sender, EventArgs e)
        {//가입하기 버튼
            if (textBox_name.Text.Trim() == "" || textBox_dateBirth.Text.Trim() == "" || comboBox_gender.SelectedItem as String == ""
               || comboBox_newsAgency.SelectedItem as String == "" || textBox_phoneNum1.Text.Trim() == "" || textBox_phoneNum2.Text.Trim() == ""
                || textBox_phoneNum3.Text.Trim() == "")
            {//입력 안했을시
                MessageBox.Show("빈칸이 있습니다 다시 입력해주세요");
            }
            else
            {
                if (numberB)
                {//휴대전화 번호를 11자리 입력 했을시
                    String tel = textBox_phoneNum1.Text + "-" + textBox_phoneNum2.Text + "-" + textBox_phoneNum3.Text;
                    if (sql.Query_Select_Bool("TBL_MEMBER", "phoneNum = '" + tel + "'"))
                    {//휴대폰 번호가 중복시
                        MessageBox.Show("이미 가입한 번호입니다.");
                    }
                    else
                    {
                        if (textBox_crt.Text.Equals(randomNum.ToString()))
                        {
                            //인증번호 일치했을시
                            timer.Enabled = false;
                            linkLabel.Visible = false;
                            label4.Visible = false;
                            MessageBox.Show("인증 번호 일치");
                            if (sql.Query_Select_Bool("TBL_MEMBER", "memberNo > 0"))
                            {
                                int maxNum = int.Parse(sql.Query_Select_DataSet("MAX(memberNo) as MAX", "", "TBL_MEMBER").Tables[0].Rows[0]["MAX"].ToString());
                                maxNum += 1;
                                sql.Query_Modify("INSERT INTO TBL_MEMBER ( memberNo,name,dateBirth,gender,newsAgency,phoneNum,memberbool) VALUES (" + maxNum + ",'" + textBox_name.Text + "','"
                                + textBox_dateBirth.Text + "','" + comboBox_newsAgency.Text + "','" + comboBox_gender.Text + "','"
                                + tel + "','" + true + "')");
                            }
                            else
                            {
                                sql.Query_Modify("INSERT INTO TBL_MEMBER ( memberNo,name,dateBirth,gender,newsAgency,phoneNum,memberbool) VALUES (1,'" + textBox_name.Text + "','"
                               + textBox_dateBirth.Text + "','" + comboBox_newsAgency.Text + "','" + comboBox_gender.Text + "','"
                               + tel + "','" + true + "')");
                            }
                            //sql.Query_Select_DataSet("MAX(memberNo)", "");memberNo ,memberNo ,name,dateBirth,gender,phoneNum
                            //회원 memberNo을 해야하는데 max를 구할때 원하는 값이 안나옴
                            //방법 1 테이블을 따로 구분하여 만든다.
                            //방법 2 ?

                        }
                        else if (randomNum == 0)
                        {
                            MessageBox.Show("다시 인증해 주세요 시간 초과");
                        }
                        else
                        {
                            MessageBox.Show("인증번호가 일치하지 않습니다.");
                        }
                    }

                }
                else
                {//휴대전화 번호를 11자리 입력안 했을시
                    MessageBox.Show("휴대전화 인증이 필요합니다.");
                }

            }
        }




        private void button_getCrt_Click(object sender, EventArgs e)
        {//인증번호 받기 버튼
            if (textBox_name.Text.Trim() == "" || textBox_dateBirth.Text.Trim() == "" || comboBox_gender.SelectedItem as String == null
               || comboBox_newsAgency.SelectedItem as String == null || textBox_phoneNum1.Text.Trim() == "" || textBox_phoneNum2.Text.Trim() == ""
                || textBox_phoneNum3.Text.Trim() == "")
            {//입력 안했을시
                MessageBox.Show("빈칸이 있습니다 다시 입력해주세요");
            }
            else
            {
                if (textBox_phoneNum1.Text.Count() == 3 && textBox_phoneNum2.Text.Count() == 4 && textBox_phoneNum3.Text.Count() == 4)
                {//휴대전화 번호를 11자리 입력 했을시
                    String tel = textBox_phoneNum1.Text + "-" + textBox_phoneNum2.Text + "-" + textBox_phoneNum3.Text;
                    if (sql.Query_Select_Bool("TBL_MEMBER", "phoneNum = '" + tel + "'"))
                    {
                        MessageBox.Show("이미 가입한 번호입니다.");
                    }
                    else
                    {//중복이 없을경우
                     //인증 번호 누른 여부를 
                        time = 60;
                        minute = 4;
                        numberB = true;
                        randomNum = random.Next(10000);
                        MessageBox.Show(randomNum + "");
                        //타이머 시작
                        timer.Enabled = true;
                        linkLabel.Visible = true;
                        label4.Visible = true;
                    }

                }
                else
                {//휴대전화 번호를 11자리 입력안 했을시
                    MessageBox.Show("번호를 다시 입력해 주세요");
                }

            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            time -= 1;

            if (time < 0)
            {
                minute--;
                if (minute < 0)
                {
                    timer.Enabled = false;
                    linkLabel.Visible = false;
                    label4.Text = "0:0 시간초과";
                    randomNum = 0;
                }
                else
                {
                    time = 60;
                    label4.Text = minute + ":" + time;
                }
            }
            else
            {
                label4.Text = minute + ":" + time;
            }

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//인증 번호 다시 받기
         //  time = 60;
         //minute = 4;
            timer.Enabled = true;
            randomNum = random.Next(10000);
            MessageBox.Show(randomNum + "");
            //타이머 시작
            timer.Enabled = true;
        }

    }
}

