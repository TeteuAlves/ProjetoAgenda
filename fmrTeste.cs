﻿using ProjetoAgenda.Controller;
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
    public partial class fmrTeste : Form
    {
        public fmrTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado =controleUsuario.LoginUsuario("Godo", "Alexlindao");

            MessageBox.Show(resultado.ToString());

        }
    }
}
