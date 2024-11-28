using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class fmrCadastro : Form
    {
        public fmrCadastro()
        {
            InitializeComponent();
        }
        private void habilitarCadastro()
        {
            if (txtnome.Text.Length > 0 && txtusuario.Text.Length > 0 && txtsenha.Text.Length >= 4 && repitsenha.Text.Length >= 4 && txtsenha.Text == repitsenha.Text)
            {
                cadastrar.Enabled = true;
            }
            else
            {
                cadastrar.Enabled = false;
            }
        }

        private void fmrCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void repitsenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = conexaoDB.CriarConexao();


            conexao.Open();

            string sql = $"INSERT INTO tbusuarios (nome, usuario, senha) VALUES (@nome, @usuario, @senha)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txtnome.Text);
            comando.Parameters.AddWithValue("@usuario", txtusuario.Text);
            comando.Parameters.AddWithValue("@senha", txtsenha.Text);

            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Cadastro feito");

            this.Hide();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

       
    }
}
