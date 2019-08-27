using System;
using Core;
using Manager;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool playing = true;

            while(playing)
            {
                string command;
                StartScreen();

                command = Console.ReadLine();

                if (command.ToLower() == "quit")
                    playing = false;
                else
                {
                    var commandList = command.Split(",");

                    if(game.ValidateCommand(commandList))
                    {
                        var result = game.ProcessCommands();
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command, please try again.");
                    }
                    Console.Read();
                }
            }
        }

        private static void StartScreen()
        {
            Console.Clear();
            Console.WriteLine("Choose what wires to cut in order separated with a comma:");
        }
    }
}