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
            txtnome = new TextBox();
            repitsenha = new TextBox();
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            SuspendLayout();
            // 
            // cadastrar
            // 
            cadastrar.Enabled = false;
            cadastrar.Location = new Point(32, 483);
            cadastrar.Margin = new Padding(3, 4, 3, 4);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(155, 55);
            cadastrar.TabIndex = 0;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += cadastrar_Click;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(205, 483);
            cancelar.Margin = new Padding(3, 4, 3, 4);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(155, 55);
            cancelar.TabIndex = 1;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 151);
            label2.Name = "label2";
            label2.Size = new Size(108, 37);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 335);
            label3.Name = "label3";
            label3.Size = new Size(189, 37);
            label3.TabIndex = 4;
            label3.Text = "Repita a senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 243);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 62);
            label5.Name = "label5";
            label5.Size = new Size(90, 37);
            label5.TabIndex = 6;
            label5.Text = "Nome";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(32, 103);
            txtnome.Margin = new Padding(3, 4, 3, 4);
            txtnome.Multiline = true;
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(311, 43);
            txtnome.TabIndex = 7;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // repitsenha
            // 
            repitsenha.Location = new Point(32, 379);
            repitsenha.Margin = new Padding(3, 4, 3, 4);
            repitsenha.Multiline = true;
            repitsenha.Name = "repitsenha";
            repitsenha.PasswordChar = '*';
            repitsenha.Size = new Size(220, 43);
            repitsenha.TabIndex = 9;
            repitsenha.TextChanged += repitsenha_TextChanged;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(32, 195);
            txtusuario.Margin = new Padding(3, 4, 3, 4);
            txtusuario.Multiline = true;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(311, 43);
            txtusuario.TabIndex = 10;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(32, 287);
            txtsenha.Margin = new Padding(3, 4, 3, 4);
            txtsenha.Multiline = true;
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(220, 43);
            txtsenha.TabIndex = 11;
            txtsenha.TextChanged += txtsenha_TextChanged;
            // 
            // fmrCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(374, 605);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(repitsenha);
            Controls.Add(txtnome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cancelar);
            Controls.Add(cadastrar);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtnome;
        private TextBox repitsenha;
        private TextBox txtusuario;
        private TextBox txtsenha;
    }
}