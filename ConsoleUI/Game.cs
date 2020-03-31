using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Game
    {
        public Game()
        {
            
        }

        public void Run(List<string> commands)
        {
            int score = 5000;
            foreach (string command in commands)
            {
                if (command == "Birb")
                {
                    score += 10;
                } else if (command == "OtherBirb")
                {
                    score += 500;
                }
                Console.WriteLine($"{command, -20} {score, -20}");
            
            }
            Console.ReadLine();
        }
    }
}
