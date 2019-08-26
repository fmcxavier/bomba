using System;
using Core;
using Core.Enums;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            while(playing)
            {
                string command;
                StartScreen();

                command = Console.ReadLine();

                if(ValidateCommand(command))
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

        private static bool ValidateCommand(string command)
        {
            bool isValid =
                (command.ToLower() == "quit") ||
                (command.ToWireType() != WireType.Invalid);

            return isValid;
        }

        private static WireList CreateWireList()
        {
            var result = new WireList();

            return result;
        }
    }
}