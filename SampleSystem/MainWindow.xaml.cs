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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRightMenuShow_Click(object sender, RoutedEventArgs e)
        {
            menuslide(true);
        }

        private void menuslide(bool isVisible)
        {
            //throw new NotImplementedException();

            string[] p = new string[] { "sbShowRightMenu", "sbHideRightMenu" };
             Storyboard sb = Resources[p[isVisible ? 0 : 1]] as Storyboard;
            sb.Begin(Notifs);
            if (isVisible)
            {
                btnRightMenuShow.Visibility = System.Windows.Visibility.Hidden;
                btnRightMenuHide.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                btnRightMenuShow.Visibility = System.Windows.Visibility.Visible;
                btnRightMenuHide.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void btnRightMenuHide_Click(object sender, RoutedEventArgs e)
        {
            menuslide(false);
            Console.WriteLine("btnhide was click");
        }
    }

    public class MarginConverter : IValueConverter
    {
        public Dock Margin { get; set; } = Dock.Left;
        public double Multiplier { get; set; } = 1;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (this.Margin)
            {
                case Dock.Left:
                    return new Thickness((double)value * Multiplier, 0, 0, 0);
                case Dock.Top:
                    return new Thickness(0, (double)value * Multiplier, 0, 0);
                case Dock.Right:
                    return new Thickness(0, 0, (double)value * Multiplier, 0);
                case Dock.Bottom:
                    return new Thickness(0, 0, 0, (double)value * Multiplier);
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
