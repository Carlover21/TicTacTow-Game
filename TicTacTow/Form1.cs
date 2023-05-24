using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTow
{
    public partial class Form1 : Form
    {

        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int PlayerWinsCount = 0;
        int AiWinsCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aimove(object sender, EventArgs e)
        {

        }

        private void Playerbutton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Purple;
            buttons.Remove(button);
            CheckGame();
            AITimer.Start();
        }

        private void Restartbutton(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void CheckGame()
        {

        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "Click";
                button.BackColor = DefaultBackColor;
            }
        }

    }
}
