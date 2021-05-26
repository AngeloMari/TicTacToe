
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.bntRestart = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnNorthWest = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouthWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnNorthEast = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouthEast = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(-1, -1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // bntRestart
            // 
            this.bntRestart.Location = new System.Drawing.Point(57, -1);
            this.bntRestart.Name = "bntRestart";
            this.bntRestart.Size = new System.Drawing.Size(62, 23);
            this.bntRestart.TabIndex = 1;
            this.bntRestart.Text = "Restart";
            this.bntRestart.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(116, -1);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(62, 23);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnNorthWest
            // 
            this.btnNorthWest.Location = new System.Drawing.Point(45, 47);
            this.btnNorthWest.Name = "btnNorthWest";
            this.btnNorthWest.Size = new System.Drawing.Size(83, 68);
            this.btnNorthWest.TabIndex = 3;
            this.btnNorthWest.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(45, 111);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(83, 68);
            this.btnWest.TabIndex = 4;
            this.btnWest.UseVisualStyleBackColor = true;
            // 
            // btnSouthWest
            // 
            this.btnSouthWest.Location = new System.Drawing.Point(45, 175);
            this.btnSouthWest.Name = "btnSouthWest";
            this.btnSouthWest.Size = new System.Drawing.Size(83, 68);
            this.btnSouthWest.TabIndex = 5;
            this.btnSouthWest.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(125, 47);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(83, 68);
            this.btnNorth.TabIndex = 6;
            this.btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(125, 111);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(83, 68);
            this.btnCenter.TabIndex = 7;
            this.btnCenter.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(125, 175);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(83, 68);
            this.btnSouth.TabIndex = 8;
            this.btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnNorthEast
            // 
            this.btnNorthEast.Location = new System.Drawing.Point(203, 47);
            this.btnNorthEast.Name = "btnNorthEast";
            this.btnNorthEast.Size = new System.Drawing.Size(83, 68);
            this.btnNorthEast.TabIndex = 9;
            this.btnNorthEast.UseVisualStyleBackColor = true;
            this.btnNorthEast.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(203, 111);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(83, 68);
            this.btnEast.TabIndex = 10;
            this.btnEast.UseVisualStyleBackColor = true;
            // 
            // btnSouthEast
            // 
            this.btnSouthEast.Location = new System.Drawing.Point(203, 175);
            this.btnSouthEast.Name = "btnSouthEast";
            this.btnSouthEast.Size = new System.Drawing.Size(83, 68);
            this.btnSouthEast.TabIndex = 11;
            this.btnSouthEast.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(331, -1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(62, 23);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(272, -1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(62, 23);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 323);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSouthEast);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorthEast);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnSouthWest);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorthWest);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.bntRestart);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button bntRestart;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnNorthWest;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouthWest;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnNorthEast;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouthEast;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
    }
}

