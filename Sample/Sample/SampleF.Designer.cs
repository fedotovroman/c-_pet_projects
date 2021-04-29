namespace Sample
{
    partial class SampleF
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
            this.odCars = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.CM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 42);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 30);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Read";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dgCars
            // 
            this.dgCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CM,
            this.CV,
            this.CS});
            this.dgCars.Location = new System.Drawing.Point(15, 110);
            this.dgCars.Name = "dgCars";
            this.dgCars.Size = new System.Drawing.Size(349, 150);
            this.dgCars.TabIndex = 1;
            // 
            // CM
            // 
            this.CM.HeaderText = "Mark";
            this.CM.Name = "CM";
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
            // SampleF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 260);
            this.Controls.Add(this.dgCars);
            this.Controls.Add(this.btnOpen);
            this.Name = "SampleF";
            this.Text = "Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog odCars;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dgCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn CM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS;
    }
}

