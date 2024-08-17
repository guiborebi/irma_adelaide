namespace ProjetoIrmaAdelaide
{
    partial class Form20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form20));
            this.foto17 = new System.Windows.Forms.PictureBox();
            this.voltar17 = new System.Windows.Forms.PictureBox();
            this.anterior17 = new System.Windows.Forms.PictureBox();
            this.proximo17 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_17 = new System.Windows.Forms.PictureBox();
            this.titulo017 = new System.Windows.Forms.Label();
            this.conteudo017 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_17)).BeginInit();
            this.SuspendLayout();
            // 
            // foto17
            // 
            this.foto17.BackColor = System.Drawing.Color.Transparent;
            this.foto17.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto171;
            this.foto17.Location = new System.Drawing.Point(1099, 45);
            this.foto17.Name = "foto17";
            this.foto17.Size = new System.Drawing.Size(216, 502);
            this.foto17.TabIndex = 1;
            this.foto17.TabStop = false;
            // 
            // voltar17
            // 
            this.voltar17.BackColor = System.Drawing.Color.Transparent;
            this.voltar17.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar17.Location = new System.Drawing.Point(48, 584);
            this.voltar17.Name = "voltar17";
            this.voltar17.Size = new System.Drawing.Size(172, 76);
            this.voltar17.TabIndex = 2;
            this.voltar17.TabStop = false;
            this.voltar17.Click += new System.EventHandler(this.voltar17_Click);
            // 
            // anterior17
            // 
            this.anterior17.BackColor = System.Drawing.Color.Transparent;
            this.anterior17.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior17.Location = new System.Drawing.Point(270, 584);
            this.anterior17.Name = "anterior17";
            this.anterior17.Size = new System.Drawing.Size(172, 76);
            this.anterior17.TabIndex = 3;
            this.anterior17.TabStop = false;
            this.anterior17.Click += new System.EventHandler(this.anterior17_Click);
            // 
            // proximo17
            // 
            this.proximo17.BackColor = System.Drawing.Color.Transparent;
            this.proximo17.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo17.Location = new System.Drawing.Point(450, 584);
            this.proximo17.Name = "proximo17";
            this.proximo17.Size = new System.Drawing.Size(172, 76);
            this.proximo17.TabIndex = 4;
            this.proximo17.TabStop = false;
            this.proximo17.Click += new System.EventHandler(this.proximo17_Click);
            // 
            // titulo_pequeno_17
            // 
            this.titulo_pequeno_17.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_17.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_17.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_17.Name = "titulo_pequeno_17";
            this.titulo_pequeno_17.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_17.TabIndex = 5;
            this.titulo_pequeno_17.TabStop = false;
            // 
            // titulo017
            // 
            this.titulo017.AutoSize = true;
            this.titulo017.BackColor = System.Drawing.Color.Transparent;
            this.titulo017.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo017.Location = new System.Drawing.Point(75, 72);
            this.titulo017.Name = "titulo017";
            this.titulo017.Size = new System.Drawing.Size(579, 37);
            this.titulo017.TabIndex = 6;
            this.titulo017.Text = "17. QUAL MÉDICO DEVO PROCURAR";
            // 
            // conteudo017
            // 
            this.conteudo017.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo017.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo017.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo017.Location = new System.Drawing.Point(75, 132);
            this.conteudo017.Name = "conteudo017";
            this.conteudo017.ReadOnly = true;
            this.conteudo017.Size = new System.Drawing.Size(976, 393);
            this.conteudo017.TabIndex = 7;
            this.conteudo017.Text = resources.GetString("conteudo017.Text");
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo017);
            this.Controls.Add(this.titulo017);
            this.Controls.Add(this.titulo_pequeno_17);
            this.Controls.Add(this.proximo17);
            this.Controls.Add(this.anterior17);
            this.Controls.Add(this.voltar17);
            this.Controls.Add(this.foto17);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form20";
            this.Text = "PROJETO IRMÃ ADELAIDE | 17. Qual médico devo procurar";
            ((System.ComponentModel.ISupportInitialize)(this.foto17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto17;
        private PictureBox voltar17;
        private PictureBox anterior17;
        private PictureBox proximo17;
        private PictureBox titulo_pequeno_17;
        private Label titulo017;
        private RichTextBox conteudo017;
    }
}