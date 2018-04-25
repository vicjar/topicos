using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix;
namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int filas, columnas;
            if(textBox1.Text != null && textBox2.Text != null)
            {
                filas = Int32.Parse(textBox1.Text);
                columnas = Int32.Parse(textBox2.Text);
                int[,] matriz = new int[filas, columnas];
                generaMatriz(dataGridView1, filas, columnas, matriz);
                generaMatriz(dataGridView2, filas, columnas, matriz);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int filas, columnas;
         
            filas = Int32.Parse(textBox1.Text);
            columnas = Int32.Parse(textBox2.Text);
            Operaciones operacion = new Operaciones(filas, columnas);
            int[,] a = new int[filas, columnas];
            int[,] b = new int[filas, columnas];
            /*
            Suma 2 Matrices
            Resta 2 Matrices
            Multiplicacion
            Suma Diagonal Matriz A
            Suma contra diagobal Matriaz A
            Suma columnas Matriz A
            Suma filas Matriz A
            */
            if (comboBox1.SelectedItem == "Suma 2 Matrices" || comboBox1.SelectedItem == "Resta 2 Matrices" || comboBox1.SelectedItem == "Multiplicacion")
            {
                for (int i=0; i<filas; i++)
                {
                    for (int j = 0; j < filas; j++)
                    {
                        a[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        b[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value.ToString());
                        //dataGridView3.Rows[i].Cells[j].Value = float.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                    }
                }

                if(comboBox1.SelectedItem == "Suma 2 Matrices")
                {
                    generaMatriz(dataGridView3, filas, columnas, operacion.suma(a, b));
                }
                if (comboBox1.SelectedItem == "Resta 2 Matrices")
                {
                    generaMatriz(dataGridView3, filas, columnas, operacion.resta(a, b));
                }
                if (comboBox1.SelectedItem == "Multiplicacion")
                {
                    generaMatriz(dataGridView3, filas, columnas, operacion.multiplicacion(a, b));
                }
                
            }
            else
            {
            
            
                if (comboBox1.SelectedItem == "Suma Diagonal Matriz A")
                {
                    MessageBox.Show(operacion.sumaDiagonal(a, b).ToString());
                }
                if (comboBox1.SelectedItem == "Suma contra diagobal Matriaz A")
                {
                    MessageBox.Show(operacion.sumaDiagonalI(a, b).ToString());
                }
                if (comboBox1.SelectedItem == "Suma columnas Matriz A")
                {
                    
                }
                if (comboBox1.SelectedItem == "Suma filas Matriz A")
                {

                }
            }

        }
        public void generaMatriz(DataGridView matriz,int filas,int columnas, int[,] aux)
        {
            matriz.RowCount = filas;
            matriz.ColumnCount = columnas;

            for (int i=0; i<filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz.Rows[i].Cells[j].Value = aux[i,j].ToString();
                    
                }
            }
        }

    }
}
