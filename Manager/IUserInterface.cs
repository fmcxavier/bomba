using Core;

namespace Manager
{
    public interface IUserInterface
    {
        WireQueue GetInput();
        void Output(ResultType result);
    }
}