using A1_Dungeon_Master.Enums.ItemEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Dungeon_Master.Classes.Heroes
{
    public class Swashbuckler : Hero
    {
        public Swashbuckler(string name) : base(name)
        {
            ValidWeaponTypes = new List<WeaponTypeEnum> { WeaponTypeEnum.Dagger, WeaponTypeEnum.Sword };
            ValidArmorTypes = new List<ArmorTypeEnum> { ArmorTypeEnum.Leather, ArmorTypeEnum.Mail };
            this.attributes.Strength = 2;
            this.attributes.Dexterity = 6;
            this.attributes.Intelligence = 1;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: Swashbuckler");
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
            IncreaseAttributes(1, 4, 1);

        }
    }
}
