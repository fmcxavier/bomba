using Core;

namespace Manager
{
    public interface IUserInterface
    {
        WireList GetInput();
        void Output(ResultType result);
    }
}