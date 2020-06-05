using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
namespace Hangman
{
    public partial class Hangman : Form
    {
        private string targetWord = "test";
        private string guessed    = "";
        private int    lives      = 0;
        private int    attempts   = 0;

        public Hangman()
        {
            InitializeComponent();
            resetGame(true); // reset game and choose new word
        }

        private string getLives(int lives)
        {
            string livesText = "";
            if (lives>0)
                for (int i = 0; i < lives; i++) livesText += " -";
            return livesText.Trim();
        }

        private string hideWord(string word)
        {
            string hidden = "";
            foreach (var i in targetWord)
                if (this.guessed.Contains(i.ToString())) hidden += i;
                else hidden += "*";
               
            return hidden;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {

            if (winOutput.Text.Equals(""))
            {
                string guess = inputText.Text.Trim();
                string status = "";

                if (guess.Length == 0) status = "ERROR: NO USER INPUT";

                else if (guess.Length > 1) status = "ERROR: USER INPUT IS TOO LONG";

                else // correct input length
                {
                    if (this.guessed.Contains(guess)) status = "ERROR: = ALREADY BEEN GUESSED";
                    else
                    {
                        if (this.guessed.Length == 0) this.guessed += guess;
                        else this.guessed += ", " + guess;

                        if (!this.targetWord.Contains(guess))
                        {
                            status = "ERROR: INCORRECT GUESS";
                            this.lives--;
                        }
                    }
                }

                this.attempts++;

                updateTurn(status);
            }
        }

        private void updateTurn(string status)
        {
            if (this.targetWord.Equals(hideWord(this.targetWord))) winOutput.Text = "YOU WIN!!!!!";
            else if (this.lives == 0) winOutput.Text = "YOU LOSE YIKES";
            else winOutput.Text = "";

            targetWordOutput.Text = hideWord(this.targetWord);
            livesOutput.Text = getLives(this.lives);
            guessOutput.Text = this.guessed;
            attemptOutput.Text = this.attempts + "";
            statusOutput.Text = status;
            inputText.Text = "";
        }

        private void giveUpBtn_Click(object sender, EventArgs e)
        {
            resetGame(true); // reset game and choose new word
        }

        private void startOverBtn_Click(object sender, EventArgs e)
        {
            resetGame(false); // reset game but dont choose new word
        }

        private void resetGame( bool getNewWord)
        {
            if (getNewWord) // if true, read a list of new words from input.txt
            {
                List<string> words = new List<string>();
                string line = "";
                System.IO.StreamReader file = new System.IO.StreamReader("./../../../input.txt");
                while ((line = file.ReadLine()) != null) words.Add(line);
                file.Close();

                this.targetWord = words[(new Random()).Next(words.Count)];
            }
            this.lives = 5;
            this.attempts = 0;
            this.guessed = "";
            updateTurn("");
        }
    }
}
