using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TicTacToe
{
    internal class game
    {
        public game()
        {
        }

        public static int player;
        private static string playerOneName;
        private static string playerTwoName;
        public static int[] gameBoard;

        public static string PlayerOneName { get => playerOneName; set => playerOneName = value; }
        public static string PlayerTwoName { get => playerTwoName; set => playerTwoName = value; }

        public static void makeMove(int player, int position) {
            gameBoard[position] = player;   
        }


        public static bool GameOver() {
            return false;
        }

        public static void Game() { 
        
        }
    }
}
