using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CD3_Kyrkosh.Command
{
    public class RelayCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;
        //The action is a Delegate which encapsulates a method that has a single parameter and does not return a value.
        private Action<object> _execute;
        //The Predicate is also a Delegate encapsulating a method that has a sinple parameter and a bool as return value
        private Predicate<object> _canExecute;
        //Both delegates are provided from the .NET Framework

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {

            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// evaluate canexecute code to check if command is executeable or not
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        /// <summary>
        /// Execute method provided via Action
        /// The action is a Delegate which encapsulates a method that has a single parameter and does not return a value.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }



    }
}
