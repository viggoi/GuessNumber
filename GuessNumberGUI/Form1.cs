using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGUI
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int randNum;
        int numGuesses;
        public Form1()
        {
            InitializeComponent();
            NewNumber();
        }

        void NewNumber()
        {
            randNum = random.Next(1, 101);
            numGuesses = 0;
        }

        void Check()
        {
            if (int.TryParse(textBox1.Text, out int guess))
            {
                numGuesses += 1;

                if (guess == randNum)
                {
                    textBox2.Lines = new string[]
                    {
                        "You guessed correctly.",
                        $"It took you {numGuesses} tries.",
                        "A new number has been randomized.",
                    };
                    NewNumber();
                }
                else if (guess > randNum)
                    textBox2.Text = $"You guessed too high";
                else if (guess < randNum)
                    textBox2.Text = $"You guessed too low";
            }
            else
            {
                textBox2.Text = "Not a number";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                Check();
            }
        }
    }
}
