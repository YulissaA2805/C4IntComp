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
        public char[,] tableroJuego = new char[5, 7];
        public int[] ocupadosColumna = new int[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Play(string mode)
        {
            if (mode == "1vs2")
            {
                inicializarTablero();
            }
            else//1vsCPU
            {

            }
        }

        private void inicializarTablero()
        {
            for(int i=0; i<5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    tableroJuego[i, j] = '-';
                }
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            GameMode gameMode = new GameMode();
            gameMode.ShowDialog();

            currentPlayer = "player1";
            messageTextBox.Text = "TURNO DEL JUGADOR 1";

            buttonC0.Enabled = true;
            buttonC1.Enabled = true;
            buttonC2.Enabled = true;
            buttonC3.Enabled = true;
            buttonC4.Enabled = true;
            buttonC5.Enabled = true;
            buttonC6.Enabled = true;

            Play(GameMode.mode);
            
        }

        private void historyButton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            
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

        private void PasarTurno(string jugador)
        {
            if (currentPlayer == "player1")
            {
                currentPlayer = "player2";
                messageTextBox.Text = "TURNO DEL JUGADOR 2";
            }
            else
            {
                currentPlayer = "player1";
                messageTextBox.Text = "TURNO DEL JUGADOR 1";
            }
                
        }

        private bool hayEspacioEnColumna(int columna)
        {
            for(int i=0; i<5; i++)//recorre cada fila de la columna
            {
                if(tableroJuego[i,columna] == '-')
                {
                    return true;
                }
            }
            return false;
        }

        private int ultimoEspacioEnColumna(int columna)
        {
            int ultimoEspacio = 0;
            for (int i = 4; i >= 0; i--)//recorre cada fila de la columna
            {
                if (tableroJuego[i, columna] == '-')
                {
                    if(currentPlayer == "player1")
                        tableroJuego[i, columna] = 'R';
                    else
                        tableroJuego[i, columna] = 'Y';
                    ultimoEspacio = i;
                    i = 0;
                }
            }
            return ultimoEspacio;
        }

        private void InsertarFicha(int columna)
        {
            int fila = ultimoEspacioEnColumna(columna);
            if(currentPlayer == "player1")
                this.tableLayoutPanel1.GetControlFromPosition(columna, fila).BackColor = Color.Red;
            else
                this.tableLayoutPanel1.GetControlFromPosition(columna, fila).BackColor = Color.Yellow;

            PasarTurno(currentPlayer);
        }

        private void RevisarTablero()//revisar si hay 4 de un color seguidos
        {
            int conectaP1 = 0;
            int conectaP2 = 0;

            for (int i = 4; i >= 0; i--)//recorre cada fila desde abajo
            {
                for (int j = 0; j < 7; j++)//recorre cada columna desde izquierda
                {
                    
                }
            }
        }

        private void TerminarJuego()
        {

        }

        private void buttonC0_Click(object sender, EventArgs e)
        {
            if(hayEspacioEnColumna(0))
                InsertarFicha(0);
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (hayEspacioEnColumna(1))
                InsertarFicha(1);
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (hayEspacioEnColumna(2))
                InsertarFicha(2);
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            if (hayEspacioEnColumna(3))
                InsertarFicha(3);
        }

        private void buttonC4_Click(object sender, EventArgs e)
        {
            if (hayEspacioEnColumna(4))
                InsertarFicha(4);
        }

        private void buttonC5_Click(object sender, EventArgs e)
        {
            if (hayEspacioEnColumna(5))
                InsertarFicha(5);
        }

        private void buttonC6_Click(object sender, EventArgs e)
        {
            if (hayEspacioEnColumna(6))
                InsertarFicha(6);
        }
    }
}
