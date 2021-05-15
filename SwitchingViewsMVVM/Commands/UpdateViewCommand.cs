using SwitchingViewsMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SwitchingViewsMVVM.Commands
{
    internal class UpdateViewCommand : BaseCommand
    {
        private MainViewModel viewModel;
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public override bool CanExecute(object parameter) => true;
      

        public override void Execute(object parameter)
        {
            if(parameter.ToString() == "_Pr1")
            {
                viewModel.SelectedViewModel = new _Pr1ViewModel();
            }
            else if(parameter.ToString() == "_Pr2")
            {
                viewModel.SelectedViewModel = new _Pr2ViewModel();
            }
        }
    }
}
