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
               || comboBox_newsAgency.SelectedItem as String == "" || textBox_phoneNum.Text.Trim() == "")
            {//입력 안했을시
                MessageBox.Show("빈칸이 있습니다 다시 입력해주세요");
            }
            else
            {
                if (textBox_phoneNum.Text.Count() == 11)
                {//휴대전화 번호를 11자리 입력 했을시
                    string tel1 = textBox_phoneNum.Text.Substring(0, 3);
                    string tel2 = textBox_phoneNum.Text.Substring(3, 4);
                    string tel3 = textBox_phoneNum.Text.Substring(7, 4);
                    string tel = tel1 + "-" + tel2 + "-" + tel3;
                    if (sql.Query_Select_Bool("TBL_MEMBER", "phoneNum = '" + tel + "'"))
                    {//중복시
                        MessageBox.Show("이미 가입한 번호입니다.");
                    }
                    else
                    {
                        if (textBox_crt.Text.Equals(randomNum.ToString()))
                        {
                            //인증번호 일치했을시
                            MessageBox.Show("일치");
                            //sql.Query_Select_DataSet("MAX(memberNo)", "");memberNo ,memberNo ,name,dateBirth,gender,phoneNum
                            //회원 memberNo을 해야하는데 max를 구할때 원하는 값이 안나옴
                            //방법 1 테이블을 따로 구분하여 만든다.
                            //방법 2 ?
                            sql.Query_Modify("INSERT INTO TBL_MEMBER ( memberNo,name,dateBirth,gender,newsAgency,phoneNum) VALUES (232,'" + textBox_name.Text + "','"
                                + textBox_dateBirth.Text + "','" + comboBox_newsAgency.Text + "','" + comboBox_gender.Text + "','"
                                + tel + "')");
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
        //FormHome form = new FormHome();
        //this.Visible = false;
        //form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //form.ShowDialog();
        //Process.GetCurrentProcess().Kill();



        private void button_getCrt_Click(object sender, EventArgs e)
        {//인증번호 받기 버튼
            if (textBox_name.Text.Trim() == "" || textBox_dateBirth.Text.Trim() == "" || comboBox_gender.SelectedItem as String == ""
               || comboBox_newsAgency.SelectedItem as String == "" || textBox_phoneNum.Text.Trim() == "")
            {//입력 안했을시
                MessageBox.Show("빈칸이 있습니다 다시 입력해주세요");
            }
            else
            {
                if (textBox_phoneNum.Text.Count() == 11)
                {//휴대전화 번호를 11자리 입력 했을시
                    string tel1 = textBox_phoneNum.Text.Substring(0, 3);
                    string tel2 = textBox_phoneNum.Text.Substring(3, 4);
                    string tel3 = textBox_phoneNum.Text.Substring(7, 4);
                    string tel = tel1 + "-" + tel2 + "-" + tel3;
                    if (sql.Query_Select_Bool("TBL_MEMBER", "phoneNum = '" + tel + "'"))
                    {
                        MessageBox.Show("이미 가입한 번호입니다.");
                    }
                    else
                    {//중복이 없을경우
                        randomNum = random.Next(10000);
                        MessageBox.Show(randomNum + "");
                    }

                }
                else
                {//휴대전화 번호를 11자리 입력안 했을시
                    MessageBox.Show("번호를 다시 입력해 주세요");
                }

            }

        }



        private void textBox_dateBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void textBox_phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

    }
}

