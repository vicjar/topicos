using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            string opcion = opc.SelectedItem.ToString();
            
            if (opcion == "Circulo")
            {
                formGraphics.Clear(Color.Teal);
                t1.Text = "Radio";
                t2.Visible = false;
                textBox2.Visible = false;
                t3.Visible = false;
                textBox3.Visible = false;
                formGraphics.FillEllipse(myBrush, new Rectangle(140, 120, 150, 150));
            }
            else if (opcion == "Cuadro")
            {
                formGraphics.Clear(Color.Teal);
                t1.Text = "Lado";
                t2.Visible = false;
                textBox2.Visible = false;
                t3.Visible = false;
                textBox3.Visible = false;
                formGraphics.FillRectangle(myBrush, new Rectangle(140, 120, 150, 150));
            }

            else if (opcion == "Rectangulo")
            {
                formGraphics.Clear(Color.Teal);
                t1.Text = "Base";
                t2.Visible = true;
                t2.Text = "Altura";
                textBox2.Visible = true;
                t3.Visible = false;
                textBox3.Visible = false;
                formGraphics.FillRectangle(myBrush, new Rectangle(140, 120, 160, 125));
            }
            else if (opcion == "Triangulo")
            {
                formGraphics.Clear(Color.Teal);
                t1.Text = "Lado 1 / Base";
                t2.Text = "Lado 2 / Altura";
                t2.Visible = true;
                textBox2.Visible = true;
                t3.Text = "Lado 3";
                t3.Visible = true;
                textBox3.Visible = true;

                PointF point1 = new PointF(220.0F, 125.0F);
                PointF point2 = new PointF(125.0F, 275.0F);
                PointF point3 = new PointF(325.0F, 275.0F);
                PointF[] curvePoints = { point1, point2, point3};

                formGraphics.FillPolygon(myBrush, curvePoints);

            }  
        }
        //Area
        private void button1_Click(object sender, EventArgs e)
        {
            string opcion = opc.SelectedItem.ToString();
            cFiguras figura = new cFiguras();
            if(opcion == "Circulo")
            {
               lResultado.Text = "Resultado: "+figura.areaCirculo(Convert.ToDouble(textBox1.Text)).ToString();
            }

            if (opcion == "Cuadro")
            {
                lResultado.Text = "Resultado: " + figura.areaCuadrado(Convert.ToDouble(textBox1.Text)).ToString();
            }
            if(opcion == "Rectangulo")
            {
                lResultado.Text = "Resultado: " + figura.areaRectangulo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
            if (opcion == "Triangulo")
            {
                lResultado.Text = "Resultado: " + figura.areaTriangulo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
        }
        //perimetros
        private void button2_Click(object sender, EventArgs e)
        {
            string opcion = opc.SelectedItem.ToString();
            cFiguras figura = new cFiguras();
            if (opcion == "Circulo")
            {
                lResultado.Text = "Resultado: " + figura.perimetroCirculo(Convert.ToDouble(textBox1.Text)).ToString();
            }

            if (opcion == "Cuadro")
            {
                lResultado.Text = "Resultado: " + figura.perimetroCuadrado(Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (opcion == "Rectangulo")
            {
                lResultado.Text = "Resultado: " + figura.perimetroRectangulo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
            if (opcion == "Triangulo")
            {
                lResultado.Text = "Resultado: " + figura.perimetroTriangulo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)).ToString();
            }
        }
    }
}
