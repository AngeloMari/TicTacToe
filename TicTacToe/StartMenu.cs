﻿using System;
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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }
        private void btnStart_click(object sender, EventArgs e)
        {
            this.Hide();

            formGame gameForm = new formGame();
            gameForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
