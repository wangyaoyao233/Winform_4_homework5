namespace Winform_4_homework5
{
    partial class FormExpend
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescSearch = new System.Windows.Forms.Label();
            this.labelAmountSearch = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxDescSearch = new System.Windows.Forms.TextBox();
            this.textBoxAmountSearchFrom = new System.Windows.Forms.TextBox();
            this.textBoxAmountSearchTo = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(97, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "支出名目:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(97, 90);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 12);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "描述:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(97, 117);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(59, 12);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "记账金额:";
            // 
            // labelDescSearch
            // 
            this.labelDescSearch.AutoSize = true;
            this.labelDescSearch.Location = new System.Drawing.Point(80, 190);
            this.labelDescSearch.Name = "labelDescSearch";
            this.labelDescSearch.Size = new System.Drawing.Size(35, 12);
            this.labelDescSearch.TabIndex = 3;
            this.labelDescSearch.Text = "描述:";
            // 
            // labelAmountSearch
            // 
            this.labelAmountSearch.AutoSize = true;
            this.labelAmountSearch.Location = new System.Drawing.Point(258, 190);
            this.labelAmountSearch.Name = "labelAmountSearch";
            this.labelAmountSearch.Size = new System.Drawing.Size(35, 12);
            this.labelAmountSearch.TabIndex = 4;
            this.labelAmountSearch.Text = "金额:";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(80, 236);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 12);
            this.labelShow.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(178, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(178, 89);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 21);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(178, 117);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 21);
            this.textBoxAmount.TabIndex = 8;
            // 
            // textBoxDescSearch
            // 
            this.textBoxDescSearch.Location = new System.Drawing.Point(121, 187);
            this.textBoxDescSearch.Name = "textBoxDescSearch";
            this.textBoxDescSearch.Size = new System.Drawing.Size(100, 21);
            this.textBoxDescSearch.TabIndex = 9;
            // 
            // textBoxAmountSearchFrom
            // 
            this.textBoxAmountSearchFrom.Location = new System.Drawing.Point(299, 187);
            this.textBoxAmountSearchFrom.Name = "textBoxAmountSearchFrom";
            this.textBoxAmountSearchFrom.Size = new System.Drawing.Size(64, 21);
            this.textBoxAmountSearchFrom.TabIndex = 10;
            // 
            // textBoxAmountSearchTo
            // 
            this.textBoxAmountSearchTo.Location = new System.Drawing.Point(394, 187);
            this.textBoxAmountSearchTo.Name = "textBoxAmountSearchTo";
            this.textBoxAmountSearchTo.Size = new System.Drawing.Size(71, 21);
            this.textBoxAmountSearchTo.TabIndex = 11;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(121, 158);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "记账";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(507, 187);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormExpend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAmountSearchTo);
            this.Controls.Add(this.textBoxAmountSearchFrom);
            this.Controls.Add(this.textBoxDescSearch);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.labelAmountSearch);
            this.Controls.Add(this.labelDescSearch);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Name = "FormExpend";
            this.Text = "FormExpend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescSearch;
        private System.Windows.Forms.Label labelAmountSearch;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxDescSearch;
        private System.Windows.Forms.TextBox textBoxAmountSearchFrom;
        private System.Windows.Forms.TextBox textBoxAmountSearchTo;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonSearch;
    }
}