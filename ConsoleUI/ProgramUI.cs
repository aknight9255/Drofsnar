using Drofsnar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class ProgramUI
    {
        private readonly ScoreRepo _scoreRepo = new ScoreRepo();
        public void Fun()
        {
            SeedScores();
            RunTxtFile();
        }
        public void RunTxtFile()
        {
            var player = new Player();
            var list = player._gameSequence;
            bool reachedBLife = false;

            foreach (string oneEvent in list)
            {
                var theEvent = _scoreRepo.FindOneScore(oneEvent);
                var output = _scoreRepo.GameEvent(theEvent, player);
                if (player.Lives != 0)
                {
                    Console.WriteLine($"{theEvent.ItemName}/{theEvent.PointValue} \n" +
                        $"Current Points: {player.TotalPoints}/ Current Lives: {player.Lives} " +
                        $"{output}");
                }
                else
                {
                    Console.WriteLine($"{theEvent.ItemName}/{theEvent.PointValue} \n" +
                        $"{player.TotalPoints}/{player.Lives}\n" +
                        $"{output}");
                    break;
                }
                if (!reachedBLife)
                {
                    if (player.TotalPoints >= 10000)
                    {
                        player.Lives += 1;
                        reachedBLife = true;
                    }

                }

            }

            Console.WriteLine(player.TotalPoints);
            Console.WriteLine(player.Lives);
            Console.ReadKey();
        }

        private void SeedScores()
        {
            ScoreItem item = new ScoreItem("Bird", 10);
            ScoreItem item1 = new ScoreItem("CrestedIbis", 100);
            ScoreItem item2 = new ScoreItem("GreatKiskudee", 300);
            ScoreItem item3 = new ScoreItem("RedCrossbill", 500);
            ScoreItem item4 = new ScoreItem("Red-neckedPhalarope", 700);
            ScoreItem item5 = new ScoreItem("EveningGrosbeak", 1000);
            ScoreItem item6 = new ScoreItem("GreaterPrairieChicken", 2000);
            ScoreItem item7 = new ScoreItem("IcelandGull", 3000);
            ScoreItem item10 = new ScoreItem("Orange-BelliedParrot", 5000);
            ScoreItem item8 = new ScoreItem("InvincibleBirdHunter", 0);
            ScoreItem item9 = new ScoreItem("VulnerableBirdHunter", 200);
            _scoreRepo.AddNewScoreItem(item);
            _scoreRepo.AddNewScoreItem(item1);
            _scoreRepo.AddNewScoreItem(item2);
            _scoreRepo.AddNewScoreItem(item3);
            _scoreRepo.AddNewScoreItem(item4);
            _scoreRepo.AddNewScoreItem(item5);
            _scoreRepo.AddNewScoreItem(item6);
            _scoreRepo.AddNewScoreItem(item7);
            _scoreRepo.AddNewScoreItem(item8);
            _scoreRepo.AddNewScoreItem(item9);
            _scoreRepo.AddNewScoreItem(item10);

        }
    }
}
