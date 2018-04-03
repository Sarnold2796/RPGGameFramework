using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest
{
    class player : character

    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double Health { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Occult { get; set; }
        public int Faith { get; set; }
        public List<Object> Inventory { get; set; }
        public List<KeyValuePair<string,armour>> equipment{ get; set; }
        public weapon leftHand { get; set; }
        public weapon rightHand { get; set; }



        public player(string name, double health, int strength, int dexterity, int constitution, int occult, int faith, List<Object> inventory)
        {
            Name = name;
            Level = 1;
            Health = health;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Occult = occult;
            Faith = faith;
            Inventory = inventory;

        }

        public void equip(weapon weapon)
        {
            ///get weapon info for relevant hand/s

            ///if weapon is equipped in this hand
            /// ask if they want to replace
            /// else check equippable slots
            /// set property to that hand

        }



    }
}
