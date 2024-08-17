namespace ProjetoIrmaAdelaide
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.foto08 = new System.Windows.Forms.PictureBox();
            this.voltar08 = new System.Windows.Forms.PictureBox();
            this.anterior08 = new System.Windows.Forms.PictureBox();
            this.proximo08 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_08 = new System.Windows.Forms.PictureBox();
            this.titulo008 = new System.Windows.Forms.Label();
            this.conteudo008 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_08)).BeginInit();
            this.SuspendLayout();
            // 
            // foto08
            // 
            this.foto08.BackColor = System.Drawing.Color.Transparent;
            this.foto08.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto081;
            this.foto08.Location = new System.Drawing.Point(1099, 45);
            this.foto08.Name = "foto08";
            this.foto08.Size = new System.Drawing.Size(216, 502);
            this.foto08.TabIndex = 1;
            this.foto08.TabStop = false;
            // 
            // voltar08
            // 
            this.voltar08.BackColor = System.Drawing.Color.Transparent;
            this.voltar08.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar08.Location = new System.Drawing.Point(48, 584);
            this.voltar08.Name = "voltar08";
            this.voltar08.Size = new System.Drawing.Size(172, 76);
            this.voltar08.TabIndex = 2;
            this.voltar08.TabStop = false;
            this.voltar08.Click += new System.EventHandler(this.voltar08_Click);
            // 
            // anterior08
            // 
            this.anterior08.BackColor = System.Drawing.Color.Transparent;
            this.anterior08.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior08.Location = new System.Drawing.Point(270, 584);
            this.anterior08.Name = "anterior08";
            this.anterior08.Size = new System.Drawing.Size(172, 76);
            this.anterior08.TabIndex = 3;
            this.anterior08.TabStop = false;
            this.anterior08.Click += new System.EventHandler(this.anterior08_Click);
            // 
            // proximo08
            // 
            this.proximo08.BackColor = System.Drawing.Color.Transparent;
            this.proximo08.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo08.Location = new System.Drawing.Point(450, 584);
            this.proximo08.Name = "proximo08";
            this.proximo08.Size = new System.Drawing.Size(172, 76);
            this.proximo08.TabIndex = 4;
            this.proximo08.TabStop = false;
            this.proximo08.Click += new System.EventHandler(this.proximo08_Click);
            // 
            // titulo_pequeno_08
            // 
            this.titulo_pequeno_08.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_08.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_08.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_08.Name = "titulo_pequeno_08";
            this.titulo_pequeno_08.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_08.TabIndex = 5;
            this.titulo_pequeno_08.TabStop = false;
            // 
            // titulo008
            // 
            this.titulo008.AutoSize = true;
            this.titulo008.BackColor = System.Drawing.Color.Transparent;
            this.titulo008.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo008.Location = new System.Drawing.Point(75, 72);
            this.titulo008.Name = "titulo008";
            this.titulo008.Size = new System.Drawing.Size(658, 37);
            this.titulo008.TabIndex = 6;
            this.titulo008.Text = "8. CUIDADOS COM EFEITOS COLATERAIS";
            // 
            // conteudo008
            // 
            this.conteudo008.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo008.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo008.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo008.Location = new System.Drawing.Point(75, 132);
            this.conteudo008.Name = "conteudo008";
            this.conteudo008.ReadOnly = true;
            this.conteudo008.Size = new System.Drawing.Size(976, 393);
            this.conteudo008.TabIndex = 7;
            this.conteudo008.Text = resources.GetString("conteudo008.Text");
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo008);
            this.Controls.Add(this.titulo008);
            this.Controls.Add(this.titulo_pequeno_08);
            this.Controls.Add(this.proximo08);
            this.Controls.Add(this.anterior08);
            this.Controls.Add(this.voltar08);
            this.Controls.Add(this.foto08);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "PROJETO IRMÃ ADELAIDE | 8. Cuidados com efeitos colaterais";
            ((System.ComponentModel.ISupportInitialize)(this.foto08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_08)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto08;
        private PictureBox voltar08;
        private PictureBox anterior08;
        private PictureBox proximo08;
        private PictureBox titulo_pequeno_08;
        private Label titulo008;
        private RichTextBox conteudo008;
    }
}