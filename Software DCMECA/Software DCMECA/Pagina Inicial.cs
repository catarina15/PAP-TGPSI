using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_DCMECA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Página Inicial";
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Variavel = new Login();
            Variavel.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock variavel = new stock();
            variavel.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes Variavel = new clientes();
            Variavel.Show();
            this.Hide();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            veiculos Variavel = new veiculos();
            Variavel.Show();
            this.Hide();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviço Variavel = new serviço();
            Variavel.Show();
            this.Hide();
        }
    }
}
