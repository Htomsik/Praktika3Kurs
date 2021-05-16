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

        SwitchingViewsMVVM.ViewModels.BaseViewModel[] _ViewModelArray = new SwitchingViewsMVVM.ViewModels.BaseViewModel[]
           {
                new HomeViewModel(),
                new _Pr1ViewModel(),
                new _Pr2ViewModel(),
                new _Pr3ViewModel(),
                new _Pr4ViewModel(),
                new _Pr5ViewModel(),
                new _Pr6ViewModel(),
                new _Pr7ViewModel(),
                new _Pr8ViewModel(),
                new _Pr9ViewModel()
           };

        public override void Execute(object parameter)
        {          

             viewModel.SelectedViewModel = _ViewModelArray[Convert.ToInt32(parameter)];
   
        }
    }
}
