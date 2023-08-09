using A1_Dungeon_Master.Classes.Heroes;
using A1_Dungeon_Master.Enums.ItemEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Dungeon_Master.Classes.Items
{
    public class Armor : Item
    {
        public ArmorTypeEnum ArmorType { get; set; }
        public HeroAttributes ArmorAttributes { get; set; }
        public Armor(ArmorTypeEnum armorType, HeroAttributes armorAttributes)
        {
            ArmorType = armorType;
            ArmorAttributes = armorAttributes;
        }
    }
}
