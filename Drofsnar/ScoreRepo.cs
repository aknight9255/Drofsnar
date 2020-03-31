using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class ScoreRepo
    {
        protected readonly List<ScoreItem> _scoreDirectory = new List<ScoreItem>();

        //add new score 
        public void AddNewScoreItem(ScoreItem item)
        {
            var itemExists = FindOneScore(item.ItemName);
            if(itemExists == null)
            {
                _scoreDirectory.Add(item);
            }
        }
        // get score by name
        public ScoreItem FindOneScore(string name)
        {
            foreach(ScoreItem item in _scoreDirectory)
            {
                if(item.ItemName.ToLower() == name.ToLower())
                {
                    return item;
                }
            }
            return null;

        }

        //game event 
        public string GameEvent(ScoreItem oneEvent, Player player)
        {
            if (oneEvent.ItemName == "InvincibleBirdHunter")
            {
                player.Lives -= 1;
                if (player.Lives == 0)
                {
                    return "You have died";
                }
                return "Ouch that hurt";
            }
            if (oneEvent.ItemName == "VulnerableBirdHunter")
            {
                player.VbBirdHunterCount += 1;
                if(player.VbBirdHunterCount == 1)
                {
                    player.TotalPoints += oneEvent.PointValue;
                    return "Got em!";
                }
                else if (player.VbBirdHunterCount == 2)
                {
                    player.TotalPoints += 400;
                    return "Got a second one";
                }
                else if(player.VbBirdHunterCount == 3)
                {
                    player.TotalPoints += 800;
                    return "Got a third one";
                }
                else
                {
                    player.TotalPoints += 1600;
                    return "Got a fourth one";

                }
            }

            player.TotalPoints += oneEvent.PointValue;
           

            return "Event passed";
        }
        
    }
}
