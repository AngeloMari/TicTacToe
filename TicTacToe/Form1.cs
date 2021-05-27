using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class formGame : Form
    {
        public formGame()
        {
            InitializeComponent();
        }
        private void bntRestart_Click(object sender, EventArgs e)
        {//To restart the game
            btnTictac1.Text = "";
            btnTictac2.Text = "";
            btnTictac3.Text = "";
            btnTictac4.Text = "";
            btnTictac5.Text = "";
            btnTictac6.Text = "";
            btnTictac7.Text = "";
            btnTictac8.Text = "";
            btnTictac9.Text = "";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {//To show how to play the game
            MessageBox.Show("How to play Tic Tac Toe" +
                "\n\n\n" + "1. The game should be played on a grid of 3 by 3 squares." +
                "\n\n2. It is played by 2 players. One player will use 'X,' while the other is 'O,'" +
                " to mark the square alternately." +
                "\n\n3. The first player to mark the squares 3 in a row, up, down, or diagonal, will be the winner." +
                "\n\n4. When all the squares are full, the game is over." +
                "\n\n5. If the squares are full, but there are no patterns created, then the game is draw.");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {//To show what the game is all about
            MessageBox.Show("Tic Tac Toe\n\nIt is one of the most known games in the world. " +
                "The game was even found out inside the temples of Egypt, where ancient Egyptians believe that it is a 'Magic Square.' " +
                "Experts believe that the name Tic Tac Toe is from a 19th-century popular game " +
                "called 'ticktack,' and it has different rules. " + "On the other hand, it said that the original name" +
                " of the game in the 16th-century is called 'Tit-tat-toe.'" + "\n\n\n" +
                "If you want to read more, check out:\n" +
                "\nhttp://gamescrafters.berkeley.edu/games.php?game=tictactoe" +
                "\nhttps://wonderopolis.org/wonder/how-old-is-tic-tac-toe");
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {//To exit the game
            Application.Exit();
        }

        bool xTurn = true;
        //int numTurn = 0;

        private void btnTictac_Click(object sender, EventArgs e)
        {
            Button move = (Button)sender;
            if (xTurn)
                move.Text = "X";
            else
                move.Text = "O";

            xTurn = !xTurn;
            move.Enabled = false;
        }
    }
}
