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
        Winner checker = new();
        public formGame()
        {
            InitializeComponent();
        }

        private void bntRestart_Click(object sender, EventArgs e)
        {//To restart the game
            //To reenable the buttons that were disabled in btnTictac_Click
            btnTictac1.Enabled = true;
            btnTictac2.Enabled = true;
            btnTictac3.Enabled = true;
            btnTictac4.Enabled = true;
            btnTictac5.Enabled = true;
            btnTictac6.Enabled = true;
            btnTictac7.Enabled = true;
            btnTictac8.Enabled = true;
            btnTictac9.Enabled = true;

            //To remove the "X" or "O"
            btnTictac1.Text = "";
            btnTictac2.Text = "";
            btnTictac3.Text = "";
            btnTictac4.Text = "";
            btnTictac5.Text = "";
            btnTictac6.Text = "";
            btnTictac7.Text = "";
            btnTictac8.Text = "";
            btnTictac9.Text = "";

            checker.numTurn = 0; //To avoid error in Draw message
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {//To show how to play the game
            Help helpForm = new Help();
            helpForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {//To show what the game is all about
            About aboutForm = new About();
            aboutForm.Show();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {//To exit the game
            Application.Exit();
        }

        private void btnTictac_Click(object sender, EventArgs e)
        {   //To know who's to move
            Button move = (Button)sender;
            if (checker.xTurn)
                move.Text = "X";
            else
                move.Text = "O";

            checker.xTurn = !checker.xTurn;       //To flip from X to O
            move.Enabled = false; //To disable the button after the move
            checker.numTurn++;            //To count the number of turns

            checker.Tictac1 = btnTictac1.Text;
            checker.Tictac2 = btnTictac2.Text;
            checker.Tictac3 = btnTictac3.Text;
            checker.Tictac4 = btnTictac4.Text;
            checker.Tictac5 = btnTictac5.Text;
            checker.Tictac6 = btnTictac6.Text;
            checker.Tictac7 = btnTictac7.Text;
            checker.Tictac8 = btnTictac8.Text;
            checker.Tictac9 = btnTictac9.Text;
            checker.TictacEnabler1 = btnTictac1.Enabled;
            checker.TictacEnabler2 = btnTictac2.Enabled;
            checker.TictacEnabler3 = btnTictac3.Enabled;
            checker.TictacEnabler4 = btnTictac4.Enabled;
            checker.TictacEnabler5 = btnTictac5.Enabled;
            checker.TictacEnabler6 = btnTictac6.Enabled;
            checker.TictacEnabler7 = btnTictac7.Enabled;
            checker.TictacEnabler8 = btnTictac8.Enabled;
            checker.TictacEnabler9 = btnTictac9.Enabled;
            checker.winChecker();
            btnTictac1.Enabled = checker.TictacEnabler1;
            btnTictac2.Enabled = checker.TictacEnabler2;
            btnTictac3.Enabled = checker.TictacEnabler3;
            btnTictac4.Enabled = checker.TictacEnabler4;
            btnTictac5.Enabled = checker.TictacEnabler5;
            btnTictac6.Enabled = checker.TictacEnabler6;
            btnTictac7.Enabled = checker.TictacEnabler7;
            btnTictac8.Enabled = checker.TictacEnabler8;
            btnTictac9.Enabled = checker.TictacEnabler9;
        }
    }
}
