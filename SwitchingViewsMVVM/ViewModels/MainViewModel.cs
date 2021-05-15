using SwitchingViewsMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using SwitchingViewsMVVM.Models;

namespace SwitchingViewsMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public List<PageList> _PageLists { get; set; }
        //public object[] _PageNameArray
        //{
        //    get
        //    {
        //        return new object[] { "Home", "1", "2", "3" };
        //    }
        //}

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


            #region Список страниц
            _PageLists = new List<PageList>
            {
                new PageList
                {
                    Contents="Главная страница",
                     Tags = "0"
                },
                new PageList
                {
                    Contents="Простейшие элементы управления",
                     Tags = "1"
                },
                 new PageList
                {
                    Contents="Динамическое управление элементами",
                     Tags = "2"
                },
                  new PageList
                {
                    Contents="Настройки приложения",
                     Tags = "3"
                },
                   new PageList
                {
                    Contents="Программирование линейных алгоритмов",
                     Tags = "4"
                },
                    new PageList
                {
                    Contents="Программирование разветвляющихся алгоритмов",
                     Tags = "5"
                }, new PageList
                {
                    Contents="Программирование циклических алгоритмов",
                     Tags = "6"
                },
                 new PageList
                {
                    Contents="Работа со списками, панелями, вкладками",
                     Tags = "7"
                },
                 new PageList
                 {
                     Contents="Работа с меню и диалоговыми окнами",
                     Tags="8"
                 },
                 new PageList
                 {
                     Contents="Дополнительное задание",
                     Tags="9"
                 }
            };
            #endregion
        }
    }
}
