using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SwitchingViewsMVVM.Commands
{
    internal abstract class BaseCommand:ICommand
    {
        public event EventHandler CanExecuteChanged //впф автоматически генерирует это событие у всех команд когда что то происходит
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;

        }

        public abstract bool CanExecute(object parameter); //ложь-выполнить нельзя, элемент отключается автоматически

        public abstract void Execute(object parameter); //то что должно быть выполнено
    }
}
