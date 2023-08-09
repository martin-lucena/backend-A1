using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1_Dungeon_Master.Enums.ItemEnums;

namespace A1_Dungeon_Master.Classes.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public SlotEnum Slot { get; set; }


    }
}
