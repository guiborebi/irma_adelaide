namespace ProjetoIrmaAdelaide
{
    partial class Form23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            this.foto20 = new System.Windows.Forms.PictureBox();
            this.voltar20 = new System.Windows.Forms.PictureBox();
            this.anterior20 = new System.Windows.Forms.PictureBox();
            this.proximo20 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_20 = new System.Windows.Forms.PictureBox();
            this.titulo020 = new System.Windows.Forms.Label();
            this.conteudo020 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_20)).BeginInit();
            this.SuspendLayout();
            // 
            // foto20
            // 
            this.foto20.BackColor = System.Drawing.Color.Transparent;
            this.foto20.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto201;
            this.foto20.Location = new System.Drawing.Point(1099, 45);
            this.foto20.Name = "foto20";
            this.foto20.Size = new System.Drawing.Size(216, 502);
            this.foto20.TabIndex = 1;
            this.foto20.TabStop = false;
            // 
            // voltar20
            // 
            this.voltar20.BackColor = System.Drawing.Color.Transparent;
            this.voltar20.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar20.Location = new System.Drawing.Point(48, 584);
            this.voltar20.Name = "voltar20";
            this.voltar20.Size = new System.Drawing.Size(172, 76);
            this.voltar20.TabIndex = 2;
            this.voltar20.TabStop = false;
            this.voltar20.Click += new System.EventHandler(this.voltar20_Click);
            // 
            // anterior20
            // 
            this.anterior20.BackColor = System.Drawing.Color.Transparent;
            this.anterior20.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior20.Location = new System.Drawing.Point(270, 584);
            this.anterior20.Name = "anterior20";
            this.anterior20.Size = new System.Drawing.Size(172, 76);
            this.anterior20.TabIndex = 3;
            this.anterior20.TabStop = false;
            this.anterior20.Click += new System.EventHandler(this.anterior20_Click);
            // 
            // proximo20
            // 
            this.proximo20.BackColor = System.Drawing.Color.Transparent;
            this.proximo20.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo20.Cursor = System.Windows.Forms.Cursors.No;
            this.proximo20.Location = new System.Drawing.Point(450, 584);
            this.proximo20.Name = "proximo20";
            this.proximo20.Size = new System.Drawing.Size(172, 76);
            this.proximo20.TabIndex = 4;
            this.proximo20.TabStop = false;
            this.proximo20.Click += new System.EventHandler(this.proximo20_Click);
            // 
            // titulo_pequeno_20
            // 
            this.titulo_pequeno_20.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_20.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_20.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_20.Name = "titulo_pequeno_20";
            this.titulo_pequeno_20.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_20.TabIndex = 5;
            this.titulo_pequeno_20.TabStop = false;
            // 
            // titulo020
            // 
            this.titulo020.AutoSize = true;
            this.titulo020.BackColor = System.Drawing.Color.Transparent;
            this.titulo020.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo020.Location = new System.Drawing.Point(75, 72);
            this.titulo020.Name = "titulo020";
            this.titulo020.Size = new System.Drawing.Size(821, 37);
            this.titulo020.TabIndex = 6;
            this.titulo020.Text = "20. DOENÇAS CRÔNICAS PODEM SER SILENCIOSAS";
            // 
            // conteudo020
            // 
            this.conteudo020.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo020.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo020.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo020.Location = new System.Drawing.Point(75, 132);
            this.conteudo020.Name = "conteudo020";
            this.conteudo020.ReadOnly = true;
            this.conteudo020.Size = new System.Drawing.Size(976, 393);
            this.conteudo020.TabIndex = 7;
            this.conteudo020.Text = resources.GetString("conteudo020.Text");
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo020);
            this.Controls.Add(this.titulo020);
            this.Controls.Add(this.titulo_pequeno_20);
            this.Controls.Add(this.proximo20);
            this.Controls.Add(this.anterior20);
            this.Controls.Add(this.voltar20);
            this.Controls.Add(this.foto20);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form23";
            this.Text = "PROJETO IRMÃ ADELAIDE | 20. Doenças crônicas podem ser silenciosas";
            ((System.ComponentModel.ISupportInitialize)(this.foto20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto20;
        private PictureBox voltar20;
        private PictureBox anterior20;
        private PictureBox proximo20;
        private PictureBox titulo_pequeno_20;
        private Label titulo020;
        private RichTextBox conteudo020;
    }
}