using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_4_homework5.Models;
using Winform_4_homework5.Utility;

namespace Winform_4_homework5
{
    public partial class FormIncome : Form
    {
        public FormIncome()
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
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        private void ShowInfo()
        {
            labelShow.Text = "";
            ComUtility.allIncomeList.ForEach(item =>
            {
                labelShow.Text += AttributeExtend.ShowRemarkInfo(item);
            });
        }

        bool isEdit = false;
        int editId = 0;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {         
            string name = textBoxName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            decimal amount = decimal.Parse(textBoxAmount.Text.Trim());

            //判断编辑模式还是新输入模式
            if (!isEdit)
            {
                IncomeInfo incomeInfo = new IncomeInfo(name, description, amount);
                ComUtility.allIncomeList.Add(incomeInfo);
            }
            else
            {
                IncomeInfo incomeInfo = ComUtility.allIncomeList.FirstOrDefault(item => item.Id == editId);
                incomeInfo.Name = name;
                incomeInfo.Description = description;
                incomeInfo.Amount = amount;
            }

            this.ShowInfo();
            this.InputReset();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text.Trim());

            // 获取并设置输入
            IncomeInfo incomeInfo = ComUtility.allIncomeList.FirstOrDefault(item => item.Id == id);
            textBoxName.Text = incomeInfo.Name;
            textBoxDescription.Text = incomeInfo.Description;
            textBoxAmount.Text = incomeInfo.Amount.ToString();

            buttonSubmit.Text = "修改";
            isEdit = true;
            editId = id;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if(buttonSubmit.Text == "修改")
            {
                buttonSubmit.Text = "记账";
                isEdit = false;
                editId = 0;
            }
            this.InputReset();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text.Trim());

            //获取并删除
            IncomeInfo incomeInfo = ComUtility.allIncomeList.FirstOrDefault(item => item.Id == id);
            ComUtility.allIncomeList.Remove(incomeInfo);

            this.ShowInfo();
            this.InputReset();
        }
    }
}
