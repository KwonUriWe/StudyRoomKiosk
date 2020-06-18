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
        Sql sql = new Sql();
        String[] seatNo;
        DateTime[] timEnd;
        int count;
        public FormHome()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            if (sql.Query_Select_Bool("TBL_MEMBER", " seatNo is not null"))
            {
                //사용중인 좌석 개수를 구한다.
                DataSet ds = sql.Query_Select_DataSet("seatNo,expiredTime", " Where seatNo is not null", "TBL_MEMBER");
                count = int.Parse(ds.Tables[0].Rows.Count.ToString());
                seatNo = new String[count];
                timEnd = new DateTime[count];
                for (int i = 0; i < count; i++)
                {
                    seatNo[i] = ds.Tables[0].Rows[i]["seatNo"].ToString();
                    timEnd[i] = Convert.ToDateTime(ds.Tables[0].Rows[i]["expiredTime"].ToString());
                    DateTime timeNow = DateTime.Now;
                    if (timEnd[i] < timeNow)
                    {
                        if (sql.Query_Select_Bool("TBL_MEMBER", " seatNo = " + seatNo[i] + " and memberbool = 'true'"))
                        {
                            sql.Query_Modify("UPDATE TBL_MEMBER SET seatNo = NULL , expiredTime = NULL WHERE   seatNo = " + seatNo[i]);
                        }
                        else
                        {
                            sql.Query_Modify("DELETE FROM TBL_MEMBER WHERE   seatNo = " + seatNo[i] + " and memberbool = 'false'");
                        }
                        sql.Query_Modify("UPDATE TBL_SEAT SET status = 'FALSE' WHERE seatNo=" + seatNo[i]);
                    }
                }
            }
            seats();
        }

        private void seats()
        {
            Sql sql = new Sql();
            DataSet dsEmpty = sql.Query_Select_DataSet("seatNo", " Where status = 0 ", "TBL_SEAT");
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
