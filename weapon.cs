using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest
{
    class weapon
    {
        ///nullable specials
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int CurrentDurability { get; set; }
        public KeyValuePair<string,int> Requirements{ get; set; }   //string=Stat int=requirement number
        public KeyValuePair<string, int> Scalings { get; set; }     //string=Stat int=requirement number
        public bool leftHand { get; set; }
        public bool rightHand { get; set; }                    //main or offhand
        public string Special { get; set; }

        public weapon(string name, int damage, int durability, KeyValuePair<string, int> requirement, KeyValuePair<string, int> scalings, string equipSlot)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Requirements = requirement;
            Scalings = scalings;
            //EquipSlot = equipslot;
            //setEquipSlot(equipSlot);

        }

        public weapon(string name, int damage, int durability, KeyValuePair<string, int> requirement, KeyValuePair<string, int> scalings, string equipslot,string special)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Requirements = requirement;
            Scalings = scalings;
            //EquipSlot = equipslot;
            Special = special;
        }



    }
}
