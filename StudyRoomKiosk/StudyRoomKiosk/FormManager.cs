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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {//이용권
            FormUseTicket form = new FormUseTicket();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            //Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {//회원 관리
            FormMember form = new FormMember();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
           // Process.GetCurrentProcess().Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {//사진 관리
            FormImg form = new FormImg();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            //Process.GetCurrentProcess().Kill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome();
            this.Visible = false;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
