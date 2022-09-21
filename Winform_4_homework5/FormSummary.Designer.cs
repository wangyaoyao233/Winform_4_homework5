namespace Winform_4_homework5
{
    partial class FormSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelExpend = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonDay = new System.Windows.Forms.Button();
            this.buttonMoth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "总收入金额:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "总支出金额:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "总收支金额:";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(99, 152);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 12);
            this.labelShow.TabIndex = 3;
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(161, 62);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(0, 12);
            this.labelIncome.TabIndex = 4;
            // 
            // labelExpend
            // 
            this.labelExpend.AutoSize = true;
            this.labelExpend.Location = new System.Drawing.Point(370, 62);
            this.labelExpend.Name = "labelExpend";
            this.labelExpend.Size = new System.Drawing.Size(0, 12);
            this.labelExpend.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(566, 62);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 12);
            this.labelTotal.TabIndex = 6;
            // 
            // buttonDay
            // 
            this.buttonDay.Location = new System.Drawing.Point(101, 100);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(75, 23);
            this.buttonDay.TabIndex = 7;
            this.buttonDay.Text = "按日统计";
            this.buttonDay.UseVisualStyleBackColor = true;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // buttonMoth
            // 
            this.buttonMoth.Location = new System.Drawing.Point(221, 100);
            this.buttonMoth.Name = "buttonMoth";
            this.buttonMoth.Size = new System.Drawing.Size(75, 23);
            this.buttonMoth.TabIndex = 8;
            this.buttonMoth.Text = "按月统计";
            this.buttonMoth.UseVisualStyleBackColor = true;
            this.buttonMoth.Click += new System.EventHandler(this.buttonMoth_Click);
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMoth);
            this.Controls.Add(this.buttonDay);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelExpend);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSummary";
            this.Text = "FormSummary";
            this.Load += new System.EventHandler(this.FormSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelExpend;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.Button buttonMoth;
    }
}