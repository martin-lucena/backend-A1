using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Dungeon_Master.Classes.Heroes
{
    public class HeroAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttributes(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public HeroAttributes AddAttributes(HeroAttributes attributes) // kolla om det verkligen behövs!
        {
            int newStrength = Strength + attributes.Strength;
            int newDexterity = Dexterity + attributes.Dexterity;
            int newIntelligence = Intelligence + attributes.Intelligence;
            return new HeroAttributes(newStrength, newDexterity, newIntelligence);
        }

        public void IncreaseAttributes(int increaseStrength, int increasecDexterity, int increaseIntelligence)
        {
            Strength += increaseStrength;
            Dexterity += increasecDexterity;
            Intelligence += increaseIntelligence;
        }
    }
}
