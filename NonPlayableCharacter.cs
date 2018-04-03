using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest
{
    class nonPlayableCharacter:character
    {
        public int Level { get; set; }
        public double Health { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Occult { get; set; }
        public int Faith { get; set; }
    }
}
