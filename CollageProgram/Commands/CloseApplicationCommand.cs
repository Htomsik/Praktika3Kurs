using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageProgram.Commands
{
    public class CloseApplicationCommand:BaseCommand
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            MessageBoxResult MessgaBoxCloseApp = MessageBox.Show("Закрыть приложение?"," ", MessageBoxButton.YesNo);

            switch (MessgaBoxCloseApp)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
                
            }


        }
    }
}
