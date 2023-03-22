using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace TicTacToe
{
    internal class game
    {
        public game()
        {
        }

        private static int player = 1;
        private static string playerOneName;
        private static string playerTwoName;
        private static int[] gameBoard = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static string PlayerOneName { get => playerOneName; set => playerOneName = value; }
        public static string PlayerTwoName { get => playerTwoName; set => playerTwoName = value; }
        public static int Player { get => player; set => player = value; }
        public static int[] GameBoard { get => gameBoard; set => gameBoard = value; }

        public static void makeMove(int player, int position)
        {
            gameBoard[position] = player;
        }

        public static string getMark(int player)
        {
            if (player == 1)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        public static int switchPlayer()
        {
            if (Player == 1)
            {
                return Player = 2;
            }
            else
            {
                return Player = 1;
            }
        }


        public static bool isGameOver()
        {
            if ((gameBoard[0] == gameBoard[1]) && (gameBoard[1] == gameBoard[2]) && (gameBoard[2] != 0))
            {
                return true;
            }
            else if ((gameBoard[3] == gameBoard[4]) && (gameBoard[4] == gameBoard[5]) && (gameBoard[5] != 0))
            {
                return true;
            }
            else if ((gameBoard[6] == gameBoard[7]) && (gameBoard[7] == gameBoard[8]) && (gameBoard[8] != 0))
            {
                return true;
            }
            else if ((gameBoard[0] == gameBoard[3]) && (gameBoard[3] == gameBoard[6]) && (gameBoard[6] != 0))
            {
                return true;
            }
            else if ((gameBoard[1] == gameBoard[4]) && (gameBoard[4] == gameBoard[7]) && (gameBoard[7] != 0))
            {
                return true;
            }
            else if ((gameBoard[2] == gameBoard[5]) && (gameBoard[5] == gameBoard[8]) && (gameBoard[8] != 0))
            {
                return true;
            }
            else if ((gameBoard[2] == gameBoard[4]) && (gameBoard[4] == gameBoard[6]) && (gameBoard[6] != 0))
            {
                return true;
            }
            else if ((gameBoard[0] == gameBoard[4]) && (gameBoard[4] == gameBoard[8]) && (gameBoard[8] != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static void Game()
        {

        }
    }
}
