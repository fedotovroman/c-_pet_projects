namespace Preproc
{
    partial class PreprocF
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
            this.ofdMD = new System.Windows.Forms.OpenFileDialog();
            this.btnPreproc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdMD
            // 
            this.ofdMD.FileName = "openFileDialog1";
            // 
            // btnPreproc
            // 
            this.btnPreproc.Location = new System.Drawing.Point(38, 25);
            this.btnPreproc.Name = "btnPreproc";
            this.btnPreproc.Size = new System.Drawing.Size(75, 23);
            this.btnPreproc.TabIndex = 0;
            this.btnPreproc.Text = "Preproc";
            this.btnPreproc.UseVisualStyleBackColor = true;
            this.btnPreproc.Click += new System.EventHandler(this.btnPreproc_Click);
            // 
            // PreprocF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 260);
            this.Controls.Add(this.btnPreproc);
            this.Name = "PreprocF";
            this.Text = "Создание хранимой процедуры (препроцессор)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdMD;
        private System.Windows.Forms.Button btnPreproc;
    }
}

