using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoConecta4
{
    public partial class Form1 : Form
    {
        public string currentPlayer = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            GameMode gameMode = new GameMode();
            gameMode.ShowDialog();

            currentPlayer = "player1";
            messageTextBox.Text += "\nTURNO DEL JUGADOR 1";

            Program.Play(GameMode.mode);
            
        }

        private void historyButton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Row == 1 && e.Column == 1)
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(123, 234, 45, 67)))
                e.Graphics.FillRectangle(GetBrushFor(currentPlayer), e.CellBounds);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private Brush GetBrushFor(string player)
        {
            if(player == "player1")
            {
                return Brushes.Red;
            }
            else
            {
                return Brushes.Yellow;
            }
            
        }
    }
}
