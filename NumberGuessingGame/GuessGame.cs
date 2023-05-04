using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class GuessGame : Form
    {
        Guess game;
        public GuessGame()
        {
            InitializeComponent();
            txtGamesPlayed.ReadOnly = true;
            txtLosses.ReadOnly = true;
            txtWins.ReadOnly = true;
            game = new Guess();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnGuess.Hide();
            var instructions = MessageBox.Show("Here are the rules: \n\n1.You must guess the number between 1 and 100" +
                "\n2.You have 10 tries to guess the correct number. " +
                "\n3.Guess the right number before you run out of tries and you win!" +
                "\n\n**During the course of the game you'll get a hint to let you know whether the guess was too high or too low.");

            btnPlay.Hide();
            btnGuess.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Boolean outcome = game.Check();
            if(outcome)
            {
                var correct = MessageBox.Show("You were right");
            }
            else
            {
                var incorrect = MessageBox.Show("Your guess was too " + game.Compare());
            }
            txtTries.Text = game.Tries.ToString();
            txtGamesPlayed.Text = game.GamesPlayed.ToString();
            txtWins.Text = game.Wins.ToString();
            txtLosses.Text = game.Losses.ToString();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int user = 0;
            int.TryParse(txtInput.Text, out user);
            game.UserInput = user;
        }
    }
}
