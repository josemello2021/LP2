using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblImc_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtImc.Clear();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc;
            double altura;
            double peso;

            if (double.TryParse(txtAltura.Text, out altura) && double.TryParse(txtPeso.Text, out peso))



            {

                imc = peso / (Math.Pow(altura, 2));
                imc = Math.Round(imc, 1);

                txtImc.Text = imc.ToString("N1");

                if (imc < 18.5)
                    MessageBox.Show("Atenção! Você está abaixo de seu peso.");
                else if (imc <= 24.9)
                    MessageBox.Show("Parabéns!!! Você está com seu peso ideal.");
                else if (imc <= 29.9)
                    MessageBox.Show("Atenção!!! Você está com excesso de peso.");
                else if (imc <= 39.9)
                    MessageBox.Show("Cuidado!!! Você está obeso.");
                else
                    MessageBox.Show("Cuidado!!! Seu grau de obesidade está grave.");
                    }
            else
                MessageBox.Show("Analise esses dados pois os valores estão inválidos!");
        }
    }
}
