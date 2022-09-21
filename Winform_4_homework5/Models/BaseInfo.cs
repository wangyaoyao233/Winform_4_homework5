using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_4_homework5.AttributeFiles;

namespace Winform_4_homework5.Models
{
    public class BaseInfo
    {
        [Remark("编号")]
        public int Id { get; set; }
        [Remark("名目")]
        public string Name { get; set; }
        [Remark("描述")]
        public string Description { get; set; }
        [Remark("金额")]
        public decimal Amount { get; set; }

        public DateTime Time { get; set; }

        static int cnt = 0;
        public BaseInfo(string name, string description, decimal amount)
        {
            cnt++;
            this.Id = cnt;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Time = DateTime.Now;
        }
        public BaseInfo(string name, string description, decimal amount, DateTime time)
        {
            cnt++;
            this.Id = cnt;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Time = time;
        }
    }
}
