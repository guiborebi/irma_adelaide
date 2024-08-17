namespace ProjetoIrmaAdelaide
{
    partial class Form22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            this.foto19 = new System.Windows.Forms.PictureBox();
            this.voltar19 = new System.Windows.Forms.PictureBox();
            this.anterior19 = new System.Windows.Forms.PictureBox();
            this.proximo19 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_19 = new System.Windows.Forms.PictureBox();
            this.titulo019 = new System.Windows.Forms.Label();
            this.conteudo19 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_19)).BeginInit();
            this.SuspendLayout();
            // 
            // foto19
            // 
            this.foto19.BackColor = System.Drawing.Color.Transparent;
            this.foto19.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto191;
            this.foto19.Location = new System.Drawing.Point(1099, 45);
            this.foto19.Name = "foto19";
            this.foto19.Size = new System.Drawing.Size(216, 502);
            this.foto19.TabIndex = 1;
            this.foto19.TabStop = false;
            // 
            // voltar19
            // 
            this.voltar19.BackColor = System.Drawing.Color.Transparent;
            this.voltar19.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar19.Location = new System.Drawing.Point(48, 584);
            this.voltar19.Name = "voltar19";
            this.voltar19.Size = new System.Drawing.Size(172, 76);
            this.voltar19.TabIndex = 2;
            this.voltar19.TabStop = false;
            this.voltar19.Click += new System.EventHandler(this.voltar19_Click);
            // 
            // anterior19
            // 
            this.anterior19.BackColor = System.Drawing.Color.Transparent;
            this.anterior19.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior19.Location = new System.Drawing.Point(270, 584);
            this.anterior19.Name = "anterior19";
            this.anterior19.Size = new System.Drawing.Size(172, 76);
            this.anterior19.TabIndex = 3;
            this.anterior19.TabStop = false;
            this.anterior19.Click += new System.EventHandler(this.anterior19_Click);
            // 
            // proximo19
            // 
            this.proximo19.BackColor = System.Drawing.Color.Transparent;
            this.proximo19.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo19.Location = new System.Drawing.Point(450, 584);
            this.proximo19.Name = "proximo19";
            this.proximo19.Size = new System.Drawing.Size(172, 76);
            this.proximo19.TabIndex = 4;
            this.proximo19.TabStop = false;
            this.proximo19.Click += new System.EventHandler(this.proximo19_Click);
            // 
            // titulo_pequeno_19
            // 
            this.titulo_pequeno_19.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_19.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_19.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_19.Name = "titulo_pequeno_19";
            this.titulo_pequeno_19.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_19.TabIndex = 5;
            this.titulo_pequeno_19.TabStop = false;
            // 
            // titulo019
            // 
            this.titulo019.AutoSize = true;
            this.titulo019.BackColor = System.Drawing.Color.Transparent;
            this.titulo019.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo019.Location = new System.Drawing.Point(75, 72);
            this.titulo019.Name = "titulo019";
            this.titulo019.Size = new System.Drawing.Size(612, 37);
            this.titulo019.TabIndex = 6;
            this.titulo019.Text = "19. ALCOOLISMO NA TERCEIRA IDADE";
            // 
            // conteudo19
            // 
            this.conteudo19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo19.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo19.Location = new System.Drawing.Point(72, 132);
            this.conteudo19.Name = "conteudo19";
            this.conteudo19.ReadOnly = true;
            this.conteudo19.Size = new System.Drawing.Size(976, 393);
            this.conteudo19.TabIndex = 7;
            this.conteudo19.Text = resources.GetString("conteudo19.Text");
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo19);
            this.Controls.Add(this.titulo019);
            this.Controls.Add(this.titulo_pequeno_19);
            this.Controls.Add(this.proximo19);
            this.Controls.Add(this.anterior19);
            this.Controls.Add(this.voltar19);
            this.Controls.Add(this.foto19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form22";
            this.Text = "PROJETO IRMÃ ADELAIDE | 19. Alcoolismo na terceira idade";
            ((System.ComponentModel.ISupportInitialize)(this.foto19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto19;
        private PictureBox voltar19;
        private PictureBox anterior19;
        private PictureBox proximo19;
        private PictureBox titulo_pequeno_19;
        private Label titulo019;
        private RichTextBox conteudo19;
    }
}