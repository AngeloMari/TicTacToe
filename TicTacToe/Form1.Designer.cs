
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
            this.btnSTART = new System.Windows.Forms.Button();
            this.bntRESTART = new System.Windows.Forms.Button();
            this.btnUNDO = new System.Windows.Forms.Button();
            this.btnNorthWest = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouthWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnNorthEast = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouthEast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(-1, -1);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(62, 23);
            this.btnSTART.TabIndex = 0;
            this.btnSTART.Text = "Start";
            this.btnSTART.UseVisualStyleBackColor = true;
            // 
            // bntRESTART
            // 
            this.bntRESTART.Location = new System.Drawing.Point(57, -1);
            this.bntRESTART.Name = "bntRESTART";
            this.bntRESTART.Size = new System.Drawing.Size(62, 23);
            this.bntRESTART.TabIndex = 1;
            this.bntRESTART.Text = "Restart";
            this.bntRESTART.UseVisualStyleBackColor = true;
            // 
            // btnUNDO
            // 
            this.btnUNDO.Location = new System.Drawing.Point(116, -1);
            this.btnUNDO.Name = "btnUNDO";
            this.btnUNDO.Size = new System.Drawing.Size(62, 23);
            this.btnUNDO.TabIndex = 2;
            this.btnUNDO.Text = "Undo";
            this.btnUNDO.UseVisualStyleBackColor = true;
            // 
            // btnNorthWest
            // 
            this.btnNorthWest.Location = new System.Drawing.Point(36, 47);
            this.btnNorthWest.Name = "btnNorthWest";
            this.btnNorthWest.Size = new System.Drawing.Size(83, 68);
            this.btnNorthWest.TabIndex = 3;
            this.btnNorthWest.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(36, 121);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(83, 68);
            this.btnWest.TabIndex = 4;
            this.btnWest.UseVisualStyleBackColor = true;
            // 
            // btnSouthWest
            // 
            this.btnSouthWest.Location = new System.Drawing.Point(36, 195);
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
            this.btnCenter.Location = new System.Drawing.Point(125, 121);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(83, 68);
            this.btnCenter.TabIndex = 7;
            this.btnCenter.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(125, 195);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(83, 68);
            this.btnSouth.TabIndex = 8;
            this.btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnNorthEast
            // 
            this.btnNorthEast.Location = new System.Drawing.Point(214, 47);
            this.btnNorthEast.Name = "btnNorthEast";
            this.btnNorthEast.Size = new System.Drawing.Size(83, 68);
            this.btnNorthEast.TabIndex = 9;
            this.btnNorthEast.UseVisualStyleBackColor = true;
            this.btnNorthEast.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(214, 121);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(83, 68);
            this.btnEast.TabIndex = 10;
            this.btnEast.UseVisualStyleBackColor = true;
            // 
            // btnSouthEast
            // 
            this.btnSouthEast.Location = new System.Drawing.Point(214, 195);
            this.btnSouthEast.Name = "btnSouthEast";
            this.btnSouthEast.Size = new System.Drawing.Size(83, 68);
            this.btnSouthEast.TabIndex = 11;
            this.btnSouthEast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 287);
            this.Controls.Add(this.btnSouthEast);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorthEast);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnSouthWest);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorthWest);
            this.Controls.Add(this.btnUNDO);
            this.Controls.Add(this.bntRESTART);
            this.Controls.Add(this.btnSTART);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Button bntRESTART;
        private System.Windows.Forms.Button btnUNDO;
        private System.Windows.Forms.Button btnNorthWest;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouthWest;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnNorthEast;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouthEast;
    }
}

