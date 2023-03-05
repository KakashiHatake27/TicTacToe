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

        game game = new game();



        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnOne.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnOne.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
               lblResu.Content=item.ToString();
            }
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnTwo.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnTwo.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnThree.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnThree.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnFour.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnFour.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnFive.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnFive.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnSix.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnSix.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnSeven.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnSeven.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }

        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnEight.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnEight.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 8);
            btnNine.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnNine.IsEnabled = false;
            if (game.isGameOver())
            {
                lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            foreach (var item in game.GameBoard)
            {
                lblResu.Content = item.ToString();
            }
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {

            lblResu.Content = "";
            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content += item.ToString();
            //}

            int[] boa = { 0, 0, 0, 0 };


            boa[2] = 1;
            boa[1] = 5;


            foreach (var i in boa)
            {
                lblResu.Content += i.ToString();
            }
            //lblResu.Content += " " + ;
        }
    }
}
