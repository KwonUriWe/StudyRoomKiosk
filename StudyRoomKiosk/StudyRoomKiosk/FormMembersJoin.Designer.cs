namespace StudyRoomKiosk
{
    partial class FormMembersJoin
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
            this.button_goHome = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_dateBirth = new System.Windows.Forms.TextBox();
            this.label_dateBirth = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_newsAgency = new System.Windows.Forms.Label();
            this.textBox_phoneNum = new System.Windows.Forms.TextBox();
            this.textBox_crt = new System.Windows.Forms.TextBox();
            this.label_phoneNum = new System.Windows.Forms.Label();
            this.button_getCrt = new System.Windows.Forms.Button();
            this.button_join = new System.Windows.Forms.Button();
            this.comboBox_newsAgency = new System.Windows.Forms.ComboBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.groupBox_getInfo = new System.Windows.Forms.GroupBox();
            this.groupBox_getInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_goHome
            // 
            this.button_goHome.BackColor = System.Drawing.SystemColors.Control;
            this.button_goHome.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_goHome.Location = new System.Drawing.Point(440, 304);
            this.button_goHome.Name = "button_goHome";
            this.button_goHome.Size = new System.Drawing.Size(132, 42);
            this.button_goHome.TabIndex = 4;
            this.button_goHome.Text = "처음으로";
            this.button_goHome.UseVisualStyleBackColor = false;
            this.button_goHome.Click += new System.EventHandler(this.button_goHome_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.textBox_name.Location = new System.Drawing.Point(6, 60);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(388, 43);
            this.textBox_name.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_name.Location = new System.Drawing.Point(6, 33);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(37, 19);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "이름";
            // 
            // textBox_dateBirth
            // 
            this.textBox_dateBirth.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.textBox_dateBirth.Location = new System.Drawing.Point(6, 147);
            this.textBox_dateBirth.Name = "textBox_dateBirth";
            this.textBox_dateBirth.Size = new System.Drawing.Size(388, 43);
            this.textBox_dateBirth.TabIndex = 2;
            // 
            // label_dateBirth
            // 
            this.label_dateBirth.AutoSize = true;
            this.label_dateBirth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_dateBirth.Location = new System.Drawing.Point(6, 120);
            this.label_dateBirth.Name = "label_dateBirth";
            this.label_dateBirth.Size = new System.Drawing.Size(65, 19);
            this.label_dateBirth.TabIndex = 3;
            this.label_dateBirth.Text = "생년월일";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_gender.Location = new System.Drawing.Point(6, 210);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(37, 19);
            this.label_gender.TabIndex = 3;
            this.label_gender.Text = "성별";
            // 
            // label_newsAgency
            // 
            this.label_newsAgency.AutoSize = true;
            this.label_newsAgency.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_newsAgency.Location = new System.Drawing.Point(6, 309);
            this.label_newsAgency.Name = "label_newsAgency";
            this.label_newsAgency.Size = new System.Drawing.Size(51, 19);
            this.label_newsAgency.TabIndex = 3;
            this.label_newsAgency.Text = "통신사";
            // 
            // textBox_phoneNum
            // 
            this.textBox_phoneNum.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.textBox_phoneNum.Location = new System.Drawing.Point(6, 427);
            this.textBox_phoneNum.Name = "textBox_phoneNum";
            this.textBox_phoneNum.Size = new System.Drawing.Size(265, 43);
            this.textBox_phoneNum.TabIndex = 2;
            // 
            // textBox_crt
            // 
            this.textBox_crt.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.textBox_crt.Location = new System.Drawing.Point(6, 487);
            this.textBox_crt.Name = "textBox_crt";
            this.textBox_crt.Size = new System.Drawing.Size(388, 43);
            this.textBox_crt.TabIndex = 2;
            // 
            // label_phoneNum
            // 
            this.label_phoneNum.AutoSize = true;
            this.label_phoneNum.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label_phoneNum.Location = new System.Drawing.Point(6, 397);
            this.label_phoneNum.Name = "label_phoneNum";
            this.label_phoneNum.Size = new System.Drawing.Size(65, 19);
            this.label_phoneNum.TabIndex = 3;
            this.label_phoneNum.Text = "휴대전화";
            // 
            // button_getCrt
            // 
            this.button_getCrt.BackColor = System.Drawing.SystemColors.Control;
            this.button_getCrt.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_getCrt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_getCrt.Location = new System.Drawing.Point(277, 424);
            this.button_getCrt.Name = "button_getCrt";
            this.button_getCrt.Size = new System.Drawing.Size(117, 50);
            this.button_getCrt.TabIndex = 4;
            this.button_getCrt.Text = "인증번호 받기";
            this.button_getCrt.UseVisualStyleBackColor = false;
            // 
            // button_join
            // 
            this.button_join.BackColor = System.Drawing.SystemColors.Control;
            this.button_join.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_join.Location = new System.Drawing.Point(9, 545);
            this.button_join.Name = "button_join";
            this.button_join.Size = new System.Drawing.Size(385, 50);
            this.button_join.TabIndex = 5;
            this.button_join.Text = "가입하기";
            this.button_join.UseVisualStyleBackColor = false;
            this.button_join.Click += new System.EventHandler(this.button_join_Click);
            // 
            // comboBox_newsAgency
            // 
            this.comboBox_newsAgency.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.comboBox_newsAgency.FormattingEnabled = true;
            this.comboBox_newsAgency.Items.AddRange(new object[] {
            "SKT",
            "KT",
            "LG",
            "알뜰폰"});
            this.comboBox_newsAgency.Location = new System.Drawing.Point(9, 337);
            this.comboBox_newsAgency.Name = "comboBox_newsAgency";
            this.comboBox_newsAgency.Size = new System.Drawing.Size(385, 45);
            this.comboBox_newsAgency.TabIndex = 6;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBox_gender.Location = new System.Drawing.Point(9, 241);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(385, 45);
            this.comboBox_gender.TabIndex = 7;
            // 
            // groupBox_getInfo
            // 
            this.groupBox_getInfo.Controls.Add(this.comboBox_gender);
            this.groupBox_getInfo.Controls.Add(this.comboBox_newsAgency);
            this.groupBox_getInfo.Controls.Add(this.button_join);
            this.groupBox_getInfo.Controls.Add(this.button_getCrt);
            this.groupBox_getInfo.Controls.Add(this.label_phoneNum);
            this.groupBox_getInfo.Controls.Add(this.textBox_crt);
            this.groupBox_getInfo.Controls.Add(this.textBox_phoneNum);
            this.groupBox_getInfo.Controls.Add(this.label_newsAgency);
            this.groupBox_getInfo.Controls.Add(this.label_gender);
            this.groupBox_getInfo.Controls.Add(this.label_dateBirth);
            this.groupBox_getInfo.Controls.Add(this.textBox_dateBirth);
            this.groupBox_getInfo.Controls.Add(this.label_name);
            this.groupBox_getInfo.Controls.Add(this.textBox_name);
            this.groupBox_getInfo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.groupBox_getInfo.Location = new System.Drawing.Point(81, 352);
            this.groupBox_getInfo.Name = "groupBox_getInfo";
            this.groupBox_getInfo.Size = new System.Drawing.Size(400, 598);
            this.groupBox_getInfo.TabIndex = 3;
            this.groupBox_getInfo.TabStop = false;
            // 
            // FormMembersJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 962);
            this.Controls.Add(this.button_goHome);
            this.Controls.Add(this.groupBox_getInfo);
            this.Name = "FormMembersJoin";
            this.Text = "회원가입";
            this.groupBox_getInfo.ResumeLayout(false);
            this.groupBox_getInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_goHome;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_dateBirth;
        private System.Windows.Forms.Label label_dateBirth;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_newsAgency;
        private System.Windows.Forms.TextBox textBox_phoneNum;
        private System.Windows.Forms.TextBox textBox_crt;
        private System.Windows.Forms.Label label_phoneNum;
        private System.Windows.Forms.Button button_getCrt;
        private System.Windows.Forms.Button button_join;
        private System.Windows.Forms.ComboBox comboBox_newsAgency;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.GroupBox groupBox_getInfo;
    }
}