namespace ProjetoIrmaAdelaide
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.foto_02 = new System.Windows.Forms.PictureBox();
            this.anterior02 = new System.Windows.Forms.PictureBox();
            this.botao_proximo_02 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_02 = new System.Windows.Forms.PictureBox();
            this.voltar02 = new System.Windows.Forms.PictureBox();
            this.titulo002 = new System.Windows.Forms.Label();
            this.conteudo002 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_proximo_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar02)).BeginInit();
            this.SuspendLayout();
            // 
            // foto_02
            // 
            this.foto_02.BackColor = System.Drawing.Color.Transparent;
            this.foto_02.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto021;
            this.foto_02.Location = new System.Drawing.Point(1099, 45);
            this.foto_02.Name = "foto_02";
            this.foto_02.Size = new System.Drawing.Size(216, 502);
            this.foto_02.TabIndex = 1;
            this.foto_02.TabStop = false;
            // 
            // anterior02
            // 
            this.anterior02.BackColor = System.Drawing.Color.Transparent;
            this.anterior02.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior02.Location = new System.Drawing.Point(270, 584);
            this.anterior02.Name = "anterior02";
            this.anterior02.Size = new System.Drawing.Size(172, 76);
            this.anterior02.TabIndex = 3;
            this.anterior02.TabStop = false;
            this.anterior02.Click += new System.EventHandler(this.anterior02_Click);
            // 
            // botao_proximo_02
            // 
            this.botao_proximo_02.BackColor = System.Drawing.Color.Transparent;
            this.botao_proximo_02.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.botao_proximo_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_proximo_02.Location = new System.Drawing.Point(450, 584);
            this.botao_proximo_02.Name = "botao_proximo_02";
            this.botao_proximo_02.Size = new System.Drawing.Size(172, 76);
            this.botao_proximo_02.TabIndex = 4;
            this.botao_proximo_02.TabStop = false;
            this.botao_proximo_02.Click += new System.EventHandler(this.proximo02_Click);
            // 
            // titulo_pequeno_02
            // 
            this.titulo_pequeno_02.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_02.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_02.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_02.Name = "titulo_pequeno_02";
            this.titulo_pequeno_02.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_02.TabIndex = 5;
            this.titulo_pequeno_02.TabStop = false;
            // 
            // voltar02
            // 
            this.voltar02.BackColor = System.Drawing.Color.Transparent;
            this.voltar02.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar02.Location = new System.Drawing.Point(48, 584);
            this.voltar02.Name = "voltar02";
            this.voltar02.Size = new System.Drawing.Size(172, 76);
            this.voltar02.TabIndex = 6;
            this.voltar02.TabStop = false;
            this.voltar02.Click += new System.EventHandler(this.voltar02_Click);
            // 
            // titulo002
            // 
            this.titulo002.AutoSize = true;
            this.titulo002.BackColor = System.Drawing.Color.Transparent;
            this.titulo002.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo002.Location = new System.Drawing.Point(75, 72);
            this.titulo002.Name = "titulo002";
            this.titulo002.Size = new System.Drawing.Size(639, 37);
            this.titulo002.TabIndex = 7;
            this.titulo002.Text = "2. MANTER UMA ROTINA É IMPORTANTE";
            // 
            // conteudo002
            // 
            this.conteudo002.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo002.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo002.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo002.Location = new System.Drawing.Point(75, 132);
            this.conteudo002.Name = "conteudo002";
            this.conteudo002.ReadOnly = true;
            this.conteudo002.Size = new System.Drawing.Size(976, 393);
            this.conteudo002.TabIndex = 8;
            this.conteudo002.Text = resources.GetString("conteudo002.Text");
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo002);
            this.Controls.Add(this.titulo002);
            this.Controls.Add(this.voltar02);
            this.Controls.Add(this.titulo_pequeno_02);
            this.Controls.Add(this.botao_proximo_02);
            this.Controls.Add(this.anterior02);
            this.Controls.Add(this.foto_02);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "PROJETO IRMÃ ADELAIDE | 2. Manter uma rotina é importante";
            ((System.ComponentModel.ISupportInitialize)(this.foto_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_proximo_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto_02;
        private PictureBox anterior02;
        private PictureBox botao_proximo_02;
        private PictureBox titulo_pequeno_02;
        private PictureBox voltar02;
        private Label titulo002;
        private RichTextBox conteudo002;
    }
}