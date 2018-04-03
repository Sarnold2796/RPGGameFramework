using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest
{
    interface armour
    {
        string Name { get; set; }
        int Durability { get; set; }
        int DefenceRating { get; set; }
        string EquipLocation { get; set; }
        bool IsArmPiece { get; set; }
        bool IsChestplate { get; set; }
        bool IsLegPiece { get; set; }
        bool IsHelmet { get; set; }
        bool IsBoots { get; set; }
        bool IsGauntlet { get; set; }
    }
}
