using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SwitchingViewsMVVM.Views
{
    public partial class _Pr1 : UserControl
    {
        Random R = new Random();
        List<TextBlock> L = new List<TextBlock>();

        public _Pr1()
        {
            InitializeComponent();
            foreach (var item in Grid1.Children.OfType<TextBlock>())
            {
                L.Add(item);
            }
        }
        int q = 0;
        bool Flag = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int random = R.Next(0, 4);
            int random2 = R.Next(0, 4);
            L[random2].Visibility = Visibility.Visible;

            L[random].Visibility = Visibility.Hidden;
            for (int i = 0; i < 4; i++)
            {
                if (L[i].Visibility == Visibility.Hidden)
                {
                    q++;
                    if (q == 4) Flag = true;
                }
                else
                {
                    q = 0;
                    break;
                }
            }


            if (Flag)
            {
                MessageBoxResult result = MessageBox.Show("Сыграть снова?", "Победа", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                if (result == MessageBoxResult.Yes)
                {
                    var currentExecutablePath = Process.GetCurrentProcess().MainModule.FileName;
                    Process.Start(currentExecutablePath);
                }
                else
                {
                    Application.Current.Shutdown();
                }
            }
        }
    }
}
