
namespace TicTacToe
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AboutGame = new System.Windows.Forms.RichTextBox();
            this.btnQuitAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutGame
            // 
            this.AboutGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AboutGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutGame.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutGame.Location = new System.Drawing.Point(12, 30);
            this.AboutGame.Name = "AboutGame";
            this.AboutGame.ReadOnly = true;
            this.AboutGame.Size = new System.Drawing.Size(376, 358);
            this.AboutGame.TabIndex = 0;
            this.AboutGame.Text = resources.GetString("AboutGame.Text");
            this.AboutGame.TextChanged += new System.EventHandler(this.AboutGame_TextChanged);
            // 
            // btnQuitAbout
            // 
            this.btnQuitAbout.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuitAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitAbout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitAbout.ForeColor = System.Drawing.Color.White;
            this.btnQuitAbout.Location = new System.Drawing.Point(373, 1);
            this.btnQuitAbout.Name = "btnQuitAbout";
            this.btnQuitAbout.Size = new System.Drawing.Size(26, 23);
            this.btnQuitAbout.TabIndex = 15;
            this.btnQuitAbout.Text = "X";
            this.btnQuitAbout.UseVisualStyleBackColor = false;
            this.btnQuitAbout.Click += new System.EventHandler(this.btnQuitAbout_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnQuitAbout);
            this.Controls.Add(this.AboutGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AboutGame;
        private System.Windows.Forms.Button btnQuitAbout;
    }
}