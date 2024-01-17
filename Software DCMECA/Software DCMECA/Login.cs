using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Software_DCMECA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Login";
            label1.Text = "User";
            label2.Text = "Pass";
            button1.Text = "Entrar";
            textBox2.PasswordChar = '*';
            Color corRGB = Color.FromArgb(217, 217, 217);

        }




        private void button1_Click(object sender, EventArgs e)
        {
            
                var ligacaobd = "server=localhost;uid=root;database=dcmeca";
                var ligacao = new MySqlConnection(ligacaobd);
                ligacao.Open();
                var login = new MySqlCommand("Select * From funcionario", ligacao);
                var lerdados = login.ExecuteReader();

                bool logincerto = false;

                while (lerdados.Read())
                {
                    var user = $"{lerdados["Nome"]}";
                    var pass = $"{lerdados["Cod_funcionario"]}"; 
                    if (textBox1.Text == user && textBox2.Text == pass)
                    {
                        Form2 Variavel = new Form2();
                        Variavel.Show();
                        this.Hide();
                        logincerto = true;
                        break; 
                    }
                }

                if (!logincerto)
                {
                    MessageBox.Show("User ou Pass incorreta \nPor favor Insira os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                }

                lerdados.Close();
                ligacao.Close();
        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
