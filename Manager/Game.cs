using Core;
using Core.Enums;

namespace Manager
{
    public class Game
    {
        private WireList _commands;

        public bool ValidateCommand(string[] commands)
        {
            bool isValid = true;

            foreach (var command in commands)
            {
                isValid = command.ToWireType() != WireType.Invalid;

                if (!isValid)
                    break;
            }

            if (isValid)
                _commands = new WireList(commands.ToWireTypeArray());
            else
                _commands = null;

            return isValid;
        }

        public string ProcessCommands()
        {
            return _commands.CutWires().ToString();
        }
    }
}