using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_mvvm.MvvmFramework
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;

        public DelegateCommand(Action action)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action), "can't be null!!");
        }

        public bool CanExecute(object parameter)
        {
            return true; // If it is necessary apply a logic here, for now we can always pass to the execute method 
        }

        public void Execute(object parameter)
        {
            _action?.Invoke();  // Null safe
        }

        public event EventHandler CanExecuteChanged;
    }
}
