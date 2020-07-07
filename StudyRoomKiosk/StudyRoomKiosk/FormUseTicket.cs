using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StudyRoomKiosk
{
    public partial class FormUseTicket : Form
    {
        Sql sql = new Sql();
        public FormUseTicket()
        {
            
            InitializeComponent();
          
                
                    dataGridView1.DataSource = sql.DataGridView_Select("SELECT timeUse '시간',amount '가격' FROM TBL_TIME where status = 'false'", "TBL_TIME").DataSource;
                    dataGridView1.DataMember = "TBL_TIME";

                    dataGridView2.DataSource = sql.DataGridView_Select("SELECT timeUse '시간',amount '가격' FROM TBL_TIME where status = 'true'", "TBL_TIME").DataSource;
                    dataGridView2.DataMember = "TBL_TIME";
                
            
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                label_timeUse.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_timeUse.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label_amount.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_amount.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {

            }

        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                label_timeUse.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox_timeUse.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                label_amount.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textBox_amount.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (sql.Query_Select_Bool("TBL_TIME", "timeUse= '" + textBox_timeUse.Text + "'"))
            {
                DialogResult result = MessageBox.Show("시간이 이미 존재 합니다. 가격만 수정 하시겠습니까?", "수정", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sql.Query_Modify("UPDATE TBL_TIME SET  amount= " + textBox_amount.Text +" where timeUse ='" + label_timeUse.Text + "'");
                    MessageBox.Show("변경완료");
                }

            }
            else
            {
                sql.Query_Modify("UPDATE TBL_TIME SET timeUse = '" + textBox_timeUse.Text + "', amount=" + textBox_amount.Text + " where timeUse = '" + label_timeUse.Text + "'");
                MessageBox.Show("변경완료");
            }
            dataGridView1.DataSource = sql.DataGridView_Select("SELECT timeUse '시간',amount '가격' FROM TBL_TIME where status = 'false'", "TBL_TIME").DataSource;
            dataGridView2.DataSource = sql.DataGridView_Select("SELECT timeUse '시간',amount '가격' FROM TBL_TIME where status = 'true'", "TBL_TIME").DataSource;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }
    }
}
