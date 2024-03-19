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
            game.makeMove(game.Player, 0);
            btnOne.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnOne.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();

            }

            //foreach (var item in game.GameBoard)
            //{
            //   lblResu.Content=item.ToString();
            //}
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 1);
            btnTwo.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnTwo.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 2);
            btnThree.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnThree.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 3);
            btnFour.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnFour.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 4);
            btnFive.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnFive.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 5);
            btnSix.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnSix.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 6);
            btnSeven.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnSeven.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}

        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            game.makeMove(game.Player, 7);
            btnEight.Content = game.getMark(game.Player);
            game.switchPlayer();
            lblResult.Content = "It is Player " + game.Player + "'s turn";
            btnEight.IsEnabled = false;
            if (game.isGameOver())
            {
                endGame();
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}
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
                endGame();

                //lblResult.Content = game.Player + " WINS!!!!!!!";
            }

            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content = item.ToString();
            //}
        }


        public void endGame()
        {
            btnOne.IsEnabled = false;
            btnTwo.IsEnabled = false;
            btnThree.IsEnabled = false;
            btnFour.IsEnabled = false;
            btnFive.IsEnabled = false;
            btnSix.IsEnabled = false;
            btnSeven.IsEnabled = false;
            btnEight.IsEnabled = false;
            btnNine.IsEnabled = false;

            WinScreen ws = new WinScreen();

            ws.ShowDialog();

            if (ws.replay)
            {
                replay();
            }

        }


        public void replay() {
            btnOne.IsEnabled = true;
            btnTwo.IsEnabled = true;
            btnThree.IsEnabled = true;
            btnFour.IsEnabled = true;
            btnFive.IsEnabled = true;
            btnSix.IsEnabled = true;
            btnSeven.IsEnabled = true;
            btnEight.IsEnabled = true;
            btnNine.IsEnabled = true;

            btnOne.Content = "";
            btnTwo.Content = "";
            btnThree.Content = "";
            btnFour.Content = "";
            btnFive.Content = "";
            btnSix.Content = "";
            btnSeven.Content = "";
            btnEight.Content = "";
            btnNine.Content = "";

            game.restart();

            lblResult.Content = "It is Player 1's turn";
        }


        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            
            //lblResu.Content = "";
            //foreach (var item in game.GameBoard)
            //{
            //    lblResu.Content += item.ToString();
            //}

            WinScreen ws = new WinScreen();
            ws.ShowDialog();

            if (ws.replay)
            {
                //MessageBox.Show("replay");
                replay();
            }



        }

        private void btnReplay_Click(object sender, RoutedEventArgs e)
        {
            replay();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
