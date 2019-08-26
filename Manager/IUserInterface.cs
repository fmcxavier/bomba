using Core;
using Core.Enums;

namespace Manager
{
    public interface IUserInterface
    {
        WireList GetInput();
        void Output(ResultType result);
    }
}