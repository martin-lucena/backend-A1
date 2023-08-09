using A1_Dungeon_Master.Enums.ItemEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Dungeon_Master.Classes.Items
{
    public class Weapon : Item
    {
        public WeaponTypeEnum WeaponType { get; set; }
        
        public int WeaponDamage { get; set; }
        public string Name { get; set; }

        public Weapon(string name, WeaponTypeEnum weaponType, int weaponDamage)
        {
            Name = name;
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }
    }
}
