using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace totito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public int juego;

        private void button3_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button3.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button3.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inicio de juego, turno de: X");
            juego =1;
            HabilitarCajas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InhabilitarCajas();
        }
        private void verificarGanador()
        {
            if (button1.Text == "X" && button1.Text == button2.Text && button2.Text == button3.Text)
                MessageBox.Show("El ganador es: X");
            else if (button4.Text == "X" && button4.Text == button5.Text && button5.Text == button6.Text)
                MessageBox.Show("El ganador es: X");
            else if (button7.Text == "X" && button7.Text == button8.Text && button8.Text == button9.Text)
                MessageBox.Show("El ganador es: X");
            else if (button1.Text == "X" && button1.Text == button4.Text && button4.Text == button7.Text)
                MessageBox.Show("El ganador es: X");
            else if (button2.Text == "X" && button2.Text == button5.Text && button5.Text == button8.Text)
                MessageBox.Show("El ganador es: X");
            else if (button3.Text == "X" && button3.Text == button6.Text && button6.Text == button9.Text)
                MessageBox.Show("El ganador es: X");
            else if (button1.Text == "X" && button1.Text == button5.Text && button5.Text == button9.Text)
                MessageBox.Show("El ganador es: X");
            else if (button3.Text == "X" && button3.Text == button5.Text && button5.Text == button7.Text)
                MessageBox.Show("El ganador es: X");
            else if (button1.Text == "O" && button1.Text == button2.Text && button2.Text == button3.Text)
                MessageBox.Show("El ganador es: O");
            else if (button4.Text == "O" && button4.Text == button5.Text && button5.Text == button6.Text)
                MessageBox.Show("El ganador es: O");
            else if (button7.Text == "O" && button7.Text == button8.Text && button8.Text == button9.Text)
                MessageBox.Show("El ganador es: O");
            else if (button1.Text == "O" && button1.Text == button4.Text && button4.Text == button7.Text)
                MessageBox.Show("El ganador es: O");
            else if (button2.Text == "O" && button2.Text == button5.Text && button5.Text == button8.Text)
                MessageBox.Show("El ganador es: O");
            else if (button3.Text == "O" && button3.Text == button6.Text && button6.Text == button9.Text)
                MessageBox.Show("El ganador es: O");
            else if (button1.Text == "O" && button1.Text == button5.Text && button5.Text == button9.Text)
                MessageBox.Show("El ganador es: O");
            else if (button3.Text == "O" && button3.Text == button5.Text && button5.Text == button7.Text)
                MessageBox.Show("El ganador es: O");
            else if (TodosEmpates()) 
                label2.Text = "Empate";

        }
        private void HabilitarCajas() 
        { 
           button1.Enabled = true;
           button2.Enabled = true;
           button3.Enabled = true;
           button4.Enabled = true;
           button5.Enabled = true;
           button6.Enabled = true;
           button7.Enabled = true;
           button8.Enabled = true;
           button9.Enabled = true;
        }
        private void InhabilitarCajas() 
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private bool TodosEmpates() 
        {
            return button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                   button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                   button7.Text != "" && button8.Text != "" && button9.Text != "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button1.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else 
            {
                button1.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button2.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button2.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button4.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button4.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button5.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button5.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button6.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button6.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button7.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button7.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button8.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button8.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (juego == 1)
            {
                button9.Text = "X";
                juego = 0;
                verificarGanador();
            }
            else
            {
                button9.Text = "O";
                juego = 1;
                verificarGanador();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
    }
}
