using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Winform_4_homework5.Models;
using Winform_4_homework5.Utility;

namespace Winform_4_homework5
{
    public partial class FormExpend : Form
    {
        public FormExpend()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重置输入框
        /// </summary>
        private void InputReset()
        {
            this.textBoxName.Text = "";
            this.textBoxDescription.Text = "";
            this.textBoxAmount.Text = "";
            this.textBoxDescSearch.Text = "";
            this.textBoxAmountSearchFrom.Text = "";
            this.textBoxAmountSearchTo.Text = "";
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        private void ShowInfo()
        {
            labelShow.Text = "";
            ComUtility.allExpendList.ForEach(item =>
            {
                labelShow.Text += AttributeExtend.ShowRemarkInfo(item);
            });
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            decimal amount = decimal.Parse(textBoxAmount.Text.Trim());

            ExpendInfo expendInfo = new ExpendInfo(name, description, amount);
            ComUtility.allExpendList.Add(expendInfo);

            this.ShowInfo();
            this.InputReset();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string desc = textBoxDescSearch.Text.Trim();
            decimal from = decimal.Parse(textBoxAmountSearchFrom.Text.Trim());
            decimal to = decimal.Parse(textBoxAmountSearchTo.Text.Trim());

            labelShow.Text = "";
            ComUtility.allExpendList.Where(item =>
                desc != "" ? item.Description.Contains(desc) : true //如果描述为空,则设置为true, 来跳过此判断
                && item.Amount >= from && item.Amount <= to)
                .ToList().ForEach(item =>
                {
                    labelShow.Text += AttributeExtend.ShowRemarkInfo(item);
                });
        }
    }
}
