using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_4_homework5.AttributeFiles;

namespace Winform_4_homework5.Models
{
    public class IncomeInfo : BaseInfo
    {
        public IncomeInfo(string name, string description, decimal amount) : base(name, description, amount)
        {
        }

        public IncomeInfo(string name, string description, decimal amount, DateTime time) : base(name, description, amount, time)
        {
        }
    }
}
