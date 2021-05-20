using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollageProgram.Models;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using CollageMvvM.Commands;

namespace CollageProgram.ViewModels
{
    public class _Pr3ViewModel : BaseViewModel
    {
        #region Смена темы
        public ObservableCollection<ThemeApplication> ThemeApplication { get; set; }


        public ICommand ThemeChangeCommand { get; }

        private void OnThemeChangeCommand(object p)
        {

            var uri = new Uri(Convert.ToString(p), UriKind.Relative);

            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

            Application.Current.Resources.Clear();

            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private bool CanThemeChangeCommand(object p) =>  true;
        
        #endregion




        
        public _Pr3ViewModel()
        {
            #region Команды

            ThemeChangeCommand = new LambdaCommand(OnThemeChangeCommand, CanThemeChangeCommand);

            #endregion

            #region Создание новых тем в listview
            ThemeApplication = new ObservableCollection<ThemeApplication>
            {
                new ThemeApplication
                {
                    NameTheme="Простая",

                    UrlTheme=@"..\Resources\Themes\DefaultTheme.xaml"
                },
                new ThemeApplication
                {
                    NameTheme="Стардаст",

                    UrlTheme=@"..\Resources\Themes\StarDustCrussidersTheme.xaml"
                },
                 new ThemeApplication
                {
                    NameTheme="Каменный океан",

                    UrlTheme=@"..\Resources\Themes\StoneOceanTheme.xaml"
                }

            };
            #endregion
        }
    }
}
