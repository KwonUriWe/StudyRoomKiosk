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
            this.button_membersEnt = new System.Windows.Forms.Button();
            this.button_membersJoin = new System.Windows.Forms.Button();
            this.button_nonMembersEnt = new System.Windows.Forms.Button();
            this.button_changeSeat = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_membersEnt
            // 
            this.button_membersEnt.BackColor = System.Drawing.Color.White;
            this.button_membersEnt.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_membersEnt.Location = new System.Drawing.Point(12, 320);
            this.button_membersEnt.Name = "button_membersEnt";
            this.button_membersEnt.Size = new System.Drawing.Size(150, 100);
            this.button_membersEnt.TabIndex = 0;
            this.button_membersEnt.Text = "회원 입장";
            this.button_membersEnt.UseVisualStyleBackColor = false;
            this.button_membersEnt.Click += new System.EventHandler(this.button_membersEnt_Click);
            // 
            // button_membersJoin
            // 
            this.button_membersJoin.BackColor = System.Drawing.Color.White;
            this.button_membersJoin.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_membersJoin.Location = new System.Drawing.Point(422, 320);
            this.button_membersJoin.Name = "button_membersJoin";
            this.button_membersJoin.Size = new System.Drawing.Size(150, 100);
            this.button_membersJoin.TabIndex = 0;
            this.button_membersJoin.Text = "회원가입";
            this.button_membersJoin.UseVisualStyleBackColor = false;
            // 
            // button_nonMembersEnt
            // 
            this.button_nonMembersEnt.BackColor = System.Drawing.Color.White;
            this.button_nonMembersEnt.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_nonMembersEnt.Location = new System.Drawing.Point(213, 320);
            this.button_nonMembersEnt.Name = "button_nonMembersEnt";
            this.button_nonMembersEnt.Size = new System.Drawing.Size(150, 100);
            this.button_nonMembersEnt.TabIndex = 0;
            this.button_nonMembersEnt.Text = "비회원 입장";
            this.button_nonMembersEnt.UseVisualStyleBackColor = false;
            // 
            // button_changeSeat
            // 
            this.button_changeSeat.BackColor = System.Drawing.Color.White;
            this.button_changeSeat.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_changeSeat.Location = new System.Drawing.Point(104, 462);
            this.button_changeSeat.Name = "button_changeSeat";
            this.button_changeSeat.Size = new System.Drawing.Size(150, 100);
            this.button_changeSeat.TabIndex = 0;
            this.button_changeSeat.Text = "자리 이동";
            this.button_changeSeat.UseVisualStyleBackColor = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_exit.Location = new System.Drawing.Point(331, 462);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 100);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "퇴실";
            this.button_exit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(134, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "어서오세요. xxx 입니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(152, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "회원가입 후 이용 시 혜택";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(234, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "사진??";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 762);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_membersJoin);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_changeSeat);
            this.Controls.Add(this.button_nonMembersEnt);
            this.Controls.Add(this.button_membersEnt);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FormHome";
            this.Text = "홈";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_membersEnt;
        private System.Windows.Forms.Button button_membersJoin;
        private System.Windows.Forms.Button button_nonMembersEnt;
        private System.Windows.Forms.Button button_changeSeat;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}