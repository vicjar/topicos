using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        bool presionado = false;
        int tam = 0;
        Point punto1, punto2;
        Graphics g;
        Pen pen;
        Color color = Color.Black;
        string opcion = "linea";
        cFiguras figura = new cFiguras();

        public Form1()
        {
            InitializeComponent();
            g = lienzo.CreateGraphics();
            pen = new Pen (color);
        }

        private void lienzo_MouseDown(object sender, MouseEventArgs e)
        {
            presionado = true;
            punto1 = e.Location;
            if (opcion == "imagen")
                figura.imagen(g, e.Location);

        }
        private void lienzo_MouseUp(object sender, MouseEventArgs e)
        {
            presionado = false;
            punto2 = e.Location;
            if (opcion == "linea")
                figura.linea(g, punto1, punto2, pen);
            else if (opcion == "circulo")
                figura.circulo(g, punto1, punto2, pen);
            else if (opcion == "cuadro")
                figura.cuadro(g, punto1, punto2, pen);
        }
        private void lienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (opcion == "libre" && presionado)
            {
                figura.libre(g, punto1, e.Location, 1, pen);
                punto1 = e.Location;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string nombreB = b.Name;
            if (nombreB == "button1")
                opcion = "circulo";
            else if (nombreB == "button2")
                opcion = "cuadro";
            else if (nombreB == "button3")
                opcion = "linea";
            else if (nombreB == "button4")
                opcion = "libre";
            else if (nombreB == "button5")
                opcion = "imagen";
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
           label1.Text = hScrollBar1.Value.ToString();
           pen.Width = hScrollBar1.Value;
           tam = hScrollBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            color = p.BackColor;
            pen.Color = color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
            color = colorDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lienzo.BackColor = Color.White;
            lienzo.ForeColor = Color.White;
        }

        private void lienzo_MouseLeave(object sender, MouseEventArgs e)
        {
        }
    }
}
