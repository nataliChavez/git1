using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        double numero1;
        double numero2;
        double resultado;
        String mostrar;


        public Form1()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox2.Text.Length > 0)
            {

                numero1 = int.Parse(textBox1.Text);
                numero2 = int.Parse(textBox2.Text);
                resultado = numero1 + numero2;

                mostrar = Convert.ToString(resultado);

                MessageBox.Show(mostrar, "El resultado es:");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox2.Text.Length > 0)
            {

                numero1 = int.Parse(textBox1.Text);
                numero2 = int.Parse(textBox2.Text);
                resultado = numero1 - numero2;

                mostrar = Convert.ToString(resultado);

                MessageBox.Show(mostrar, "El resultado es:");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox2.Text.Length > 0)
            {

                numero1 = int.Parse(textBox1.Text);
                numero2 = int.Parse(textBox2.Text);
                resultado = numero1 / numero2;

                mostrar = Convert.ToString(resultado);

                MessageBox.Show(mostrar, "El resultado es:");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox2.Text.Length > 0)
            {

                numero1 = int.Parse(textBox1.Text);
                numero2 = int.Parse(textBox2.Text);
                resultado = numero1 * numero2;

                mostrar = Convert.ToString(resultado);

                MessageBox.Show(mostrar, "El resultado es:");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox2.Text.Length > 0)
            {

                numero1 = int.Parse(textBox1.Text);
                numero2 = int.Parse(textBox2.Text);
                resultado = Math.Pow(numero1, numero2);

                mostrar = Convert.ToString(resultado);

                MessageBox.Show(mostrar, "El resultado es:");
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
