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
    public class Archer : Hero
    {
        public Archer(string name) : base(name)
        {
            ValidWeaponTypes = new List<WeaponTypeEnum> { WeaponTypeEnum.Bow };
            ValidArmorTypes = new List<ArmorTypeEnum> { ArmorTypeEnum.Leather, ArmorTypeEnum.Mail };
            this.attributes.Strength = 1;
            this.attributes.Dexterity = 7;
            this.attributes.Intelligence = 1;
            this.Damagingattribute = 7;

        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: Archer");
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
            IncreaseAttributes(1, 5, 1);

        }
    }


}

