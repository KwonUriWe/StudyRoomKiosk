namespace StudyRoomKiosk
{
    partial class FormSelectSeatTime
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_seat = new System.Windows.Forms.GroupBox();
            this.groupBox_today = new System.Windows.Forms.GroupBox();
            this.radioButton_allDay = new System.Windows.Forms.RadioButton();
            this.radioButton_9Hours = new System.Windows.Forms.RadioButton();
            this.radioButton_7Hours = new System.Windows.Forms.RadioButton();
            this.radioButton_5Hours = new System.Windows.Forms.RadioButton();
            this.radioButton_3Hours = new System.Windows.Forms.RadioButton();
            this.radioButton_2Hours = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_longTime = new System.Windows.Forms.GroupBox();
            this.radioButton_8Weeks = new System.Windows.Forms.RadioButton();
            this.radioButton_2Weeks = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton_4Weeks = new System.Windows.Forms.RadioButton();
            this.radioButton_1Weeks = new System.Windows.Forms.RadioButton();
            this.radioButton_3Days = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button_goHome = new System.Windows.Forms.Button();
            this.button_goJoin = new System.Windows.Forms.Button();
            this.groupBox_seat.SuspendLayout();
            this.groupBox_today.SuspendLayout();
            this.groupBox_longTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.Location = new System.Drawing.Point(250, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "출입문";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_seat
            // 
            this.groupBox_seat.BackColor = System.Drawing.Color.White;
            this.groupBox_seat.Controls.Add(this.label1);
            this.groupBox_seat.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox_seat.Location = new System.Drawing.Point(12, 298);
            this.groupBox_seat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_seat.Name = "groupBox_seat";
            this.groupBox_seat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_seat.Size = new System.Drawing.Size(560, 651);
            this.groupBox_seat.TabIndex = 1;
            this.groupBox_seat.TabStop = false;
            // 
            // groupBox_today
            // 
            this.groupBox_today.Controls.Add(this.radioButton_allDay);
            this.groupBox_today.Controls.Add(this.radioButton_9Hours);
            this.groupBox_today.Controls.Add(this.radioButton_7Hours);
            this.groupBox_today.Controls.Add(this.radioButton_5Hours);
            this.groupBox_today.Controls.Add(this.radioButton_3Hours);
            this.groupBox_today.Controls.Add(this.radioButton_2Hours);
            this.groupBox_today.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.groupBox_today.Location = new System.Drawing.Point(12, 96);
            this.groupBox_today.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_today.Name = "groupBox_today";
            this.groupBox_today.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_today.Size = new System.Drawing.Size(560, 80);
            this.groupBox_today.TabIndex = 2;
            this.groupBox_today.TabStop = false;
            this.groupBox_today.Text = "당일이용권";
            // 
            // radioButton_allDay
            // 
            this.radioButton_allDay.AutoSize = true;
            this.radioButton_allDay.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_allDay.Location = new System.Drawing.Point(383, 47);
            this.radioButton_allDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_allDay.Name = "radioButton_allDay";
            this.radioButton_allDay.Size = new System.Drawing.Size(118, 23);
            this.radioButton_allDay.TabIndex = 0;
            this.radioButton_allDay.TabStop = true;
            this.radioButton_allDay.Text = "종일-12,000원";
            this.radioButton_allDay.UseVisualStyleBackColor = true;
            // 
            // radioButton_9Hours
            // 
            this.radioButton_9Hours.AutoSize = true;
            this.radioButton_9Hours.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_9Hours.Location = new System.Drawing.Point(196, 47);
            this.radioButton_9Hours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_9Hours.Name = "radioButton_9Hours";
            this.radioButton_9Hours.Size = new System.Drawing.Size(126, 23);
            this.radioButton_9Hours.TabIndex = 0;
            this.radioButton_9Hours.TabStop = true;
            this.radioButton_9Hours.Text = "9시간-10,000원";
            this.radioButton_9Hours.UseVisualStyleBackColor = true;
            // 
            // radioButton_7Hours
            // 
            this.radioButton_7Hours.AutoSize = true;
            this.radioButton_7Hours.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_7Hours.Location = new System.Drawing.Point(6, 47);
            this.radioButton_7Hours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_7Hours.Name = "radioButton_7Hours";
            this.radioButton_7Hours.Size = new System.Drawing.Size(118, 23);
            this.radioButton_7Hours.TabIndex = 0;
            this.radioButton_7Hours.TabStop = true;
            this.radioButton_7Hours.Text = "7시간-8,000원";
            this.radioButton_7Hours.UseVisualStyleBackColor = true;
            // 
            // radioButton_5Hours
            // 
            this.radioButton_5Hours.AutoSize = true;
            this.radioButton_5Hours.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_5Hours.Location = new System.Drawing.Point(383, 22);
            this.radioButton_5Hours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_5Hours.Name = "radioButton_5Hours";
            this.radioButton_5Hours.Size = new System.Drawing.Size(118, 23);
            this.radioButton_5Hours.TabIndex = 0;
            this.radioButton_5Hours.TabStop = true;
            this.radioButton_5Hours.Text = "5시간-6,000원";
            this.radioButton_5Hours.UseVisualStyleBackColor = true;
            // 
            // radioButton_3Hours
            // 
            this.radioButton_3Hours.AutoSize = true;
            this.radioButton_3Hours.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_3Hours.Location = new System.Drawing.Point(196, 22);
            this.radioButton_3Hours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_3Hours.Name = "radioButton_3Hours";
            this.radioButton_3Hours.Size = new System.Drawing.Size(118, 23);
            this.radioButton_3Hours.TabIndex = 0;
            this.radioButton_3Hours.TabStop = true;
            this.radioButton_3Hours.Text = "3시간-4,000원";
            this.radioButton_3Hours.UseVisualStyleBackColor = true;
            // 
            // radioButton_2Hours
            // 
            this.radioButton_2Hours.AutoSize = true;
            this.radioButton_2Hours.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_2Hours.Location = new System.Drawing.Point(6, 22);
            this.radioButton_2Hours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_2Hours.Name = "radioButton_2Hours";
            this.radioButton_2Hours.Size = new System.Drawing.Size(118, 23);
            this.radioButton_2Hours.TabIndex = 0;
            this.radioButton_2Hours.TabStop = true;
            this.radioButton_2Hours.Text = "2시간-3,000원";
            this.radioButton_2Hours.UseVisualStyleBackColor = true;
            // 
            // groupBox_longTime
            // 
            this.groupBox_longTime.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.groupBox_longTime.Controls.Add(this.radioButton_8Weeks);
            this.groupBox_longTime.Controls.Add(this.radioButton_2Weeks);
            this.groupBox_longTime.Controls.Add(this.radioButton9);
            this.groupBox_longTime.Controls.Add(this.radioButton_4Weeks);
            this.groupBox_longTime.Controls.Add(this.radioButton_1Weeks);
            this.groupBox_longTime.Controls.Add(this.radioButton_3Days);
            this.groupBox_longTime.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.groupBox_longTime.Location = new System.Drawing.Point(12, 178);
            this.groupBox_longTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_longTime.Name = "groupBox_longTime";
            this.groupBox_longTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_longTime.Size = new System.Drawing.Size(560, 80);
            this.groupBox_longTime.TabIndex = 2;
            this.groupBox_longTime.TabStop = false;
            this.groupBox_longTime.Text = "장기 이용권";
            // 
            // radioButton_8Weeks
            // 
            this.radioButton_8Weeks.AutoSize = true;
            this.radioButton_8Weeks.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_8Weeks.Location = new System.Drawing.Point(383, 49);
            this.radioButton_8Weeks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_8Weeks.Name = "radioButton_8Weeks";
            this.radioButton_8Weeks.Size = new System.Drawing.Size(158, 23);
            this.radioButton_8Weeks.TabIndex = 0;
            this.radioButton_8Weeks.TabStop = true;
            this.radioButton_8Weeks.Text = "8주(56일)-240,000원";
            this.radioButton_8Weeks.UseVisualStyleBackColor = true;
            // 
            // radioButton_2Weeks
            // 
            this.radioButton_2Weeks.AutoSize = true;
            this.radioButton_2Weeks.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_2Weeks.Location = new System.Drawing.Point(9, 50);
            this.radioButton_2Weeks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_2Weeks.Name = "radioButton_2Weeks";
            this.radioButton_2Weeks.Size = new System.Drawing.Size(150, 23);
            this.radioButton_2Weeks.TabIndex = 0;
            this.radioButton_2Weeks.TabStop = true;
            this.radioButton_2Weeks.Text = "2주(14일)-84,000원";
            this.radioButton_2Weeks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_2Weeks.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton9.Location = new System.Drawing.Point(196, 23);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(112, 23);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "5일-43,000원";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton_4Weeks
            // 
            this.radioButton_4Weeks.AutoSize = true;
            this.radioButton_4Weeks.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_4Weeks.Location = new System.Drawing.Point(196, 49);
            this.radioButton_4Weeks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_4Weeks.Name = "radioButton_4Weeks";
            this.radioButton_4Weeks.Size = new System.Drawing.Size(158, 23);
            this.radioButton_4Weeks.TabIndex = 0;
            this.radioButton_4Weeks.TabStop = true;
            this.radioButton_4Weeks.Text = "4주(28일)-130,000원";
            this.radioButton_4Weeks.UseVisualStyleBackColor = true;
            // 
            // radioButton_1Weeks
            // 
            this.radioButton_1Weeks.AutoSize = true;
            this.radioButton_1Weeks.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_1Weeks.Location = new System.Drawing.Point(383, 24);
            this.radioButton_1Weeks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_1Weeks.Name = "radioButton_1Weeks";
            this.radioButton_1Weeks.Size = new System.Drawing.Size(142, 23);
            this.radioButton_1Weeks.TabIndex = 0;
            this.radioButton_1Weeks.TabStop = true;
            this.radioButton_1Weeks.Text = "1주(7일)-56,000원";
            this.radioButton_1Weeks.UseVisualStyleBackColor = true;
            // 
            // radioButton_3Days
            // 
            this.radioButton_3Days.AutoSize = true;
            this.radioButton_3Days.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.radioButton_3Days.Location = new System.Drawing.Point(9, 24);
            this.radioButton_3Days.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_3Days.Name = "radioButton_3Days";
            this.radioButton_3Days.Size = new System.Drawing.Size(112, 23);
            this.radioButton_3Days.TabIndex = 0;
            this.radioButton_3Days.TabStop = true;
            this.radioButton_3Days.Text = "3일-27,000원";
            this.radioButton_3Days.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label3.Location = new System.Drawing.Point(190, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "사용가능";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label2.Location = new System.Drawing.Point(68, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "사용중";
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button25.Location = new System.Drawing.Point(12, 262);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 38);
            this.button25.TabIndex = 5;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(130, 262);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(50, 38);
            this.button26.TabIndex = 6;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button_goHome
            // 
            this.button_goHome.BackColor = System.Drawing.SystemColors.Control;
            this.button_goHome.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_goHome.Location = new System.Drawing.Point(440, 58);
            this.button_goHome.Name = "button_goHome";
            this.button_goHome.Size = new System.Drawing.Size(132, 42);
            this.button_goHome.TabIndex = 9;
            this.button_goHome.Text = "처음으로";
            this.button_goHome.UseVisualStyleBackColor = false;
            this.button_goHome.Click += new System.EventHandler(this.button_goHome_Click);
            // 
            // button_goJoin
            // 
            this.button_goJoin.BackColor = System.Drawing.SystemColors.Control;
            this.button_goJoin.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.button_goJoin.Location = new System.Drawing.Point(302, 58);
            this.button_goJoin.Name = "button_goJoin";
            this.button_goJoin.Size = new System.Drawing.Size(132, 42);
            this.button_goJoin.TabIndex = 10;
            this.button_goJoin.Text = "회원가입";
            this.button_goJoin.UseVisualStyleBackColor = false;
            // 
            // FormSelectSeatTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 962);
            this.Controls.Add(this.button_goJoin);
            this.Controls.Add(this.button_goHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.groupBox_longTime);
            this.Controls.Add(this.groupBox_seat);
            this.Controls.Add(this.groupBox_today);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSelectSeatTime";
            this.Text = "자리선택";
            this.groupBox_seat.ResumeLayout(false);
            this.groupBox_seat.PerformLayout();
            this.groupBox_today.ResumeLayout(false);
            this.groupBox_today.PerformLayout();
            this.groupBox_longTime.ResumeLayout(false);
            this.groupBox_longTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_seat;
        private System.Windows.Forms.GroupBox groupBox_today;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton_7Hours;
        private System.Windows.Forms.RadioButton radioButton_2Hours;
        private System.Windows.Forms.RadioButton radioButton_allDay;
        private System.Windows.Forms.RadioButton radioButton_9Hours;
        private System.Windows.Forms.RadioButton radioButton_5Hours;
        private System.Windows.Forms.RadioButton radioButton_3Hours;
        private System.Windows.Forms.GroupBox groupBox_longTime;
        private System.Windows.Forms.RadioButton radioButton_8Weeks;
        private System.Windows.Forms.RadioButton radioButton_2Weeks;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton_4Weeks;
        private System.Windows.Forms.RadioButton radioButton_1Weeks;
        private System.Windows.Forms.RadioButton radioButton_3Days;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button_goHome;
        private System.Windows.Forms.Button button_goJoin;
    }
}