namespace Mechs
{
    /// <summary>
    /// Main class
    /// </summary>
    partial class MainForm
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
            this.btnEndOfTurn = new System.Windows.Forms.Button();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbDOW = new System.Windows.Forms.Label();
            this.lbWeek = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDOY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEndOfTurn
            // 
            this.btnEndOfTurn.Location = new System.Drawing.Point(205, 231);
            this.btnEndOfTurn.Name = "btnEndOfTurn";
            this.btnEndOfTurn.Size = new System.Drawing.Size(75, 23);
            this.btnEndOfTurn.TabIndex = 0;
            this.btnEndOfTurn.Text = "End of Turn";
            this.btnEndOfTurn.UseVisualStyleBackColor = true;
            this.btnEndOfTurn.Click += new System.EventHandler(this.btnEndOfTurn_Click);
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(58, 58);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(13, 13);
            this.lbDay.TabIndex = 1;
            this.lbDay.Text = "0";
            // 
            // lbDOW
            // 
            this.lbDOW.AutoSize = true;
            this.lbDOW.Location = new System.Drawing.Point(133, 58);
            this.lbDOW.Name = "lbDOW";
            this.lbDOW.Size = new System.Drawing.Size(13, 13);
            this.lbDOW.TabIndex = 2;
            this.lbDOW.Text = "0";
            // 
            // lbWeek
            // 
            this.lbWeek.AutoSize = true;
            this.lbWeek.Location = new System.Drawing.Point(213, 58);
            this.lbWeek.Name = "lbWeek";
            this.lbWeek.Size = new System.Drawing.Size(13, 13);
            this.lbWeek.TabIndex = 3;
            this.lbWeek.Text = "0";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(58, 106);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(13, 13);
            this.lbMonth.TabIndex = 4;
            this.lbMonth.Text = "0";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(213, 106);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(13, 13);
            this.lbYear.TabIndex = 5;
            this.lbYear.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOW:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Week:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DOY:";
            // 
            // lbDOY
            // 
            this.lbDOY.AutoSize = true;
            this.lbDOY.Location = new System.Drawing.Point(133, 105);
            this.lbDOY.Name = "lbDOY";
            this.lbDOY.Size = new System.Drawing.Size(13, 13);
            this.lbDOY.TabIndex = 12;
            this.lbDOY.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lbDOY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbWeek);
            this.Controls.Add(this.lbDOW);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.btnEndOfTurn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndOfTurn;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbDOW;
        private System.Windows.Forms.Label lbWeek;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDOY;
    }
}

