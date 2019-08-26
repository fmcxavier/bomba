using Core;
using Core.Enums;

namespace Manager
{
    public class Game
    {
        private WireList _commands;

        public bool ValidateCommand(string command)
        {
            bool isValid =
                (command.ToLower() == "quit") ||
                (command.ToWireType() != WireType.Invalid);

            return isValid;
        }

        public WireList CreateWireList()
        {
            var result = new WireList();

            return result;
        }
    }
}