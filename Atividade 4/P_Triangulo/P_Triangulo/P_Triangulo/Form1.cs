using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            double A, B, C;

            if (!double.TryParse(txtLadoA.Text,out A) || !double.TryParse(txtLadoB.Text,out B) || !double.TryParse(txtLadoC.Text,out C))
            {
                MessageBox.Show("Verificar os valores pois eles devem ser numericos");
            }
            else
            {
                if((A<(B+C) && A>Math.Abs(B-C) && B<(A+C) && 
                   B>Math.Abs(A-C) && C<(A+B) && C>Math.Abs(A-B)))
                {
                    if (A == B && B == C)
                    {
                        MessageBox.Show("SEU TRIÂNGULO É EQUILÁTERO");
                    }
                    else
                    {
                        if (A == B || A == C || C == B)
                        {
                            MessageBox.Show("SEU TRIÂNGULO É  ISÓCELES");
                        }
                        else
                        {
                            MessageBox.Show("SEU TRIÂNGULO É ESCALENO");
                        }
                        
                    }

                }
            }
        }

        private void BTNlIMPAR_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
