using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Winner
    {
        public bool xTurn = true; // X will appear
        public int numTurn = 0;   //Number of turns
        public string Tictac1 = "";
        public string Tictac2 = "";
        public string Tictac3 = "";
        public string Tictac4 = "";
        public string Tictac5 = "";
        public string Tictac6 = "";
        public string Tictac7 = "";
        public string Tictac8 = "";
        public string Tictac9 = "";
        public bool TictacEnabler1 = true;
        public bool TictacEnabler2 = true;
        public bool TictacEnabler3 = true;
        public bool TictacEnabler4 = true;
        public bool TictacEnabler5 = true;
        public bool TictacEnabler6 = true;
        public bool TictacEnabler7 = true;
        public bool TictacEnabler8 = true;
        public bool TictacEnabler9 = true;

        public void winChecker()
        {//To check if there is a winner
            bool winner = false;

            //For horizontal patterns
            if ((Tictac1.Equals(Tictac2)) && (Tictac2.Equals(Tictac3)) && (!TictacEnabler1))
                winner = true;
            else if ((Tictac4.Equals(Tictac5)) && (Tictac5.Equals(Tictac6)) && (!TictacEnabler4))
                winner = true;
            else if ((Tictac7.Equals(Tictac8)) && (Tictac8.Equals(Tictac9)) && (!TictacEnabler7))
                winner = true;

            //For vertical patterns
            if ((Tictac1.Equals(Tictac4)) && (Tictac4.Equals(Tictac7)) && (!TictacEnabler1))
                winner = true;
            else if ((Tictac2.Equals(Tictac5)) && (Tictac5.Equals(Tictac8)) && (!TictacEnabler2))
                winner = true;
            else if ((Tictac3.Equals(Tictac6)) && (Tictac6.Equals(Tictac9)) && (!TictacEnabler3))
                winner = true;

            //For Diagonal patterns
            if ((Tictac1.Equals(Tictac5)) && (Tictac5.Equals(Tictac9)) && (!TictacEnabler1))
                winner = true;
            else if ((Tictac3.Equals(Tictac5)) && (Tictac5.Equals(Tictac7)) && (!TictacEnabler3))
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

                TictacEnabler1 = false;
                TictacEnabler2 = false;
                TictacEnabler3 = false;
                TictacEnabler4 = false;
                TictacEnabler5 = false;
                TictacEnabler6 = false;
                TictacEnabler7 = false;
                TictacEnabler8 = false;
                TictacEnabler9 = false;
            }

            else if (numTurn == 9)
            {// To show if the game is draw
                Draw drawForm = new Draw();
                drawForm.Show();

                TictacEnabler1 = false;
                TictacEnabler2 = false;
                TictacEnabler3 = false;
                TictacEnabler4 = false;
                TictacEnabler5 = false;
                TictacEnabler6 = false;
                TictacEnabler7 = false;
                TictacEnabler8 = false;
                TictacEnabler9 = false;            
            }
        }
    }
}
