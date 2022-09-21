using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework5.Models
{
    public class ExpendInfo : BaseInfo
    {
        public ExpendInfo(string name, string description, decimal amount) : base(name, description, amount)
        {
        }

        public ExpendInfo(string name, string description, decimal amount, DateTime time) : base(name, description, amount, time)
        {
        }
    }
}
