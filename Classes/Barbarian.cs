using A1_Dungeon_Master.Enums.ItemEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A1_Dungeon_Master.Classes.Heroes
{
    public class Barbarian : Hero
    {
        public Barbarian(string name) : base(name)
        {
            ValidWeaponTypes = new List<WeaponTypeEnum> { WeaponTypeEnum.Hatchet, WeaponTypeEnum.Mace, WeaponTypeEnum.Sword };
            ValidArmorTypes = new List<ArmorTypeEnum> { ArmorTypeEnum.Mail, ArmorTypeEnum.Plate };

            this.attributes.Strength = 5;
            this.attributes.Dexterity = 2;
            this.attributes.Intelligence = 1;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: Barbarian");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Total Strength: {CalculateTotalAttributes().Strength}");
            Console.WriteLine($"Total Dexterity: {CalculateTotalAttributes().Dexterity}");
            Console.WriteLine($"Total Intelligence: {CalculateTotalAttributes().Intelligence}");
            Console.WriteLine($"Damage: {CalculateDamage()}");
            Console.WriteLine($"Equipment: {EquippedItems}");
        }

        public override void LevelUp()
        {
            base.LevelUp();
            IncreaseAttributes(3, 2, 1);

        }
    }
}
