using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_4_homework5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonItemInfo_Click(object sender, EventArgs e)
        {
            FormItemInfo form = new FormItemInfo();
            form.Show();
        }

        private void buttonExpend_Click(object sender, EventArgs e)
        {
            FormExpend form = new FormExpend();
            form.Show();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            FormIncome form = new FormIncome();
            form.Show();
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            FormSummary form = new FormSummary();
            form.Show();
        }
    }
}
