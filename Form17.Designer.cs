namespace ProjetoIrmaAdelaide
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.foto14 = new System.Windows.Forms.PictureBox();
            this.voltar14 = new System.Windows.Forms.PictureBox();
            this.anterior14 = new System.Windows.Forms.PictureBox();
            this.proximo14 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_14 = new System.Windows.Forms.PictureBox();
            this.titulo014 = new System.Windows.Forms.Label();
            this.conteudo014 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_14)).BeginInit();
            this.SuspendLayout();
            // 
            // foto14
            // 
            this.foto14.BackColor = System.Drawing.Color.Transparent;
            this.foto14.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto141;
            this.foto14.Location = new System.Drawing.Point(1099, 45);
            this.foto14.Name = "foto14";
            this.foto14.Size = new System.Drawing.Size(216, 502);
            this.foto14.TabIndex = 1;
            this.foto14.TabStop = false;
            // 
            // voltar14
            // 
            this.voltar14.BackColor = System.Drawing.Color.Transparent;
            this.voltar14.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar14.Location = new System.Drawing.Point(48, 584);
            this.voltar14.Name = "voltar14";
            this.voltar14.Size = new System.Drawing.Size(172, 76);
            this.voltar14.TabIndex = 2;
            this.voltar14.TabStop = false;
            this.voltar14.Click += new System.EventHandler(this.voltar14_Click);
            // 
            // anterior14
            // 
            this.anterior14.BackColor = System.Drawing.Color.Transparent;
            this.anterior14.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior14.Location = new System.Drawing.Point(270, 584);
            this.anterior14.Name = "anterior14";
            this.anterior14.Size = new System.Drawing.Size(172, 76);
            this.anterior14.TabIndex = 3;
            this.anterior14.TabStop = false;
            this.anterior14.Click += new System.EventHandler(this.anterior14_Click);
            // 
            // proximo14
            // 
            this.proximo14.BackColor = System.Drawing.Color.Transparent;
            this.proximo14.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo14.Location = new System.Drawing.Point(450, 584);
            this.proximo14.Name = "proximo14";
            this.proximo14.Size = new System.Drawing.Size(172, 76);
            this.proximo14.TabIndex = 4;
            this.proximo14.TabStop = false;
            this.proximo14.Click += new System.EventHandler(this.proximo14_Click);
            // 
            // titulo_pequeno_14
            // 
            this.titulo_pequeno_14.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_14.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_14.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_14.Name = "titulo_pequeno_14";
            this.titulo_pequeno_14.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_14.TabIndex = 5;
            this.titulo_pequeno_14.TabStop = false;
            // 
            // titulo014
            // 
            this.titulo014.AutoSize = true;
            this.titulo014.BackColor = System.Drawing.Color.Transparent;
            this.titulo014.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo014.Location = new System.Drawing.Point(75, 72);
            this.titulo014.Name = "titulo014";
            this.titulo014.Size = new System.Drawing.Size(983, 37);
            this.titulo014.TabIndex = 6;
            this.titulo014.Text = "14. REMÉDIOS DE ALTO CUSTO: COMO OBTER A GRATUIDADE";
            // 
            // conteudo014
            // 
            this.conteudo014.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo014.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo014.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo014.Location = new System.Drawing.Point(75, 132);
            this.conteudo014.Name = "conteudo014";
            this.conteudo014.ReadOnly = true;
            this.conteudo014.Size = new System.Drawing.Size(976, 393);
            this.conteudo014.TabIndex = 7;
            this.conteudo014.Text = resources.GetString("conteudo014.Text");
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo014);
            this.Controls.Add(this.titulo014);
            this.Controls.Add(this.titulo_pequeno_14);
            this.Controls.Add(this.proximo14);
            this.Controls.Add(this.anterior14);
            this.Controls.Add(this.voltar14);
            this.Controls.Add(this.foto14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form17";
            this.Text = "PROJETO IRMÃ ADELAIDE | 14. Remédios de alto custo: como obter a gratuidade";
            ((System.ComponentModel.ISupportInitialize)(this.foto14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto14;
        private PictureBox voltar14;
        private PictureBox anterior14;
        private PictureBox proximo14;
        private PictureBox titulo_pequeno_14;
        private Label titulo014;
        private RichTextBox conteudo014;
    }
}