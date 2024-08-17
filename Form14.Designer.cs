namespace ProjetoIrmaAdelaide
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.foto11 = new System.Windows.Forms.PictureBox();
            this.voltar11 = new System.Windows.Forms.PictureBox();
            this.anterior11 = new System.Windows.Forms.PictureBox();
            this.proximo11 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_11 = new System.Windows.Forms.PictureBox();
            this.titulo011 = new System.Windows.Forms.Label();
            this.conteudo011 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_11)).BeginInit();
            this.SuspendLayout();
            // 
            // foto11
            // 
            this.foto11.BackColor = System.Drawing.Color.Transparent;
            this.foto11.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto111;
            this.foto11.Location = new System.Drawing.Point(1099, 45);
            this.foto11.Name = "foto11";
            this.foto11.Size = new System.Drawing.Size(216, 502);
            this.foto11.TabIndex = 1;
            this.foto11.TabStop = false;
            // 
            // voltar11
            // 
            this.voltar11.BackColor = System.Drawing.Color.Transparent;
            this.voltar11.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar11.Location = new System.Drawing.Point(48, 584);
            this.voltar11.Name = "voltar11";
            this.voltar11.Size = new System.Drawing.Size(172, 76);
            this.voltar11.TabIndex = 2;
            this.voltar11.TabStop = false;
            this.voltar11.Click += new System.EventHandler(this.voltar11_Click);
            // 
            // anterior11
            // 
            this.anterior11.BackColor = System.Drawing.Color.Transparent;
            this.anterior11.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior11.Location = new System.Drawing.Point(270, 584);
            this.anterior11.Name = "anterior11";
            this.anterior11.Size = new System.Drawing.Size(172, 76);
            this.anterior11.TabIndex = 3;
            this.anterior11.TabStop = false;
            this.anterior11.Click += new System.EventHandler(this.anterior11_Click);
            // 
            // proximo11
            // 
            this.proximo11.BackColor = System.Drawing.Color.Transparent;
            this.proximo11.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo11.Location = new System.Drawing.Point(450, 584);
            this.proximo11.Name = "proximo11";
            this.proximo11.Size = new System.Drawing.Size(172, 76);
            this.proximo11.TabIndex = 4;
            this.proximo11.TabStop = false;
            this.proximo11.Click += new System.EventHandler(this.proximo11_Click);
            // 
            // titulo_pequeno_11
            // 
            this.titulo_pequeno_11.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_11.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_11.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_11.Name = "titulo_pequeno_11";
            this.titulo_pequeno_11.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_11.TabIndex = 5;
            this.titulo_pequeno_11.TabStop = false;
            // 
            // titulo011
            // 
            this.titulo011.AutoSize = true;
            this.titulo011.BackColor = System.Drawing.Color.Transparent;
            this.titulo011.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo011.Location = new System.Drawing.Point(75, 72);
            this.titulo011.Name = "titulo011";
            this.titulo011.Size = new System.Drawing.Size(849, 37);
            this.titulo011.TabIndex = 6;
            this.titulo011.Text = "11. IMPORTANCIA DAS TARJAS  DOS MEDICAMENTOS";
            // 
            // conteudo011
            // 
            this.conteudo011.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo011.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo011.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo011.Location = new System.Drawing.Point(75, 132);
            this.conteudo011.Name = "conteudo011";
            this.conteudo011.ReadOnly = true;
            this.conteudo011.Size = new System.Drawing.Size(976, 393);
            this.conteudo011.TabIndex = 7;
            this.conteudo011.Text = resources.GetString("conteudo011.Text");
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo011);
            this.Controls.Add(this.titulo011);
            this.Controls.Add(this.titulo_pequeno_11);
            this.Controls.Add(this.proximo11);
            this.Controls.Add(this.anterior11);
            this.Controls.Add(this.voltar11);
            this.Controls.Add(this.foto11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form14";
            this.Text = "PROJETO IRMÃ ADELAIDE | 11. Importância das tarjas  dos medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.foto11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto11;
        private PictureBox voltar11;
        private PictureBox anterior11;
        private PictureBox proximo11;
        private PictureBox titulo_pequeno_11;
        private Label titulo011;
        private RichTextBox conteudo011;
    }
}