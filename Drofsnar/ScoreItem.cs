using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class ScoreItem
    {
    public ScoreItem(string name, int pointValue)
    {
            ItemName = name;
            PointValue = pointValue; 
    }
        public string ItemName { get; set; }
        public int PointValue { get; set; }

    }
}
