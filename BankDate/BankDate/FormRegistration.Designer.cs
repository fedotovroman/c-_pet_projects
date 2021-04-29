namespace BankDate
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.b_login = new System.Windows.Forms.Button();
            this.b_reg_exit = new System.Windows.Forms.Button();
            this.gr_box_pers = new System.Windows.Forms.GroupBox();
            this.mobphlab = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.thnamelab = new System.Windows.Forms.TextBox();
            this.passwordlab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.namelab = new System.Windows.Forms.TextBox();
            this.lastnlab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group_box_pers2 = new System.Windows.Forms.GroupBox();
            this.passnumlab = new System.Windows.Forms.TextBox();
            this.passserlab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gr_box_pers.SuspendLayout();
            this.group_box_pers2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация физ. лица в ПАО «Банк» в качестве вкладчика\r\n";
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(333, 427);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(124, 27);
            this.b_login.TabIndex = 1;
            this.b_login.Text = "ОK";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_reg_exit
            // 
            this.b_reg_exit.Location = new System.Drawing.Point(466, 427);
            this.b_reg_exit.Name = "b_reg_exit";
            this.b_reg_exit.Size = new System.Drawing.Size(131, 27);
            this.b_reg_exit.TabIndex = 2;
            this.b_reg_exit.Text = "Отмена";
            this.b_reg_exit.UseVisualStyleBackColor = true;
            this.b_reg_exit.Click += new System.EventHandler(this.b_reg_exit_Click);
            // 
            // gr_box_pers
            // 
            this.gr_box_pers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gr_box_pers.Controls.Add(this.mobphlab);
            this.gr_box_pers.Controls.Add(this.label8);
            this.gr_box_pers.Controls.Add(this.dtpicker);
            this.gr_box_pers.Controls.Add(this.thnamelab);
            this.gr_box_pers.Controls.Add(this.passwordlab);
            this.gr_box_pers.Controls.Add(this.label6);
            this.gr_box_pers.Controls.Add(this.namelab);
            this.gr_box_pers.Controls.Add(this.lastnlab);
            this.gr_box_pers.Controls.Add(this.label5);
            this.gr_box_pers.Controls.Add(this.label4);
            this.gr_box_pers.Controls.Add(this.label3);
            this.gr_box_pers.Controls.Add(this.label2);
            this.gr_box_pers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gr_box_pers.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gr_box_pers.Location = new System.Drawing.Point(22, 38);
            this.gr_box_pers.Name = "gr_box_pers";
            this.gr_box_pers.Size = new System.Drawing.Size(575, 230);
            this.gr_box_pers.TabIndex = 3;
            this.gr_box_pers.TabStop = false;
            this.gr_box_pers.Text = "Персональные данные";
            // 
            // mobphlab
            // 
            this.mobphlab.Location = new System.Drawing.Point(168, 201);
            this.mobphlab.Name = "mobphlab";
            this.mobphlab.Size = new System.Drawing.Size(379, 26);
            this.mobphlab.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Мобильный телефон";
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(168, 131);
            this.dtpicker.MaxDate = new System.DateTime(2020, 10, 18, 0, 0, 0, 0);
            this.dtpicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(180, 26);
            this.dtpicker.TabIndex = 4;
            this.dtpicker.Value = new System.DateTime(2020, 10, 18, 0, 0, 0, 0);
            // 
            // thnamelab
            // 
            this.thnamelab.Location = new System.Drawing.Point(168, 99);
            this.thnamelab.Name = "thnamelab";
            this.thnamelab.Size = new System.Drawing.Size(379, 26);
            this.thnamelab.TabIndex = 7;
            // 
            // passwordlab
            // 
            this.passwordlab.Location = new System.Drawing.Point(168, 163);
            this.passwordlab.Name = "passwordlab";
            this.passwordlab.Size = new System.Drawing.Size(379, 26);
            this.passwordlab.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пароль пользователя:";
            // 
            // namelab
            // 
            this.namelab.Location = new System.Drawing.Point(168, 65);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(379, 26);
            this.namelab.TabIndex = 6;
            // 
            // lastnlab
            // 
            this.lastnlab.Location = new System.Drawing.Point(168, 30);
            this.lastnlab.Name = "lastnlab";
            this.lastnlab.Size = new System.Drawing.Size(379, 26);
            this.lastnlab.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Отчество: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия: ";
            // 
            // group_box_pers2
            // 
            this.group_box_pers2.Controls.Add(this.passnumlab);
            this.group_box_pers2.Controls.Add(this.passserlab);
            this.group_box_pers2.Controls.Add(this.label7);
            this.group_box_pers2.Controls.Add(this.label9);
            this.group_box_pers2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_box_pers2.Location = new System.Drawing.Point(22, 301);
            this.group_box_pers2.Name = "group_box_pers2";
            this.group_box_pers2.Size = new System.Drawing.Size(575, 120);
            this.group_box_pers2.TabIndex = 4;
            this.group_box_pers2.TabStop = false;
            this.group_box_pers2.Text = "Паспортные данные";
            // 
            // passnumlab
            // 
            this.passnumlab.Location = new System.Drawing.Point(168, 71);
            this.passnumlab.Name = "passnumlab";
            this.passnumlab.Size = new System.Drawing.Size(379, 26);
            this.passnumlab.TabIndex = 11;
            // 
            // passserlab
            // 
            this.passserlab.Location = new System.Drawing.Point(168, 36);
            this.passserlab.Name = "passserlab";
            this.passserlab.Size = new System.Drawing.Size(379, 26);
            this.passserlab.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Серия документа:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Номер документа:";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 465);
            this.Controls.Add(this.group_box_pers2);
            this.Controls.Add(this.gr_box_pers);
            this.Controls.Add(this.b_reg_exit);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация ";
            
            this.gr_box_pers.ResumeLayout(false);
            this.gr_box_pers.PerformLayout();
            this.group_box_pers2.ResumeLayout(false);
            this.group_box_pers2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_reg_exit;
        private System.Windows.Forms.GroupBox gr_box_pers;
        private System.Windows.Forms.TextBox thnamelab;
        private System.Windows.Forms.TextBox namelab;
        private System.Windows.Forms.TextBox lastnlab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.GroupBox group_box_pers2;
        private System.Windows.Forms.TextBox passnumlab;
        private System.Windows.Forms.TextBox passserlab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordlab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mobphlab;
        private System.Windows.Forms.Label label8;
    }
}