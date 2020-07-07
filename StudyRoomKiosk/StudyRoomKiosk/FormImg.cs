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
    public partial class FormImg : Form
    {
        Sql sql = new Sql();
        public FormImg()
        {

            InitializeComponent();
            if(sql.Query_Select_Bool("TBL_IMG", "imgName is Not null")) { 
            dataGridView1.DataSource = sql.DataGridView_Select("SELECT imgName FROM TBL_IMG", "TBL_IMG").DataSource;
            dataGridView1.DataMember = "TBL_IMG";
            }
            else
            {
                MessageBox.Show("테이블에 아무 값도 없습니다. DB에 값을 넣어주세요");
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
                // textBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (textBox1.Text != "")
                {//경로 변경 필수
                    pictureBox2.Load(ImgPath.imgPath() + textBox1.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {//변경
            if (sql.Query_Select_Bool("TBL_IMG", " imgName ='" + textBoxM.Text + "'"))
            {
                MessageBox.Show("중복된 이미지 입니다.");
            }
            else
            {
                sql.Query_Modify("update TBL_IMG set imgName ='" + textBoxM.Text + "' where imgName ='" + textBox1.Text + "'");
                dataGridView1.DataSource = sql.DataGridView_Select("SELECT imgName FROM TBL_IMG", "TBL_IMG").DataSource;
                MessageBox.Show("변경 완료");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {//openFileDialog1.ShowDialog화면에 띄운다
                 //  openFileDialog1 실행 OK눌렀다면IF 문으로 들어옴
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);//파일 명(경로)
                    textBoxM.Text = openFileDialog1.SafeFileName;//경로명을 넣어준다.
                }
                dataGridView1.DataSource = sql.DataGridView_Select("SELECT imgName FROM TBL_IMG", "TBL_IMG").DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            //Process.GetCurrentProcess().Kill();
        }

       
    }
}
