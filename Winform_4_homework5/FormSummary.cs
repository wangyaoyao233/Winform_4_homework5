using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Winform_4_homework5.Utility;

namespace Winform_4_homework5
{
    public partial class FormSummary : Form
    {
        public FormSummary()
        {
            InitializeComponent();
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            ComUtility.allIncomeList.Add(new Models.IncomeInfo("打工", "打工", 100m, new DateTime(2022, 9, 21)));
            ComUtility.allIncomeList.Add(new Models.IncomeInfo("打工", "打工", 200m, new DateTime(2022, 9, 21)));
            ComUtility.allIncomeList.Add(new Models.IncomeInfo("打工", "打工", 300m, new DateTime(2022, 9, 22)));
            ComUtility.allIncomeList.Add(new Models.IncomeInfo("打工", "打工", 400m, new DateTime(2022, 9, 22)));

            ComUtility.allExpendList.Add(new Models.ExpendInfo("吃饭", "吃饭", 12m, new DateTime(2022, 9, 21)));
            ComUtility.allExpendList.Add(new Models.ExpendInfo("吃饭", "吃饭", 22m, new DateTime(2022, 9, 21)));
            ComUtility.allExpendList.Add(new Models.ExpendInfo("吃饭", "吃饭", 32m, new DateTime(2022, 9, 22)));
            ComUtility.allExpendList.Add(new Models.ExpendInfo("吃饭", "吃饭", 42m, new DateTime(2022, 9, 22)));


            decimal income = 0;
            decimal expend = 0;

            income = ComUtility.allIncomeList.Sum(item => item.Amount);
            expend = ComUtility.allExpendList.Sum(item => item.Amount);

            this.labelIncome.Text = income.ToString();
            this.labelExpend.Text = expend.ToString();
            this.labelTotal.Text = (income - expend).ToString();
        }

        private void buttonDay_Click(object sender, EventArgs e)
        {
            //获取所有不同的日期
            var timeList1 = ComUtility.allIncomeList.Select(item => item.Time).Distinct().ToList();
            var timeList2 = ComUtility.allExpendList.Select(item => item.Time).Distinct().ToList();
            var timeList = timeList1.Union(timeList2);

            this.labelShow.Text = "";
            foreach (var time in timeList)
            {
                decimal income = ComUtility.allIncomeList.Where(item => item.Time.Equals(time)).Sum(item => item.Amount);
                decimal expend = ComUtility.allExpendList.Where(item => item.Time.Equals(time)).Sum(item => item.Amount);

                this.labelShow.Text += $"日期: {time}, 收入: {income}, 支出: {expend}, 日收支: {income - expend}\r\n";
            }
        }

        private void buttonMoth_Click(object sender, EventArgs e)
        {
            //获取所有不同的年月
            var timeList1 = ComUtility.allIncomeList.Select(item =>
            {
                return new
                {
                    item.Time.Year,
                    item.Time.Month
                };
            }).Distinct().ToList();
            var timeList2 = ComUtility.allExpendList.Select(item =>
            {
                return new
                {
                    item.Time.Year,
                    item.Time.Month
                };
            }).Distinct().ToList();
            var timeList = timeList1.Union(timeList2);

            this.labelShow.Text = "";
            foreach (var time in timeList)
            {
                decimal income = ComUtility.allIncomeList
                    .Where(item => item.Time.Year.Equals(time.Year) && item.Time.Month.Equals(time.Month))
                    .Sum(item => item.Amount);
                decimal expend = ComUtility.allExpendList
                    .Where(item => item.Time.Year.Equals(time.Year) && item.Time.Month.Equals(time.Month))
                    .Sum(item => item.Amount);

                this.labelShow.Text += $"日期: {time.Year}年{time.Month}月, 收入: {income}, 支出: {expend}, 月收支: {income - expend}\r\n";
            }
        }
    }
}
