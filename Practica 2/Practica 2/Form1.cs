using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        bool turno = true;
        int j1 = 0, j2 = 0, empate = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void reinicio() {
            button1.Text = "-";
            button2.Text = "-";
            button3.Text = "-";
            button4.Text = "-";
            button5.Text = "-";
            button6.Text = "-";
            button7.Text = "-";
            button8.Text = "-";
            button9.Text = "-";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 2;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 2;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.BorderSize = 2;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.BorderSize = 2;
        }
        public int comprobacion()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
               button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Gana el jugador 1 'X'");
                j1++;
                label2.Text = "Jugador 1(X): " + j1;
                reinicio();
                return 1;
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
               button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
               button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
               button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Gana el jugador 2 'O'");
                j2++;
                label3.Text = "Jugador 2(O): " + j2;
                reinicio();
                return 1;
            }
            if(button1.Text != "-" && button2.Text != "-" && button3.Text != "-" && button4.Text != "-" && button5.Text != "-" && button6.Text != "-" &&
                button7.Text != "-" && button8.Text != "-" && button9.Text != "-")
            {
                MessageBox.Show("Empate!!!");
                empate++;
                label4.Text = "Empate: " + empate;
                reinicio();
            }
            return 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reinicio();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = "Jugador 1(X): ";
            label3.Text = "Jugador 2(O): ";
            label4.Text = "Empate: ";
            j1 = 0;
            j2 = 0;
            empate = 0;
        }

        public void cambio(Button boton)
        {
            if (turno == true)
            {
                boton.Text = "X";
                turno = false;
                boton.FlatAppearance.BorderColor = Color.Blue;
                boton.FlatAppearance.BorderSize = 2;
                boton.ForeColor = Color.Blue;
                boton.Enabled = false;
                
            }
            else
            {
                boton.Text = "O";
                turno = true;
                boton.FlatAppearance.BorderColor = Color.Crimson;
                boton.ForeColor = Color.Crimson;
                boton.FlatAppearance.BorderSize = 2;
                boton.Enabled = false;
            }  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cambio((Button)sender);
            comprobacion();
        }
    }
}
