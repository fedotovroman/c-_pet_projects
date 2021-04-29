namespace CRC
{
    partial class CRCF
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgCRC = new System.Windows.Forms.DataGridView();
            this.CRCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCRC = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCRC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCRC
            // 
            this.dgCRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCRC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CRCA});
            this.dgCRC.Location = new System.Drawing.Point(24, 9);
            this.dgCRC.Name = "dgCRC";
            this.dgCRC.Size = new System.Drawing.Size(161, 425);
            this.dgCRC.TabIndex = 0;
            // 
            // CRCA
            // 
            this.CRCA.HeaderText = "Array";
            this.CRCA.Name = "CRCA";
            // 
            // lblCRC
            // 
            this.lblCRC.AutoSize = true;
            this.lblCRC.Location = new System.Drawing.Point(38, 448);
            this.lblCRC.Name = "lblCRC";
            this.lblCRC.Size = new System.Drawing.Size(0, 15);
            this.lblCRC.TabIndex = 1;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(207, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(16, 15);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "N";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(254, 9);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(210, 47);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(15, 15);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(259, 42);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(94, 20);
            this.tbB.TabIndex = 5;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(208, 82);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 6;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(208, 124);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 24);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(210, 206);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(210, 246);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // CRCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 530);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblCRC);
            this.Controls.Add(this.dgCRC);
            this.Name = "CRCF";
            this.Text = "Check Sum";
            ((System.ComponentModel.ISupportInitialize)(this.dgCRC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRCA;
        private System.Windows.Forms.Label lblCRC;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCheck;
    }
}

