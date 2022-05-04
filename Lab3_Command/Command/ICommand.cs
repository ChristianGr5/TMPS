using System;
namespace Command
{
    public interface ICommand<T>
    {
        void Execute(T parameter);
    }
}
