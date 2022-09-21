using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework5.AttributeFiles
{
    /// <summary>
    /// 注释特性
    /// </summary>
    public class RemarkAttribute: Attribute
    {
        public string Description { get; set; }
        public RemarkAttribute(string desc)
        {
            this.Description = desc;
        }
    }
}
