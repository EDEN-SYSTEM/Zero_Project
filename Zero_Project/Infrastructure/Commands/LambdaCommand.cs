using Zero_Project.Infrastructure.Commands.Base;
using System;

namespace Zero_Project.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        /// <summary>
        /// Задачей данного метода является определение доступности привязанной к нему комманды на ее выполнение.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        /// <summary>
        /// Задачей данного метода является выполнение тела команды, 
        /// которая привязана к данному методу.
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter) => _Execute(parameter);
    }
}
