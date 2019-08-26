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

                if(game.ValidateCommand(command))
                {
                    Console.WriteLine(command.ToWireType());

                    Console.Read();

                    if (command?.ToLower() == "quit")
                        playing = false;
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