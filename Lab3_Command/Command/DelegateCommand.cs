using System;
namespace Command
{
    public class DelegateCommand<T> : ICommand<T>
    {
        private Action<T> actionToInvoke;

        public DelegateCommand(Action<T> actionToInvoke)
        {
            this.actionToInvoke = actionToInvoke;
        }

        public void Execute(T parameter)
        {
            actionToInvoke.Invoke(parameter);
        }
    }
}
