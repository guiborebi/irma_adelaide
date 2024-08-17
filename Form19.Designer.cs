namespace ProjetoIrmaAdelaide
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.foto16 = new System.Windows.Forms.PictureBox();
            this.voltar16 = new System.Windows.Forms.PictureBox();
            this.anterior16 = new System.Windows.Forms.PictureBox();
            this.proximo16 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_16 = new System.Windows.Forms.PictureBox();
            this.titulo016 = new System.Windows.Forms.Label();
            this.conteudo016 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_16)).BeginInit();
            this.SuspendLayout();
            // 
            // foto16
            // 
            this.foto16.BackColor = System.Drawing.Color.Transparent;
            this.foto16.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto161;
            this.foto16.Location = new System.Drawing.Point(1099, 45);
            this.foto16.Name = "foto16";
            this.foto16.Size = new System.Drawing.Size(216, 502);
            this.foto16.TabIndex = 1;
            this.foto16.TabStop = false;
            // 
            // voltar16
            // 
            this.voltar16.BackColor = System.Drawing.Color.Transparent;
            this.voltar16.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar16.Location = new System.Drawing.Point(48, 584);
            this.voltar16.Name = "voltar16";
            this.voltar16.Size = new System.Drawing.Size(172, 76);
            this.voltar16.TabIndex = 2;
            this.voltar16.TabStop = false;
            this.voltar16.Click += new System.EventHandler(this.voltar16_Click);
            // 
            // anterior16
            // 
            this.anterior16.BackColor = System.Drawing.Color.Transparent;
            this.anterior16.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior16.Location = new System.Drawing.Point(270, 584);
            this.anterior16.Name = "anterior16";
            this.anterior16.Size = new System.Drawing.Size(172, 76);
            this.anterior16.TabIndex = 3;
            this.anterior16.TabStop = false;
            this.anterior16.Click += new System.EventHandler(this.anterior16_Click);
            // 
            // proximo16
            // 
            this.proximo16.BackColor = System.Drawing.Color.Transparent;
            this.proximo16.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo16.Location = new System.Drawing.Point(450, 584);
            this.proximo16.Name = "proximo16";
            this.proximo16.Size = new System.Drawing.Size(172, 76);
            this.proximo16.TabIndex = 4;
            this.proximo16.TabStop = false;
            this.proximo16.Click += new System.EventHandler(this.proximo16_Click);
            // 
            // titulo_pequeno_16
            // 
            this.titulo_pequeno_16.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_16.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_16.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_16.Name = "titulo_pequeno_16";
            this.titulo_pequeno_16.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_16.TabIndex = 5;
            this.titulo_pequeno_16.TabStop = false;
            // 
            // titulo016
            // 
            this.titulo016.AutoSize = true;
            this.titulo016.BackColor = System.Drawing.Color.Transparent;
            this.titulo016.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo016.Location = new System.Drawing.Point(75, 72);
            this.titulo016.Name = "titulo016";
            this.titulo016.Size = new System.Drawing.Size(773, 37);
            this.titulo016.TabIndex = 6;
            this.titulo016.Text = "16. ANTICOLINÉRGICOS: O QUE ISSO SIGNIFICA?";
            // 
            // conteudo016
            // 
            this.conteudo016.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo016.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo016.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo016.Location = new System.Drawing.Point(75, 132);
            this.conteudo016.Name = "conteudo016";
            this.conteudo016.ReadOnly = true;
            this.conteudo016.Size = new System.Drawing.Size(976, 393);
            this.conteudo016.TabIndex = 7;
            this.conteudo016.Text = resources.GetString("conteudo016.Text");
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo016);
            this.Controls.Add(this.titulo016);
            this.Controls.Add(this.titulo_pequeno_16);
            this.Controls.Add(this.proximo16);
            this.Controls.Add(this.anterior16);
            this.Controls.Add(this.voltar16);
            this.Controls.Add(this.foto16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form19";
            this.Text = "PROJETO IRMÃ ADELAIDE | 16. Anticolinérgicos: o que isso significa?";
            ((System.ComponentModel.ISupportInitialize)(this.foto16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto16;
        private PictureBox voltar16;
        private PictureBox anterior16;
        private PictureBox proximo16;
        private PictureBox titulo_pequeno_16;
        private Label titulo016;
        private RichTextBox conteudo016;
    }
}