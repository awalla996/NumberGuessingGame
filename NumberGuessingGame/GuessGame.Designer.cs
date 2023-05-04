
namespace NumberGuessingGame
{
    partial class GuessGame
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.txtGamesPlayed = new System.Windows.Forms.TextBox();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.txtLosses = new System.Windows.Forms.TextBox();
            this.lblPreInstructions = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.txtTries = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(298, 175);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(226, 27);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(344, 210);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(124, 38);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(320, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 19);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Number Guessing Game";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(344, 256);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(124, 42);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(18, 70);
            this.lblGamesPlayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(114, 19);
            this.lblGamesPlayed.TabIndex = 4;
            this.lblGamesPlayed.Text = "Games played:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(82, 137);
            this.lblWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(49, 19);
            this.lblWins.TabIndex = 5;
            this.lblWins.Text = "Wins:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(68, 200);
            this.lblLosses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(61, 19);
            this.lblLosses.TabIndex = 6;
            this.lblLosses.Text = "Losses:";
            // 
            // txtGamesPlayed
            // 
            this.txtGamesPlayed.Location = new System.Drawing.Point(142, 60);
            this.txtGamesPlayed.Margin = new System.Windows.Forms.Padding(4);
            this.txtGamesPlayed.Name = "txtGamesPlayed";
            this.txtGamesPlayed.Size = new System.Drawing.Size(85, 27);
            this.txtGamesPlayed.TabIndex = 7;
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(142, 127);
            this.txtWins.Margin = new System.Windows.Forms.Padding(4);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(85, 27);
            this.txtWins.TabIndex = 8;
            // 
            // txtLosses
            // 
            this.txtLosses.Location = new System.Drawing.Point(142, 190);
            this.txtLosses.Margin = new System.Windows.Forms.Padding(4);
            this.txtLosses.Name = "txtLosses";
            this.txtLosses.Size = new System.Drawing.Size(85, 27);
            this.txtLosses.TabIndex = 9;
            // 
            // lblPreInstructions
            // 
            this.lblPreInstructions.AutoSize = true;
            this.lblPreInstructions.Location = new System.Drawing.Point(314, 114);
            this.lblPreInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreInstructions.Name = "lblPreInstructions";
            this.lblPreInstructions.Size = new System.Drawing.Size(191, 19);
            this.lblPreInstructions.TabIndex = 10;
            this.lblPreInstructions.Text = "Press play for instructions";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(80, 279);
            this.lblTries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(50, 19);
            this.lblTries.TabIndex = 11;
            this.lblTries.Text = "Tries:";
            // 
            // txtTries
            // 
            this.txtTries.Location = new System.Drawing.Point(141, 270);
            this.txtTries.Margin = new System.Windows.Forms.Padding(4);
            this.txtTries.Name = "txtTries";
            this.txtTries.Size = new System.Drawing.Size(85, 27);
            this.txtTries.TabIndex = 12;
            // 
            // GuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTries);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblPreInstructions);
            this.Controls.Add(this.txtLosses);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.txtGamesPlayed);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtInput);
            this.Name = "GuessGame";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.TextBox txtGamesPlayed;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.TextBox txtLosses;
        private System.Windows.Forms.Label lblPreInstructions;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.TextBox txtTries;
    }
}

