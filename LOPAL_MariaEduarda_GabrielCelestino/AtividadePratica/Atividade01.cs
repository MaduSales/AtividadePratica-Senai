using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePratica
{
    public partial class Atividade01 : Form
    {
        public Atividade01()
        {
            InitializeComponent();
        }

        // Declaração de variáveis
        int valor1, valor2, valor3, maior, menor;

        private void placarDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade03().Show();
            this.Close();
        }

        private void comoSeráOSeuPesoNesseplanetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade02().Show();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Entrada
            // Atribuição dos valores digitados pelo usuário
            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);
            valor3 = int.Parse(txtValor3.Text);


            // Limpa os campos após inserção de dados
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor3.Clear();


            // Descobrindo o maior número
            if (valor1 > valor2 && valor1 > valor3)
            {
                maior = valor1;
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                maior = valor2;
            }
            else
            {
                maior = valor3;
            }

            // Descobrindo o menor número
            if (valor1 < valor2 && valor1 < valor3)
            {
                menor = valor1;
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                menor = valor2;
            }
            else
            {
                menor = valor3;
            }

            //Saída
            txtMaior.Text = maior.ToString();
            txtMenor.Text = menor.ToString();
        }
    }
}
