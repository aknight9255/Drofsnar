using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class Player
    {
        public List<string> _gameSequence = System.IO.File.ReadAllText(@"C:\Users\amand\Desktop\1150\SD442020\Drofsnar Game Prompt\Drofsnar\game-sequence.txt").Split(',').ToList();
        public Player()
        {
            Lives = 3;
            TotalPoints = 5000;
            VbBirdHunterCount = 0;
        }
        public int Lives { get; set; }
        public int TotalPoints { get; set; }
        public int VbBirdHunterCount { get; set; }

    }
}
