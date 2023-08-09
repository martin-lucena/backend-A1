using A1_Dungeon_Master.Enums.ItemEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Dungeon_Master.Classes.Heroes
{
    public class Wizard : Hero
    {


        public Wizard(string name) : base(name)
        {
            ValidWeaponTypes = new List<WeaponTypeEnum> { WeaponTypeEnum.Staff, WeaponTypeEnum.Wand };
            ValidArmorTypes = new List<ArmorTypeEnum> { ArmorTypeEnum.Cloth };
            this.attributes.Strength = 1;
            this.attributes.Dexterity = 1;
            this.attributes.Intelligence = 8;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: Wizard");
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
            IncreaseAttributes(1, 1, 5);

        }

    }
}
