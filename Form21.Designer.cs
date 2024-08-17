namespace ProjetoIrmaAdelaide
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            this.foto18 = new System.Windows.Forms.PictureBox();
            this.voltar18 = new System.Windows.Forms.PictureBox();
            this.anterior18 = new System.Windows.Forms.PictureBox();
            this.proximo18 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_18 = new System.Windows.Forms.PictureBox();
            this.titulo018 = new System.Windows.Forms.Label();
            this.conteudo018 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_18)).BeginInit();
            this.SuspendLayout();
            // 
            // foto18
            // 
            this.foto18.BackColor = System.Drawing.Color.Transparent;
            this.foto18.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto181;
            this.foto18.Location = new System.Drawing.Point(1099, 45);
            this.foto18.Name = "foto18";
            this.foto18.Size = new System.Drawing.Size(216, 502);
            this.foto18.TabIndex = 1;
            this.foto18.TabStop = false;
            // 
            // voltar18
            // 
            this.voltar18.BackColor = System.Drawing.Color.Transparent;
            this.voltar18.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar18.Location = new System.Drawing.Point(48, 584);
            this.voltar18.Name = "voltar18";
            this.voltar18.Size = new System.Drawing.Size(172, 76);
            this.voltar18.TabIndex = 2;
            this.voltar18.TabStop = false;
            this.voltar18.Click += new System.EventHandler(this.voltar18_Click);
            // 
            // anterior18
            // 
            this.anterior18.BackColor = System.Drawing.Color.Transparent;
            this.anterior18.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior18.Location = new System.Drawing.Point(270, 584);
            this.anterior18.Name = "anterior18";
            this.anterior18.Size = new System.Drawing.Size(172, 76);
            this.anterior18.TabIndex = 3;
            this.anterior18.TabStop = false;
            this.anterior18.Click += new System.EventHandler(this.anterior18_Click);
            // 
            // proximo18
            // 
            this.proximo18.BackColor = System.Drawing.Color.Transparent;
            this.proximo18.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo18.Location = new System.Drawing.Point(450, 584);
            this.proximo18.Name = "proximo18";
            this.proximo18.Size = new System.Drawing.Size(172, 76);
            this.proximo18.TabIndex = 4;
            this.proximo18.TabStop = false;
            this.proximo18.Click += new System.EventHandler(this.proximo18_Click);
            // 
            // titulo_pequeno_18
            // 
            this.titulo_pequeno_18.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_18.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_18.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_18.Name = "titulo_pequeno_18";
            this.titulo_pequeno_18.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_18.TabIndex = 5;
            this.titulo_pequeno_18.TabStop = false;
            // 
            // titulo018
            // 
            this.titulo018.AutoSize = true;
            this.titulo018.BackColor = System.Drawing.Color.Transparent;
            this.titulo018.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo018.Location = new System.Drawing.Point(75, 72);
            this.titulo018.Name = "titulo018";
            this.titulo018.Size = new System.Drawing.Size(874, 37);
            this.titulo018.TabIndex = 6;
            this.titulo018.Text = "18. MOTIVOS PARA CONTRATAR CUIDADOR DE IDOSOS";
            // 
            // conteudo018
            // 
            this.conteudo018.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo018.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo018.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo018.Location = new System.Drawing.Point(75, 132);
            this.conteudo018.Name = "conteudo018";
            this.conteudo018.ReadOnly = true;
            this.conteudo018.Size = new System.Drawing.Size(976, 393);
            this.conteudo018.TabIndex = 7;
            this.conteudo018.Text = resources.GetString("conteudo018.Text");
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo018);
            this.Controls.Add(this.titulo018);
            this.Controls.Add(this.titulo_pequeno_18);
            this.Controls.Add(this.proximo18);
            this.Controls.Add(this.anterior18);
            this.Controls.Add(this.voltar18);
            this.Controls.Add(this.foto18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form21";
            this.Text = "PROJETO IRMÃ ADELAIDE | 18. Motivos para contratar cuidador de idosos";
            ((System.ComponentModel.ISupportInitialize)(this.foto18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto18;
        private PictureBox voltar18;
        private PictureBox anterior18;
        private PictureBox proximo18;
        private PictureBox titulo_pequeno_18;
        private Label titulo018;
        private RichTextBox conteudo018;
    }
}