namespace Winform_4_homework5
{
    partial class FormMain
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
            this.buttonItemInfo = new System.Windows.Forms.Button();
            this.buttonExpend = new System.Windows.Forms.Button();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonItemInfo
            // 
            this.buttonItemInfo.Location = new System.Drawing.Point(185, 84);
            this.buttonItemInfo.Name = "buttonItemInfo";
            this.buttonItemInfo.Size = new System.Drawing.Size(110, 75);
            this.buttonItemInfo.TabIndex = 0;
            this.buttonItemInfo.Text = "名目信息维护";
            this.buttonItemInfo.UseVisualStyleBackColor = true;
            this.buttonItemInfo.Click += new System.EventHandler(this.buttonItemInfo_Click);
            // 
            // buttonExpend
            // 
            this.buttonExpend.Location = new System.Drawing.Point(464, 84);
            this.buttonExpend.Name = "buttonExpend";
            this.buttonExpend.Size = new System.Drawing.Size(110, 75);
            this.buttonExpend.TabIndex = 1;
            this.buttonExpend.Text = "支出记账";
            this.buttonExpend.UseVisualStyleBackColor = true;
            this.buttonExpend.Click += new System.EventHandler(this.buttonExpend_Click);
            // 
            // buttonIncome
            // 
            this.buttonIncome.Location = new System.Drawing.Point(185, 265);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(110, 75);
            this.buttonIncome.TabIndex = 2;
            this.buttonIncome.Text = "收入记账";
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(464, 265);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(110, 75);
            this.buttonSummary.TabIndex = 3;
            this.buttonSummary.Text = "收支记账统计";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonIncome);
            this.Controls.Add(this.buttonExpend);
            this.Controls.Add(this.buttonItemInfo);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonItemInfo;
        private System.Windows.Forms.Button buttonExpend;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonSummary;
    }
}

