﻿using SwitchingViewsMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SwitchingViewsMVVM.Commands
{
    public class UpdateViewCommand : BaseCommand
    {
        private MainViewModel viewModel;
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public override bool CanExecute(object parameter) => true;
      

        public override void Execute(object parameter)
        {
          

            switch (parameter.ToString())
            {
                case ("0"):
                    viewModel.SelectedViewModel = new HomeViewModel();
                    break;

                case ("1"):
                    viewModel.SelectedViewModel = new _Pr1ViewModel();
                    break;

                case ("2"):
                    viewModel.SelectedViewModel = new _Pr2ViewModel();
                    break;

              

                
            }

        }
    }
}
