namespace ProjetoAgenda
{
    partial class fmrCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCadastro));
            cadastrar = new Button();
            cancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nome = new TextBox();
            repitsenha = new TextBox();
            usuario = new TextBox();
            senha = new TextBox();
            SuspendLayout();
            // 
            // cadastrar
            // 
            cadastrar.Enabled = false;
            cadastrar.Location = new Point(28, 362);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(136, 41);
            cadastrar.TabIndex = 0;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += cadastrar_Click;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(179, 362);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(136, 41);
            cancelar.TabIndex = 1;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 113);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 251);
            label3.Name = "label3";
            label3.Size = new Size(149, 30);
            label3.TabIndex = 4;
            label3.Text = "Repita a senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 182);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 44);
            label5.Name = "label5";
            label5.Size = new Size(70, 30);
            label5.TabIndex = 6;
            label5.Text = "Nome";
            // 
            // nome
            // 
            nome.Location = new Point(28, 77);
            nome.Multiline = true;
            nome.Name = "nome";
            nome.Size = new Size(273, 33);
            nome.TabIndex = 7;
            nome.TextChanged += nome_TextChanged;
            // 
            // repitsenha
            // 
            repitsenha.Location = new Point(28, 284);
            repitsenha.Multiline = true;
            repitsenha.Name = "repitsenha";
            repitsenha.PasswordChar = '*';
            repitsenha.Size = new Size(193, 33);
            repitsenha.TabIndex = 9;
            repitsenha.TextChanged += repitsenha_TextChanged;
            // 
            // usuario
            // 
            usuario.Location = new Point(28, 146);
            usuario.Multiline = true;
            usuario.Name = "usuario";
            usuario.Size = new Size(273, 33);
            usuario.TabIndex = 10;
            usuario.TextChanged += usuario_TextChanged;
            // 
            // senha
            // 
            senha.Location = new Point(28, 215);
            senha.Multiline = true;
            senha.Name = "senha";
            senha.PasswordChar = '*';
            senha.Size = new Size(193, 33);
            senha.TabIndex = 11;
            senha.TextChanged += senha_TextChanged;
            // 
            // fmrCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(327, 454);
            Controls.Add(senha);
            Controls.Add(usuario);
            Controls.Add(repitsenha);
            Controls.Add(nome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cancelar);
            Controls.Add(cadastrar);
            Name = "fmrCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += fmrCadastro_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastrar;
        private Button cancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nome;
        private TextBox repitsenha;
        private TextBox usuario;
        private TextBox senha;
    }
}