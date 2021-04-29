namespace FileMngm
{
    partial class frmFileMngm
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
            this.btnConv = new System.Windows.Forms.Button();
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.CMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDSearch = new System.Windows.Forms.Button();
            this.lblDS = new System.Windows.Forms.Label();
            this.btnHash = new System.Windows.Forms.Button();
            this.lblHash = new System.Windows.Forms.Label();
            this.dgErr = new System.Windows.Forms.DataGridView();
            this.CErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExtSort = new System.Windows.Forms.Button();
            this.odCars = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgErr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(0, 0);
            this.btnConv.Margin = new System.Windows.Forms.Padding(2);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(113, 26);
            this.btnConv.TabIndex = 0;
            this.btnConv.Text = "Преобразовать";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // dgCars
            // 
            this.dgCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMark,
            this.CV,
            this.CS});
            this.dgCars.Location = new System.Drawing.Point(12, 42);
            this.dgCars.Name = "dgCars";
            this.dgCars.Size = new System.Drawing.Size(458, 285);
            this.dgCars.TabIndex = 1;
            // 
            // CMark
            // 
            this.CMark.HeaderText = "Марка";
            this.CMark.Name = "CMark";
            this.CMark.Width = 200;
            // 
            // CV
            // 
            this.CV.HeaderText = "V";
            this.CV.Name = "CV";
            // 
            // CS
            // 
            this.CS.HeaderText = "S";
            this.CS.Name = "CS";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(133, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 26);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(269, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(123, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDSearch
            // 
            this.btnDSearch.Location = new System.Drawing.Point(409, 4);
            this.btnDSearch.Name = "btnDSearch";
            this.btnDSearch.Size = new System.Drawing.Size(104, 22);
            this.btnDSearch.TabIndex = 4;
            this.btnDSearch.Text = "Найти";
            this.btnDSearch.UseVisualStyleBackColor = true;
            this.btnDSearch.Click += new System.EventHandler(this.btnDSearch_Click);
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Location = new System.Drawing.Point(529, 7);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(0, 13);
            this.lblDS.TabIndex = 5;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(609, 4);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(69, 21);
            this.btnHash.TabIndex = 6;
            this.btnHash.Text = "Хэш";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(704, 7);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(0, 13);
            this.lblHash.TabIndex = 7;
            // 
            // dgErr
            // 
            this.dgErr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgErr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CErr});
            this.dgErr.Location = new System.Drawing.Point(491, 45);
            this.dgErr.Name = "dgErr";
            this.dgErr.Size = new System.Drawing.Size(338, 282);
            this.dgErr.TabIndex = 8;
            // 
            // CErr
            // 
            this.CErr.HeaderText = "Ошибка";
            this.CErr.Name = "CErr";
            this.CErr.Width = 500;
            // 
            // btnExtSort
            // 
            this.btnExtSort.Location = new System.Drawing.Point(705, 5);
            this.btnExtSort.Name = "btnExtSort";
            this.btnExtSort.Size = new System.Drawing.Size(75, 23);
            this.btnExtSort.TabIndex = 9;
            this.btnExtSort.Text = "ExtSort";
            this.btnExtSort.UseVisualStyleBackColor = true;
            this.btnExtSort.Click += new System.EventHandler(this.btnExtSort_Click);
            // 
            // odCars
            // 
            this.odCars.FileName = "`";
            // 
            // frmFileMngm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 478);
            this.Controls.Add(this.btnExtSort);
            this.Controls.Add(this.dgErr);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.btnDSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgCars);
            this.Controls.Add(this.btnConv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFileMngm";
            this.Text = "Управление файлами";
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.DataGridView dgCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDSearch;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.DataGridView dgErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CErr;
        private System.Windows.Forms.Button btnExtSort;
        private System.Windows.Forms.OpenFileDialog odCars;
    }
}

