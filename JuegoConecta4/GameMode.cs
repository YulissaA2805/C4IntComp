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
    public partial class GameMode : Form
    {
        public static string mode = "";

        public GameMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Jugador 1 vs Jugador 2
        {
            mode = "1vs2";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Jugador 1 vs CPU
        {
            mode = "1vsCPU";
        }
    }
}
