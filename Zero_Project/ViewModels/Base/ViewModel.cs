using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zero_Project.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Задачей данного метода является уведомление графической части приложения о том, 
        /// что внутри нашего объекта изменилось какое-то свойство.
        /// </summary>
        /// <param name="PropertyName">Имя свойства</param>
        protected virtual void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        /// Задачей данного метода является обновление значения свойства,
        /// для которого определено поле, в котором это свойство хранит свои данные.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">Ссылка на поле свойства</param>
        /// <param name="value">Новое значение для свойства</param>
        /// <param name="PropertyName">Имя свойства</param>
        /// <returns></returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if(Equals(field, value)) return false; 

            field = value;

            OnPropertyChanged(PropertyName);

            return true;
        }
    }
}
