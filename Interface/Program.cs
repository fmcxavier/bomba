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
                StartScreen();
                string command = Console.ReadLine();

                if (command.ToLower() == "quit")
                    playing = false;
                else
                {
                    var commandList = command.Split(",");

                    if(game.ValidateCommand(commandList))
                        Console.WriteLine(game.ProcessCommands());
                    else
                        Console.WriteLine("Invalid command, please try again.");

                    Console.Read();
                }
            }
        }

        private static void StartScreen()
        {
            Console.Clear();
            string line = "Choose what wires to cut in order separated with a comma:";

            DrawSymbol();

            var bottomLine = Console.WindowHeight;
            Console.SetCursorPosition(0,bottomLine - 1);

            Console.WriteLine(line);
        }

        private static void DrawSymbol()
        {
            var symbolLength = _bombSymbol[0].Length;
            _symbolLeftOffset = (Console.WindowWidth - symbolLength) / 2;
            _symbolTopOffset = (Console.WindowHeight - _bombSymbol.Length - 2) / 2;


            var lineCount = 0;
            foreach (var line in _bombSymbol)
            {
                Console.SetCursorPosition(_symbolLeftOffset, _symbolTopOffset + lineCount);
                Console.WriteLine(line);
                ++lineCount;
            }
        }

        private static int _symbolLeftOffset;
        private static int _symbolTopOffset;
        private static string[] _bombSymbol = new [] {
            "                                                         c=====e" ,
            "                                                            H   " ,
            "   ____________                                         _,,_H_ _" ,
            "  (__((__((___()                                       //|     |" ,
            " (__((__((___()()_____________________________________// |ACME |" ,
            "(__((__((___()()()------------------------------------'  |_____|" } ;
    }
}