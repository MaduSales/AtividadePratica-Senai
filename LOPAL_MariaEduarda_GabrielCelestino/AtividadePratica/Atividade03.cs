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
    public partial class Atividade03 : Form
    {
        public Atividade03()
        {
            InitializeComponent();
        }

        //DECLARAÇÃO DE VARIÁVEIS
        int SaoPaulo, Gremio, Vasco, Flamengo, Palmeiras, Santos, Juventude, Botafogo, Cruzeiro, Fluminense, Internacional, Corinthians;

        private void comoSeráOSeuPesoNestePlanetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade02().Show();
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

        string vencedor1, vencedor2, vencedor3, vencedor4, vencedor5, vencedor6;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // ENTRADA E ATRIBUIÇÃO DE VALORES

            // Nome dos times do lado 1
            SaoPaulo = Convert.ToInt32(txtPlacarSaoPaulo.Text);
            Gremio = Convert.ToInt32(txtPlacarGremio.Text);
            Vasco = Convert.ToInt32(txtPlacarVasco.Text);
            Flamengo = Convert.ToInt32(txtPlacarFlamengo.Text);
            Palmeiras = Convert.ToInt32(txtPlacarPalmeiras.Text);
            Santos = Convert.ToInt32(txtPlacarSantos.Text);


            //Nomes dos times do lado 2
            Juventude = Convert.ToInt32(txtPlacarJuventude.Text);
            Botafogo = Convert.ToInt32(txtPlacarBotafogo.Text);
            Cruzeiro = Convert.ToInt32(txtPlacarCruzeiro.Text); 
            Fluminense = Convert.ToInt32(txtPlacarFluminense.Text); 
            Internacional = Convert.ToInt32(txtPlacarInternacional.Text);
            Corinthians = Convert.ToInt32(txtPlacarCorinthians.Text);



            //Descobrindo o resultado do placar dos times 1 e 2
            if (SaoPaulo > Juventude)
            {
                vencedor1 = "São Paulo";
            }
            else if (Juventude > SaoPaulo)
            {
                vencedor1 = "Juventude";
            }
            else
            {
                vencedor1 = "Empate";
            }



            //Descobrindo o resultado do placar dos times 3 e 4
            if (Gremio > Botafogo)
            {
                vencedor2 = "Grêmio";
            }
            else if (Botafogo > Gremio)
            {
                vencedor2 = "Botafogo";
            }
            else
            {
                vencedor2 = "Empate";
            }



            //Descobrindo o resultado do placar dos times 5 e 6
            if (Vasco > Cruzeiro)
            {
                vencedor3 = "Vasco";
            }
            else if (Cruzeiro > Vasco)
            {
                vencedor3 = "Cruzeiro";
            }
            else
            {
                vencedor3 = "Empate";
            }



            //Descobrindo o resultado do placar dos times 7 e 8
            if (Flamengo > Fluminense)
            {
                vencedor4 = "Flamengo";
            }
            else if (Fluminense > Flamengo)
            {
                vencedor4 = "Fluminense";
            }
            else
            {
                vencedor4 = "Empate";
            }



            //Descobrindo o resultado do placar dos times 9 e 10
            if (Palmeiras > Internacional)
            {
                vencedor5 = "Palmeiras";
            }
            else if (Internacional > Palmeiras)
            {
                vencedor5 = "Internacional";
            }
            else
            {
                vencedor5 = "Empate";
            }




            //Descobrindo o resultado do placar dos times 11 e 12
            if (Santos > Corinthians)
            {
                vencedor6 = "Santos";
            }
            else if (Corinthians > Santos)
            {
                vencedor6 = "Corinthians";
            }
            else
            {
                vencedor6 = "Empate";
            }



            //Saída
            lblResultado1.Text = vencedor1.ToString();
            lblResultado2.Text = vencedor2.ToString();
            lblResultado3.Text = vencedor3.ToString();
            lblResultado4.Text = vencedor4.ToString();
            lblResultado5.Text = vencedor5.ToString();
            lblResultado6.Text = vencedor6.ToString();


        }
    }
}
