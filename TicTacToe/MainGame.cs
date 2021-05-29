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

            numTurn = 0; //To avoid error in Draw message
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
 
        bool xTurn = true; // X will appear
        int numTurn = 0;   //Number of turns

        private void btnTictac_Click(object sender, EventArgs e)
        {   //To know whi's to move
            Button move = (Button)sender;
            if (xTurn)
                move.Text = "X";
            else
                move.Text = "O";

            xTurn = !xTurn;       //To flip from X to O
            move.Enabled = false; //To disable the button after the move
            numTurn++;            //To count the number of turns

            winChecker();
        }

        private void winChecker()
        {//To check if there is a winner
            bool winner = false;

            //For horizontal patterns
            if ((btnTictac1.Text == btnTictac2.Text) && (btnTictac2.Text == btnTictac3.Text) && (!btnTictac1.Enabled))
                winner = true;
            else if ((btnTictac4.Text == btnTictac5.Text) && (btnTictac5.Text == btnTictac6.Text) && (!btnTictac4.Enabled))
                winner = true;
            else if ((btnTictac7.Text == btnTictac8.Text) && (btnTictac8.Text == btnTictac9.Text) && (!btnTictac7.Enabled))
                winner = true;

            //For vertical patterns
            if ((btnTictac1.Text == btnTictac4.Text) && (btnTictac4.Text == btnTictac7.Text) && (!btnTictac1.Enabled))
                winner = true;
            else if ((btnTictac2.Text == btnTictac5.Text) && (btnTictac5.Text == btnTictac8.Text) && (!btnTictac2.Enabled))
                winner = true;
            else if ((btnTictac3.Text == btnTictac6.Text) && (btnTictac6.Text == btnTictac9.Text) && (!btnTictac3.Enabled))
                winner = true;

            //For Diagonal patterns
            if ((btnTictac1.Text == btnTictac5.Text) && (btnTictac5.Text == btnTictac9.Text) && (!btnTictac1.Enabled))
                winner = true;
            else if ((btnTictac3.Text == btnTictac5.Text) && (btnTictac5.Text == btnTictac7.Text) && (!btnTictac3.Enabled))
                winner = true;


            if (winner)
            {// To show who is the winner
                if (xTurn)
                {
                    OWins owinsForm = new OWins();
                    owinsForm.Show();
                }
                else
                {
                    XWins xwinsForm = new XWins();
                    xwinsForm.Show();
                }

                btnTictac1.Enabled = false;
                btnTictac2.Enabled = false;
                btnTictac3.Enabled = false;
                btnTictac4.Enabled = false;
                btnTictac5.Enabled = false;
                btnTictac6.Enabled = false;
                btnTictac7.Enabled = false;
                btnTictac8.Enabled = false;
                btnTictac9.Enabled = false;
            }

             else if (numTurn == 9)
            {// To show if the game is draw
                Draw drawForm = new Draw();
                drawForm.Show();

                btnTictac1.Enabled = false;
                btnTictac2.Enabled = false;
                btnTictac3.Enabled = false;
                btnTictac4.Enabled = false;
                btnTictac5.Enabled = false;
                btnTictac6.Enabled = false;
                btnTictac7.Enabled = false;
                btnTictac8.Enabled = false;
                btnTictac9.Enabled = false;
            }
        }
    }
}
