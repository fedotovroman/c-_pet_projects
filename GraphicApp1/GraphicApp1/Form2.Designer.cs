﻿
namespace GraphicApp1
{
    partial class Form2
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
            this.buttonleave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonleave
            // 
            this.buttonleave.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonleave.Location = new System.Drawing.Point(179, 191);
            this.buttonleave.Name = "buttonleave";
            this.buttonleave.Size = new System.Drawing.Size(185, 41);
            this.buttonleave.TabIndex = 0;
            this.buttonleave.Text = "Нажми меня!";
            this.buttonleave.UseVisualStyleBackColor = true;
            this.buttonleave.MouseEnter += new System.EventHandler(this.buttonleave_MouseEnter_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 428);
            this.Controls.Add(this.buttonleave);
            this.Name = "Form2";
            this.Text = "Нажми кнопку";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonleave;
    }
}