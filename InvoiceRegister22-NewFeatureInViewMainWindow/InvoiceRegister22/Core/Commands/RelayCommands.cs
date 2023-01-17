using System;
using System.Windows.Input;

namespace InvoiceRegister22.Commands
{
    public class RelayCommands : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public RelayCommands(Action<object> execute): this(execute, x => true)
        {

        }
        public RelayCommands(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add {  CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {

            if (parameter == null)
                return _canExecute(false);
            
            return _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
                _execute(parameter);
        }
    }
}
