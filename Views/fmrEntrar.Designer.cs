namespace ProjetoAgenda
{
    partial class fmrEntrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrEntrar));
            label1 = new Label();
            label2 = new Label();
            usuario = new TextBox();
            senha = new TextBox();
            entrar = new Button();
            cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 34);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(146, 134);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // usuario
            // 
            usuario.Location = new Point(75, 68);
            usuario.Multiline = true;
            usuario.Name = "usuario";
            usuario.Size = new Size(247, 35);
            usuario.TabIndex = 2;
            usuario.TextChanged += usuario_TextChanged;
            // 
            // senha
            // 
            senha.Location = new Point(75, 167);
            senha.Multiline = true;
            senha.Name = "senha";
            senha.PasswordChar = '*';
            senha.Size = new Size(247, 35);
            senha.TabIndex = 3;
            senha.TextChanged += senha_TextChanged;
            // 
            // entrar
            // 
            entrar.Enabled = false;
            entrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entrar.Location = new Point(58, 247);
            entrar.Name = "entrar";
            entrar.Size = new Size(120, 38);
            entrar.TabIndex = 4;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = true;
            entrar.EnabledChanged += entrar_EnabledChanged;
            entrar.Click += entrar_Click;
            // 
            // cadastrar
            // 
            cadastrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastrar.Location = new Point(210, 247);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(133, 38);
            cadastrar.TabIndex = 5;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += cadastrar_Click;
            // 
            // fmrEntrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(414, 297);
            Controls.Add(cadastrar);
            Controls.Add(entrar);
            Controls.Add(senha);
            Controls.Add(usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmrEntrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += fmrEntrar_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usuario;
        private TextBox senha;
        private Button entrar;
        private Button cadastrar;
    }
}
