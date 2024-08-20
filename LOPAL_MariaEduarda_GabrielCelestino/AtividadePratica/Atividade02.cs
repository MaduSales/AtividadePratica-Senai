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
    public partial class Atividade02 : Form
    {
        public Atividade02()
        {
            InitializeComponent();
        }

        // Declaração de variáveis
        double pesoKg, pesoFinal;
        string planeta;

        private void placarDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade03().Show();
            this.Close();
        }

        private void númeroMaiorEMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade01().Show();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Conversão de peso para um valor Real
            pesoKg = Convert.ToDouble(txtPeso.Text);  


            // Execução das condicionais
            if (btnMercurio.Checked)
            {
                pesoFinal = pesoKg * 0.37; 
                planeta = "Mercurio"; // Variável criada para evitar criar um MessageBox para cada condicional
            }
            else if (btnVenus.Checked)
            {
                pesoFinal = pesoKg * 0.88;
                planeta = "Venus";
            }
            else if (btnMarte.Checked)
            {
                pesoFinal = pesoKg * 0.38;
                planeta = "Marte";
            }
            else if (btnJupiter.Checked)
            {
                pesoFinal = pesoKg * 2.64;
                planeta = "Jupiter";
            }
            else if (btnSaturno.Checked)
            {
                pesoFinal = pesoKg * 1.15;
                planeta = "Saturno";
            }
            else if (btnUrano.Checked)
            {
                pesoFinal = pesoKg * 1.17;
                planeta = "Urano";
            }


            //Saída
            MessageBox.Show( "O seu peso em "+ planeta + " será " + Math.Round(pesoFinal,2) + "kg" , "Message", MessageBoxButtons.OK , MessageBoxIcon.Information);
            
        }
    }
}
