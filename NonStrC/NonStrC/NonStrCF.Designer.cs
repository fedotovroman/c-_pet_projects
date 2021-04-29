namespace NonStrC
{
    partial class NonStrCF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConv = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(26, 32);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(75, 23);
            this.btnConv.TabIndex = 0;
            this.btnConv.Text = "Convert";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(30, 77);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 1;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // NonStrCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 303);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnConv);
            this.Name = "NonStrCF";
            this.Text = "Non strong merge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.Button btnMerge;
    }
}

