namespace ProjetoAgenda
{
    public partial class fmrEntrar : Form
    {
        public fmrEntrar()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            if (usuario.Text.Length > 0 && senha.Text.Length >= 4)
            {
                entrar.Enabled = true;
            }
            else
            {
                entrar.Enabled = false;
            }
        }



        private void cadastrar_Click(object sender, EventArgs e)
        {
            fmrCadastro fmrCadastro = new fmrCadastro();

            fmrCadastro.ShowDialog();

        }

        private void fmrEntrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entrar_EnabledChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
            if (usuario.Text.Length > 0 && senha.Text.Length >= 4)
            {
                entrar.Enabled = true;
            }
            else
            {
                entrar.Enabled = false;
            }
        }
    }
}

