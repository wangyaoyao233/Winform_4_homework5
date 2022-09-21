﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_4_homework5.Models;
using Winform_4_homework5.Utility;

namespace Winform_4_homework5
{
    public partial class FormItemInfo : Form
    {
        public FormItemInfo()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelShow.Text = "";//清空之前的显示
            string type = textBoxType.Text.Trim();
            int id = int.Parse(textBoxId.Text.Trim());
            string name = textBoxName.Text.Trim();

            ItemInfo itemInfo = new ItemInfo(type, id, name);
            ComUtility.allItemList.Add(itemInfo);

            //显示
            ComUtility.allItemList.ForEach((item) =>
            {
                labelShow.Text += $"{item.ItemId}, {item.ItemName}, {item.ItemType} \r\n";
            });

            textBoxType.Text = "";
            textBoxId.Text = "";
            textBoxName.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelShow.Text = "";//清空之前的显示
            string keyword = textBoxKeyword.Text.Trim();

            ComUtility.allItemList.Where(item => item.ItemName.Contains(keyword)).ToList()
                .ForEach((item) =>
            {
                labelShow.Text += $"{item.ItemId}, {item.ItemName}, {item.ItemType} \r\n";
            });

            textBoxKeyword.Text = "";
        }
    }
}
