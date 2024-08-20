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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void númeroMaiorEMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade01().Show();
            this.Hide();
        }

        private void comoSeráOSeuPesoNestePlanetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade02().Show();
            this.Hide();
        }

        private void placarDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Atividade03().Show();
            this.Hide();
        }
    }
}
