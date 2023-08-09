using A1_Dungeon_Master.Classes.Items;
using A1_Dungeon_Master.Enums.ItemEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace A1_Dungeon_Master.Classes.Heroes
{
    public abstract class Hero
    {

        //private Equipment: equipment;


        public string Name { get; set; }
        public int Level { get; set; }
        public int LevelAttributes { get; set; }
        //public List<string> Equipment { get; set; }

        //public Equipment Equipment { get; set; }

        public int Damagingattribute { get; set; }

        public List<WeaponTypeEnum> ValidWeaponTypes { get; set; }
        public List<ArmorTypeEnum> ValidArmorTypes { get; set; }

        public HeroAttributes attributes = new(0, 0, 0);

        public Dictionary<SlotEnum, Item> EquippedItems = new Dictionary<SlotEnum, Item>();

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = 0;
            this.attributes = attributes;
            this.EquippedItems.Add(SlotEnum.Weapon, null);
            this.EquippedItems.Add(SlotEnum.Head, null);
            this.EquippedItems.Add(SlotEnum.Body, null);
            this.EquippedItems.Add(SlotEnum.Legs, null);

        }
        public abstract void Display();
        public void EquipWeapon(Weapon weapon)
        {
            if (this.ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                if (this.EquippedItems.ContainsKey(SlotEnum.Weapon)) // checks if key already exists if so it replaces the existing weapon with the new one. 
                {
                    this.EquippedItems[SlotEnum.Weapon] = weapon;
                }
                else
                {
                    this.EquippedItems.Add(SlotEnum.Weapon, weapon);
                }

            }
            else
            {
                Console.WriteLine(Name + " cant equip a " + weapon);
            }


        }

        public void EquipArmor(Armor armor)
        {
            if (this.ValidArmorTypes.Contains(armor.ArmorType))
            {
                if (this.EquippedItems.ContainsKey(armor.Slot)) // checks if key already exists if so it replaces the existing armor with the new one.
                {
                    this.EquippedItems[armor.Slot] = armor;
                }
                else
                {
                    this.EquippedItems.Add(armor.Slot, armor);
                }

            }
            else
            {
                Console.WriteLine(Name + " cant equip " + armor);
            }
        }

        //public void AddAttributes(HeroAttributes attributes)
        //{
        //    attributes = attributes.AddAttributes(attributes);
        //}
        public void IncreaseAttributes(int increaseStrength, int increaseDexterity, int increaseIntelligence)
        {
            attributes.IncreaseAttributes(increaseStrength, increaseDexterity, increaseIntelligence);
        }

        public virtual void LevelUp()
        {
            Level++;
        }

        public HeroAttributes CalculateTotalAttributes()
        {

            foreach (var slotItem in EquippedItems)
            {
                if (slotItem.Key != SlotEnum.Weapon && slotItem.Value is Armor armor)
                {
                    this.attributes = attributes.AddAttributes(armor.ArmorAttributes);
                }

            }
            return attributes;
        }

        public int CalculateDamage()
        {
            HeroAttributes totalAttributes = CalculateTotalAttributes();
            int damagingAttribute = 0;

            if (this is Barbarian)
            {
                damagingAttribute = totalAttributes.Strength;
            }
            else if (this is Wizard)
            {
                damagingAttribute = totalAttributes.Intelligence;
            }
            else if (this is Archer || this is Swashbuckler)
            {
                damagingAttribute = totalAttributes.Dexterity;

            }
            int weaponDamage = EquippedItems[SlotEnum.Weapon] is Weapon weapon ? weapon.WeaponDamage : 1;

            return weaponDamage * (1 + damagingAttribute / 100);
        }
    }



}
