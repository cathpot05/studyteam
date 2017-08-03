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

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for TransactionUC.xaml
    /// </summary>
    public partial class TransactionUC : UserControl
    {
        public TransactionUC()
        {
            InitializeComponent();
            #region Button's Func_Leave Mouse
            foreach (StackPanel TransPanels in maintrans_panel.Children)
            {
                foreach (Button TransButtons in TransPanels.Children.OfType<Button>())
                {
                    Action<string> TransButtonFunctions = (Buttons) =>
                    {
                        switch (Buttons)
                        {
                            case "btnBarrowTrans":
                                {
                                    btnBarrowTrans.Background = (ImageBrush)Resources["Borrow_Books"];
                                }
                                break;
                            case "btnReturnTrans":
                                {
                                    btnReturnTrans.Background = (ImageBrush)Resources["Return_Books"];
                                }
                                break;
                        }
                    };
                    TransButtons.MouseLeave += delegate
                    {
                        TransButtonFunctions(TransButtons.Name);
                    };

                    TransButtons.TouchLeave += delegate
                    {
                        TransButtonFunctions(TransButtons.Name);
                    };
                }


            }
            #endregion


            #region Button's Enter Mouse
            foreach (StackPanel TransPanels in maintrans_panel.Children)
            {
                foreach (Button TransButtons in TransPanels.Children.OfType<Button>())
                {
                    Action<string> TransButtonFunctions = (Buttons) =>
                    {
                        switch (Buttons)
                        {
                            case "btnBarrowTrans":
                                {
                                    btnBarrowTrans.Background = (ImageBrush)Resources["Borrow_Books1"];
                                }
                                break;
                            case "btnReturnTrans":
                                {
                                    btnReturnTrans.Background = (ImageBrush)Resources["Return_Books1"];
                                }
                                break;
                        }
                    };
                    TransButtons.MouseEnter += delegate
                    {
                        TransButtonFunctions(TransButtons.Name);
                    };

                    TransButtons.TouchEnter += delegate
                    {
                        TransButtonFunctions(TransButtons.Name);
                    };
                }


            }
            #endregion
        }

        private void btnBack_MouseEnter(object sender, MouseEventArgs e)
        {
            btnBack.Background = (ImageBrush)Resources["BackTrans1"];
        }

        private void btnBack_TouchEnter(object sender, TouchEventArgs e)
        {
            btnBack.Background = (ImageBrush)Resources["BackTrans1"];
        }

        private void btnBack_MouseLeave(object sender, MouseEventArgs e)
        {
            btnBack.Background = (ImageBrush)Resources["BackTrans"];
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            maintrans_panel.Visibility = Visibility.Visible;
            UC_Trans.Visibility = Visibility.Collapsed;
            btnBack.IsEnabled = false;
            btnBack.Visibility = Visibility.Collapsed;
        }

        private void btnBarrowTrans_Click(object sender, RoutedEventArgs e)
        {
            maintrans_panel.Visibility = Visibility.Collapsed;
            UC_Trans.Visibility = Visibility.Visible;
            UserControl borrowBookUC = new Trans_borrow();
            UC_Trans.Content = borrowBookUC;
            btnBack.IsEnabled = true;
            btnBack.Visibility = Visibility.Visible;
        }

        private void btnReturnTrans_Click(object sender, RoutedEventArgs e)
        {
            maintrans_panel.Visibility = Visibility.Collapsed;
            UC_Trans.Visibility = Visibility.Visible;
            UserControl returnBooksUC = new Trans_return();
            UC_Trans.Content = returnBooksUC;
            btnBack.IsEnabled = true;
            btnBack.Visibility = Visibility.Visible;
        }
    }
}


