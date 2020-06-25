namespace StudyRoomKiosk
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.button_changeSeat = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button3_admin = new System.Windows.Forms.Button();
            this.button_membersJoin = new System.Windows.Forms.Button();
            this.button_membersEnt = new System.Windows.Forms.Button();
            this.button_nonMembersEnt = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label_empty = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(231, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "사진??";
            // 
            // button_changeSeat
            // 
            this.button_changeSeat.BackColor = System.Drawing.SystemColors.Control;
            this.button_changeSeat.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_changeSeat.Location = new System.Drawing.Point(0, 863);
            this.button_changeSeat.Name = "button_changeSeat";
            this.button_changeSeat.Size = new System.Drawing.Size(196, 100);
            this.button_changeSeat.TabIndex = 0;
            this.button_changeSeat.Text = "자리이동";
            this.button_changeSeat.UseVisualStyleBackColor = false;
            this.button_changeSeat.Click += new System.EventHandler(this.button_changeSeat_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_exit.Location = new System.Drawing.Point(194, 863);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(196, 100);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "퇴실";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button3_admin
            // 
            this.button3_admin.BackColor = System.Drawing.SystemColors.Control;
            this.button3_admin.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button3_admin.Location = new System.Drawing.Point(388, 863);
            this.button3_admin.Name = "button3_admin";
            this.button3_admin.Size = new System.Drawing.Size(196, 100);
            this.button3_admin.TabIndex = 0;
            this.button3_admin.Text = "관리자메뉴";
            this.button3_admin.UseVisualStyleBackColor = false;
            // 
            // button_membersJoin
            // 
            this.button_membersJoin.BackColor = System.Drawing.SystemColors.Control;
            this.button_membersJoin.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_membersJoin.Location = new System.Drawing.Point(0, 765);
            this.button_membersJoin.Name = "button_membersJoin";
            this.button_membersJoin.Size = new System.Drawing.Size(196, 100);
            this.button_membersJoin.TabIndex = 0;
            this.button_membersJoin.Text = "회원가입";
            this.button_membersJoin.UseVisualStyleBackColor = false;
            this.button_membersJoin.Click += new System.EventHandler(this.button_membersJoin_Click);
            // 
            // button_membersEnt
            // 
            this.button_membersEnt.BackColor = System.Drawing.SystemColors.Control;
            this.button_membersEnt.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_membersEnt.Location = new System.Drawing.Point(194, 765);
            this.button_membersEnt.Name = "button_membersEnt";
            this.button_membersEnt.Size = new System.Drawing.Size(196, 100);
            this.button_membersEnt.TabIndex = 0;
            this.button_membersEnt.Text = "회원입장";
            this.button_membersEnt.UseVisualStyleBackColor = false;
            this.button_membersEnt.Click += new System.EventHandler(this.button_membersEnt_Click);
            // 
            // button_nonMembersEnt
            // 
            this.button_nonMembersEnt.BackColor = System.Drawing.SystemColors.Control;
            this.button_nonMembersEnt.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_nonMembersEnt.Location = new System.Drawing.Point(388, 765);
            this.button_nonMembersEnt.Name = "button_nonMembersEnt";
            this.button_nonMembersEnt.Size = new System.Drawing.Size(196, 100);
            this.button_nonMembersEnt.TabIndex = 0;
            this.button_nonMembersEnt.Text = "비회원입장";
            this.button_nonMembersEnt.UseVisualStyleBackColor = false;
            this.button_nonMembersEnt.Click += new System.EventHandler(this.button_nonMembersEnt_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("돋움", 20F);
            this.label_total.Location = new System.Drawing.Point(12, 682);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(192, 27);
            this.label_total.TabIndex = 2;
            this.label_total.Text = "전체 좌석 수 : ";
            // 
            // label_empty
            // 
            this.label_empty.AutoSize = true;
            this.label_empty.Font = new System.Drawing.Font("돋움", 20F);
            this.label_empty.Location = new System.Drawing.Point(12, 720);
            this.label_empty.Name = "label_empty";
            this.label_empty.Size = new System.Drawing.Size(192, 27);
            this.label_empty.TabIndex = 3;
            this.label_empty.Text = "남은 좌석 수 : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 962);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_empty);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.button_nonMembersEnt);
            this.Controls.Add(this.button_membersEnt);
            this.Controls.Add(this.button3_admin);
            this.Controls.Add(this.button_membersJoin);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_changeSeat);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FormHome";
            this.Text = "홈";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_changeSeat;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button3_admin;
        private System.Windows.Forms.Button button_membersJoin;
        private System.Windows.Forms.Button button_membersEnt;
        private System.Windows.Forms.Button button_nonMembersEnt;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_empty;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}