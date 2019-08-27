using System;
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
                        PrintMessage(GetResultMessage(game.ProcessCommands()));
                    else
                        PrintMessage("Invalid command, please try again.");

                    Console.ReadKey();
                }
            }
        }

        private static string GetResultMessage(string result)
        {
            string message;

            switch (result.ToLower())
            {
                case "disarm":
                    message = "Congratulations, you survived... this time.";
                    break;
                case "explode":
                    message = "1, 2.... you died.";
                    break;
                default:
                    message = "";
                    break;
            }

            return message;
        }

        private static void PrintMessage(string message)
        {
            var leftOffset = (Console.WindowWidth - message.Length) / 2;
            var topOffset = Console.WindowHeight - _messageLineTopOffset;
            Console.SetCursorPosition(leftOffset, topOffset);
            Console.Write(message);
        }

        private static void StartScreen()
        {
            Console.Clear();
            string line = "Choose what wires to cut in order separated with a comma (or quit to...quit):";

            DrawSymbol();

            var bottomLine = Console.WindowHeight;
            Console.SetCursorPosition(0,bottomLine - 2);

            Console.WriteLine(line);
        }

        private static void DrawSymbol()
        {
            var symbolLength = _bombSymbol[0].Length;
            _symbolLeftOffset = (Console.WindowWidth - symbolLength) / 2;
            _symbolTopOffset = (Console.WindowHeight - _bombSymbol.Length - _messageLineTopOffset) / 2;


            var lineCount = 0;
            foreach (var line in _bombSymbol)
            {
                Console.SetCursorPosition(_symbolLeftOffset, _symbolTopOffset + lineCount);
                Console.WriteLine(line);
                ++lineCount;
            }
        }

        private static readonly int _messageLineTopOffset = 6;

        private static int _symbolLeftOffset;
        private static int _symbolTopOffset;
        private static readonly string[] _bombSymbol = new [] {
            "                                                         c=====e" ,
            "                                                            H   " ,
            "   ____________                                         _,,_H_ _" ,
            "  (__((__((___()                                       //|     |" ,
            " (__((__((___()()_____________________________________// |ACME |" ,
            "(__((__((___()()()------------------------------------'  |_____|" } ;
    }
}