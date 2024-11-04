namespace ProjetoAgenda
{
    partial class fmrTeste
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
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // saveFileDialog1
            // 

            // 
            // button1
            // 
            button1.Location = new Point(301, 161);
            button1.Name = "button1";
            button1.Size = new Size(146, 62);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fmrTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "fmrTeste";
            Text = "fmrTeste";
            ResumeLayout(false);
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button button1;
    }
}