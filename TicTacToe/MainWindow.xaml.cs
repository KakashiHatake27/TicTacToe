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

namespace TicTacToe
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

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "7";

        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "9";
        }
    }
}
