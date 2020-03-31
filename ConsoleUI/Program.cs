using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI ui = new ProgramUI();
            ui.Fun();


            //List<string> commands = new List<string>()
            //{
            //    "Birb",
            //    "Birb",
            //    "OtherBirb"
            //};
            

            ///*
            //string commandText = File.ReadAllText("C:/...");
            //string[] commandArray = commandText.Split(',');
            //List<string> commands = commandArray.ToList();
            //*/

            //Game game = new Game();
            //game.Run(commands);

        }
    }
}
