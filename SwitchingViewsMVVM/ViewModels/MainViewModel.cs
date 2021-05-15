using SwitchingViewsMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace SwitchingViewsMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public object[] _PageNameArray
        {
            get
            {
                return new object[] { "Home", "1", "2", "3" };
            }
        }

        #region title
        private string _Title = "Несутулов/Краснов 418";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region width
        private int _Width = 60;
        public int Width
        {
            get => _Width;
            set => Set(ref _Width, value);
        }
        #endregion

        #region Выбор страниц
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }

        #endregion

        

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
