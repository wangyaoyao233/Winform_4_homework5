using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Winform_4_homework5.AttributeFiles;

namespace Winform_4_homework5.Utility
{
    public static class AttributeExtend
    {
        /// <summary>
        /// 获取Remark的扩展方法
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetRemark(this PropertyInfo property)
        {
            string str = null;
            var remarkAttr = property.GetCustomAttribute<RemarkAttribute>();
            if (remarkAttr != null)
            {
                str = remarkAttr.Description;
            }
            return str;
        }

        /// <summary>
        /// 显示Remark信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ShowRemarkInfo<T>(T t)
        {
            string str = "";
            Type type = t.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var prop in propertyInfos)
            {
                string remark = prop.GetRemark();
                if (remark != null)
                {
                    str += remark + ": ";
                }
                str += prop.GetValue(t) + ", ";
            }
            str += "\r\n";

            return str;
        }
    }
}
