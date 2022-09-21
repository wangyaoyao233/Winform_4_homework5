using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework5.Models
{
    public class ItemInfo
    {
        public string ItemType { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public ItemInfo(string type, int id, string name)
        {
            this.ItemType = type;
            this.ItemId = id;
            this.ItemName = name;
        }
    }
}
