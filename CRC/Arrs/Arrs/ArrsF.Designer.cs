namespace Arrs
{
    partial class frmArrs
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
            this.dgArr = new System.Windows.Forms.DataGridView();
            this.Arr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblN = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblIm = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbSI = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnDSearch = new System.Windows.Forms.Button();
            this.btnPS = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgArr
            // 
            this.dgArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arr});
            this.dgArr.Location = new System.Drawing.Point(9, 10);
            this.dgArr.Margin = new System.Windows.Forms.Padding(2);
            this.dgArr.Name = "dgArr";
            this.dgArr.RowTemplate.Height = 24;
            this.dgArr.Size = new System.Drawing.Size(180, 317);
            this.dgArr.TabIndex = 0;
            // 
            // Arr
            // 
            this.Arr.HeaderText = "Массив";
            this.Arr.Name = "Arr";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(194, 20);
            this.lblN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(16, 15);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "N";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(194, 43);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(15, 15);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B";
            // 
            // lblIm
            // 
            this.lblIm.AutoSize = true;
            this.lblIm.Location = new System.Drawing.Point(190, 207);
            this.lblIm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIm.Name = "lblIm";
            this.lblIm.Size = new System.Drawing.Size(109, 15);
            this.lblIm.TabIndex = 3;
            this.lblIm.Text = "Поисковый образ";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(196, 75);
            this.btnInit.Margin = new System.Windows.Forms.Padding(2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(66, 25);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Создать";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(194, 165);
            this.lblRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 15);
            this.lblRes.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 251);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(242, 21);
            this.tbN.Margin = new System.Windows.Forms.Padding(2);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(76, 20);
            this.tbN.TabIndex = 7;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(242, 43);
            this.tbB.Margin = new System.Windows.Forms.Padding(2);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(76, 20);
            this.tbB.TabIndex = 8;
            // 
            // tbSI
            // 
            this.tbSI.Location = new System.Drawing.Point(307, 207);
            this.tbSI.Margin = new System.Windows.Forms.Padding(2);
            this.tbSI.Name = "tbSI";
            this.tbSI.Size = new System.Drawing.Size(76, 20);
            this.tbSI.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(277, 75);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 25);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 25);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(201, 138);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(86, 23);
            this.btnIns.TabIndex = 12;
            this.btnIns.Text = "Вставками";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(293, 138);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(75, 23);
            this.btnBubble.TabIndex = 13;
            this.btnBubble.Text = "Пузырек";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(386, 139);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(75, 23);
            this.btnShell.TabIndex = 14;
            this.btnShell.Text = "Шелл";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnDSearch
            // 
            this.btnDSearch.Location = new System.Drawing.Point(292, 253);
            this.btnDSearch.Name = "btnDSearch";
            this.btnDSearch.Size = new System.Drawing.Size(107, 23);
            this.btnDSearch.TabIndex = 15;
            this.btnDSearch.Text = "Дихотомия";
            this.btnDSearch.UseVisualStyleBackColor = true;
            this.btnDSearch.Click += new System.EventHandler(this.btnDSearch_Click);
            // 
            // btnPS
            // 
            this.btnPS.Location = new System.Drawing.Point(207, 307);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(111, 23);
            this.btnPS.TabIndex = 16;
            this.btnPS.Text = "Параллельно";
            this.btnPS.UseVisualStyleBackColor = true;
            this.btnPS.Click += new System.EventHandler(this.btnPS_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(346, 308);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(129, 23);
            this.btnS.TabIndex = 17;
            this.btnS.Text = "Последовательно";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // frmArrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 366);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnPS);
            this.Controls.Add(this.btnDSearch);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tbSI);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.lblIm);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.dgArr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArrs";
            this.Text = "Массивы";
            this.Load += new System.EventHandler(this.frmArrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arr;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblIm;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbSI;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnDSearch;
        private System.Windows.Forms.Button btnPS;
        private System.Windows.Forms.Button btnS;

    }
}

