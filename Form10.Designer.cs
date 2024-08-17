namespace ProjetoIrmaAdelaide
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.foto07 = new System.Windows.Forms.PictureBox();
            this.voltar07 = new System.Windows.Forms.PictureBox();
            this.anterior07 = new System.Windows.Forms.PictureBox();
            this.proximo07 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_07 = new System.Windows.Forms.PictureBox();
            this.titulo007 = new System.Windows.Forms.Label();
            this.conteudo007 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_07)).BeginInit();
            this.SuspendLayout();
            // 
            // foto07
            // 
            this.foto07.BackColor = System.Drawing.Color.Transparent;
            this.foto07.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto071;
            this.foto07.Location = new System.Drawing.Point(1099, 45);
            this.foto07.Name = "foto07";
            this.foto07.Size = new System.Drawing.Size(216, 502);
            this.foto07.TabIndex = 1;
            this.foto07.TabStop = false;
            // 
            // voltar07
            // 
            this.voltar07.BackColor = System.Drawing.Color.Transparent;
            this.voltar07.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar07.Location = new System.Drawing.Point(48, 584);
            this.voltar07.Name = "voltar07";
            this.voltar07.Size = new System.Drawing.Size(172, 76);
            this.voltar07.TabIndex = 2;
            this.voltar07.TabStop = false;
            this.voltar07.Click += new System.EventHandler(this.voltar07_Click);
            // 
            // anterior07
            // 
            this.anterior07.BackColor = System.Drawing.Color.Transparent;
            this.anterior07.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior07.Location = new System.Drawing.Point(270, 584);
            this.anterior07.Name = "anterior07";
            this.anterior07.Size = new System.Drawing.Size(172, 76);
            this.anterior07.TabIndex = 3;
            this.anterior07.TabStop = false;
            this.anterior07.Click += new System.EventHandler(this.anterior07_Click);
            // 
            // proximo07
            // 
            this.proximo07.BackColor = System.Drawing.Color.Transparent;
            this.proximo07.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo07.Location = new System.Drawing.Point(450, 584);
            this.proximo07.Name = "proximo07";
            this.proximo07.Size = new System.Drawing.Size(172, 76);
            this.proximo07.TabIndex = 4;
            this.proximo07.TabStop = false;
            this.proximo07.Click += new System.EventHandler(this.proximo07_Click);
            // 
            // titulo_pequeno_07
            // 
            this.titulo_pequeno_07.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_07.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_07.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_07.Name = "titulo_pequeno_07";
            this.titulo_pequeno_07.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_07.TabIndex = 5;
            this.titulo_pequeno_07.TabStop = false;
            // 
            // titulo007
            // 
            this.titulo007.AutoSize = true;
            this.titulo007.BackColor = System.Drawing.Color.Transparent;
            this.titulo007.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo007.Location = new System.Drawing.Point(75, 72);
            this.titulo007.Name = "titulo007";
            this.titulo007.Size = new System.Drawing.Size(793, 37);
            this.titulo007.TabIndex = 6;
            this.titulo007.Text = "7. INTERAÇÕES MEDICAMENTOSAS E ALIMENTOS";
            // 
            // conteudo007
            // 
            this.conteudo007.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo007.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo007.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo007.Location = new System.Drawing.Point(75, 132);
            this.conteudo007.Name = "conteudo007";
            this.conteudo007.ReadOnly = true;
            this.conteudo007.Size = new System.Drawing.Size(976, 393);
            this.conteudo007.TabIndex = 7;
            this.conteudo007.Text = resources.GetString("conteudo007.Text");
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo007);
            this.Controls.Add(this.titulo007);
            this.Controls.Add(this.titulo_pequeno_07);
            this.Controls.Add(this.proximo07);
            this.Controls.Add(this.anterior07);
            this.Controls.Add(this.voltar07);
            this.Controls.Add(this.foto07);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "PROJETO IRMÃ ADELAIDE | 7. Interações medicamentosas e alimentos";
            ((System.ComponentModel.ISupportInitialize)(this.foto07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_07)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto07;
        private PictureBox voltar07;
        private PictureBox anterior07;
        private PictureBox proximo07;
        private PictureBox titulo_pequeno_07;
        private Label titulo007;
        private RichTextBox conteudo007;
    }
}