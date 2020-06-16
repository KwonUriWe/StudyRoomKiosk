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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            seats();
        }

        private void seats()
        {
            Sql sql = new Sql();
            DataSet dsEmpty = sql.Query_Select_DataSet("seatNo", " Where state is null", "TBL_SEAT");
            label_empty.Text += dsEmpty.Tables[0].Rows.Count.ToString();

            DataSet dsTotal = sql.Query_Select_DataSet("seatNo", "", "TBL_SEAT");
            label_total.Text += dsTotal.Tables[0].Rows.Count.ToString();
        }

        private void button_membersJoin_Click(object sender, EventArgs e)
        {
            FormMembersJoin form = new FormMembersJoin();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();

        }

        private void button_membersEnt_Click(object sender, EventArgs e)
        {
            Sql.pageType = 0;
            FormMembersEnt form = new FormMembersEnt();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }

        private void button_nonMembersEnt_Click(object sender, EventArgs e)
        {
            Sql.pageType = 1;
            FormMembersEnt form = new FormMembersEnt();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }

        private void button_changeSeat_Click(object sender, EventArgs e)
        {
            Sql.pageType = 2;
            FormMembersEnt form = new FormMembersEnt();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Sql.pageType = 3;
            FormMembersEnt form = new FormMembersEnt();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            Process.GetCurrentProcess().Kill();
        }
    }
}
