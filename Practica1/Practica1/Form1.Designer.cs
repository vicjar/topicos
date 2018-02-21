namespace Practica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.opc = new System.Windows.Forms.ComboBox();
            this.t1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opc
            // 
            this.opc.FormattingEnabled = true;
            this.opc.Items.AddRange(new object[] {
            "Cuadro",
            "Rectangulo",
            "Triangulo",
            "Circulo"});
            this.opc.Location = new System.Drawing.Point(113, 33);
            this.opc.Name = "opc";
            this.opc.Size = new System.Drawing.Size(240, 21);
            this.opc.TabIndex = 0;
            this.opc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.t1.Location = new System.Drawing.Point(166, 74);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(35, 13);
            this.t1.TabIndex = 1;
            this.t1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.t2.Location = new System.Drawing.Point(339, 158);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(35, 13);
            this.t2.TabIndex = 5;
            this.t2.Text = "label1";
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.t3.Location = new System.Drawing.Point(12, 158);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(35, 13);
            this.t3.TabIndex = 6;
            this.t3.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Permetro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lResultado.Location = new System.Drawing.Point(183, 280);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(82, 13);
            this.lResultado.TabIndex = 9;
            this.lResultado.Text = "El resultado es: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(456, 357);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.opc);
            this.Name = "Form1";
            this.Text = "Areas y Perimetros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox opc;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label t3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lResultado;
    }
}

