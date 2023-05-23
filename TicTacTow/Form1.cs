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

        }

        private void Restartbutton(object sender, EventArgs e)
        {

        }
        private void CheckGame()
        {

        }
        private void RestartGame()
        {
            List<Button> buttons = new List<Button> ( button1, button2, button3, button4, button5, button6, button7, button8, button9 );
            foreach (Button s in buttons)
            {
                s.Enabled = true;
                s.Text = "Click";
                s.BackColor = DefaultBackColor;
            }
        }
    }
}
