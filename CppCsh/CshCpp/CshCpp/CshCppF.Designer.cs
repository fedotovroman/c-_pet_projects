﻿namespace CshCpp
{
    partial class CshCppF
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
            this.lbl_CoI = new System.Windows.Forms.Label();
            this.tbCI = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnCsh = new System.Windows.Forms.Button();
            this.lblCsh = new System.Windows.Forms.Label();
            this.btnCpp = new System.Windows.Forms.Button();
            this.lblCpp = new System.Windows.Forms.Label();
            this.lblXMM = new System.Windows.Forms.Label();
            this.btnXMM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CoI
            // 
            this.lbl_CoI.AutoSize = true;
            this.lbl_CoI.Location = new System.Drawing.Point(17, 26);
            this.lbl_CoI.Name = "lbl_CoI";
            this.lbl_CoI.Size = new System.Drawing.Size(80, 17);
            this.lbl_CoI.TabIndex = 0;
            this.lbl_CoI.Text = "Items count";
            // 
            // tbCI
            // 
            this.tbCI.Location = new System.Drawing.Point(123, 21);
            this.tbCI.Name = "tbCI";
            this.tbCI.Size = new System.Drawing.Size(143, 22);
            this.tbCI.TabIndex = 1;
            this.tbCI.Text = "10";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 58);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Gen";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnCsh
            // 
            this.btnCsh.Location = new System.Drawing.Point(12, 101);
            this.btnCsh.Name = "btnCsh";
            this.btnCsh.Size = new System.Drawing.Size(75, 26);
            this.btnCsh.TabIndex = 3;
            this.btnCsh.Text = "C#";
            this.btnCsh.UseVisualStyleBackColor = true;
            this.btnCsh.Click += new System.EventHandler(this.btnCsh_Click);
            // 
            // lblCsh
            // 
            this.lblCsh.AutoSize = true;
            this.lblCsh.Location = new System.Drawing.Point(122, 101);
            this.lblCsh.Name = "lblCsh";
            this.lblCsh.Size = new System.Drawing.Size(50, 17);
            this.lblCsh.TabIndex = 4;
            this.lblCsh.Text = "Out c#";
            // 
            // btnCpp
            // 
            this.btnCpp.Location = new System.Drawing.Point(13, 143);
            this.btnCpp.Name = "btnCpp";
            this.btnCpp.Size = new System.Drawing.Size(75, 23);
            this.btnCpp.TabIndex = 5;
            this.btnCpp.Text = "C++";
            this.btnCpp.UseVisualStyleBackColor = true;
            this.btnCpp.Click += new System.EventHandler(this.btnCpp_Click);
            // 
            // lblCpp
            // 
            this.lblCpp.AutoSize = true;
            this.lblCpp.Location = new System.Drawing.Point(123, 147);
            this.lblCpp.Name = "lblCpp";
            this.lblCpp.Size = new System.Drawing.Size(60, 17);
            this.lblCpp.TabIndex = 6;
            this.lblCpp.Text = "Out C++";
            // 
            // lblXMM
            // 
            this.lblXMM.AutoSize = true;
            this.lblXMM.Location = new System.Drawing.Point(124, 182);
            this.lblXMM.Name = "lblXMM";
            this.lblXMM.Size = new System.Drawing.Size(0, 17);
            this.lblXMM.TabIndex = 7;
            // 
            // btnXMM
            // 
            this.btnXMM.Location = new System.Drawing.Point(18, 178);
            this.btnXMM.Name = "btnXMM";
            this.btnXMM.Size = new System.Drawing.Size(70, 30);
            this.btnXMM.TabIndex = 8;
            this.btnXMM.Text = "XMM";
            this.btnXMM.UseVisualStyleBackColor = true;
            this.btnXMM.Click += new System.EventHandler(this.btnXMM_Click);
            // 
            // CshCppF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 253);
            this.Controls.Add(this.btnXMM);
            this.Controls.Add(this.lblXMM);
            this.Controls.Add(this.lblCpp);
            this.Controls.Add(this.btnCpp);
            this.Controls.Add(this.lblCsh);
            this.Controls.Add(this.btnCsh);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.tbCI);
            this.Controls.Add(this.lbl_CoI);
            this.Name = "CshCppF";
            this.Text = "C# C++ DLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CoI;
        private System.Windows.Forms.TextBox tbCI;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnCsh;
        private System.Windows.Forms.Label lblCsh;
        private System.Windows.Forms.Button btnCpp;
        private System.Windows.Forms.Label lblCpp;
        private System.Windows.Forms.Label lblXMM;
        private System.Windows.Forms.Button btnXMM;
    }
}

