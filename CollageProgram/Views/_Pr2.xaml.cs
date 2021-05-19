using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollageProgram.Views
{
    /// <summary>
    /// Логика взаимодействия для _Pr2.xaml
    /// </summary>
    public partial class _Pr2 : UserControl
    {
        public _Pr2()
        {
            InitializeComponent();
        }
        Random R = new Random();
        int square;
        int rectangle;
        int Ellipse;
        Grid grid;
        public SolidColorBrush Custombrush { get; private set; }
        Random r = new Random();

        private void AddOrRemoveItems(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Grid)
            {
                dynamic activeRec = e.OriginalSource;
                _Canavs.Children.Remove(activeRec);

                Rectangle _rectangle = activeRec.Children[0] as Rectangle;

                if (_rectangle != null && _rectangle.Width == _rectangle.Height)
                {
                    square -= 1;
                    _SquareScore.Content = square;
                }
                if (_rectangle != null && _rectangle.Width != _rectangle.Height)
                {
                    rectangle -= 1;
                    _RectangleScore.Content = rectangle;
                }
                if (activeRec.Children[0] is Ellipse)
                {
                    Ellipse -= 1;
                    _ElipseScore.Content = Ellipse;
                }
            }
            else
            {

                Custombrush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
                grid = new Grid();

                Additem(r.Next(0, 2));

                Canvas.SetLeft(grid, Mouse.GetPosition(_Canavs).X);
                Canvas.SetTop(grid, Mouse.GetPosition(_Canavs).Y);

                _Canavs.Children.Add(grid);

                Rectangle re = grid.Children[0] as Rectangle;

                if (re != null && re.Width == re.Height)
                {
                    square += 1;
                    _SquareScore.Content = square;
                }
                if (re != null && re.Width != re.Height)
                {
                    rectangle += 1;
                    _RectangleScore.Content = rectangle;
                }
                if (grid.Children[0] is Ellipse)
                {
                    Ellipse += 1;
                    _ElipseScore.Content = Ellipse;
                }

            }
        }
        private void Additem(int _What)
        {
            if (_What == 0)
            {
                grid.Children.Add(new Rectangle
                {
                    Width = R.Next(75, 80),
                    Height = R.Next(75, 80),
                    StrokeThickness = 3,
                    Fill = Custombrush,
                    Stroke = Brushes.Black,
                    IsEnabled = false
                });

                grid.Children.Add(new TextBlock
                { Text = ("X:" + Mouse.GetPosition(_Canavs).X + "\n" + "Y:" + Mouse.GetPosition(_Canavs).Y), HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, IsEnabled = false });
            }
            else
            {
                grid.Children.Add(new Ellipse
                {
                    Width = R.Next(80, 100),
                    Height = R.Next(80, 100),
                    StrokeThickness = 3,
                    Fill = Custombrush,
                    Stroke = Brushes.Black,
                    IsEnabled = false

                });

                grid.Children.Add(new TextBlock { Text = ("X:" + Mouse.GetPosition(_Canavs).X + "\n" + "Y:" + Mouse.GetPosition(_Canavs).Y), HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, IsEnabled = false });
            }


        }
    }
}
