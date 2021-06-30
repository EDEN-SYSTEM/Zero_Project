using System;
using System.Windows.Input;

namespace Zero_Project.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;

            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Задачей данного метода является определение доступности привязанной к нему комманды на ее выполнение.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public abstract bool CanExecute(object parameter);

        /// <summary>
        /// Задачей данного метода является выполнение тела команды, 
        /// которая привязана к данному методу.
        /// </summary>
        /// <param name="parameter"></param>
        public abstract void Execute(object parameter);
    }
}
