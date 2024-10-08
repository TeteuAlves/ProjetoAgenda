using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (nome.Text.Length > 0 && usuario.Text.Length > 0 && senha.Text.Length >= 4 && repitsenha.Text.Length >= 4 && senha.Text == repitsenha.Text)
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

        private void nome_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void repitsenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }
    }
}
