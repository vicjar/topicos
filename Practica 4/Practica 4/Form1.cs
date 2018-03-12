using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        cSerpiente cabeza;
        cComida comida;
        Graphics g;
        int xDir=0, yDir=0;
        int puntos, velocidad = 100;
        Boolean ejeX = true, ejeY = true;

        public void movimiento()
        {
            cabeza.setxy(cabeza.getX() + xDir, cabeza.getY() + yDir);
        }
        public Form1()
        {

            cabeza = new cSerpiente(10, 10);
            comida = new cComida();
            InitializeComponent();
            g = pictureBox1.CreateGraphics();   
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(ejeX)
            {
                if(e.KeyCode == Keys.Up)
                {
                    yDir = -10;
                    xDir = 0;
                    ejeX = false;
                    ejeY = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    yDir = 10;
                    xDir = 0;
                    ejeX = false;
                    ejeY = true;
                }
            }
            if(ejeY)
            {
                if(e.KeyCode == Keys.Right)
                {
                    yDir = 0;
                    xDir = 10;
                    ejeX = true;
                    ejeY = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    yDir = 0;
                    xDir = -10;
                    ejeX = true;
                    ejeY = false;
                }
            }
        }
        public void choqueCuerpo()
        {
            cSerpiente aux;
            try
            {
                aux = cabeza.getCola().getCola();
            }
            catch (Exception e)
            {
                aux = null;
            }
            while (aux != null)
            {
                if (cabeza.colicion(aux))
                {
                    fin();
                }
                else
                {
                    aux = aux.getCola();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void fin()
        {
            velocidad = 100;
            timer1.Interval = velocidad;
            label1.Text = "Puntaje:";
            ejeX = true;
            ejeY = true;
            xDir = 0;
            yDir = 0;
            cabeza = new cSerpiente(10, 10);
            comida = new cComida();
            MessageBox.Show("Perdiste ");
            puntos = 0;
        }
        public void choquePared()
        {
            if(cabeza.getX() < 0 || cabeza.getX() > 660 || cabeza.getY() < 0 || cabeza.getY() > 460)
            {
                fin();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            cabeza.dibujar(g);
            movimiento();
            comida.dibujar(g);
            choqueCuerpo();
            choquePared();
            if(cabeza.colicion(comida))
            {
                comida.reGen();
                velocidad -= 5;
                timer1.Interval = velocidad;
                cabeza.insertar();
                puntos += 10;
                label1.Text = "Puntaje:" + puntos.ToString();
            }
        }
    }
}
