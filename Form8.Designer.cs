namespace ProjetoIrmaAdelaide
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.foto05 = new System.Windows.Forms.PictureBox();
            this.voltar05 = new System.Windows.Forms.PictureBox();
            this.anterior05 = new System.Windows.Forms.PictureBox();
            this.proximo05 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_05 = new System.Windows.Forms.PictureBox();
            this.titulo005 = new System.Windows.Forms.Label();
            this.conteudo005 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_05)).BeginInit();
            this.SuspendLayout();
            // 
            // foto05
            // 
            this.foto05.BackColor = System.Drawing.Color.Transparent;
            this.foto05.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto051;
            this.foto05.Location = new System.Drawing.Point(1099, 45);
            this.foto05.Name = "foto05";
            this.foto05.Size = new System.Drawing.Size(216, 502);
            this.foto05.TabIndex = 1;
            this.foto05.TabStop = false;
            // 
            // voltar05
            // 
            this.voltar05.BackColor = System.Drawing.Color.Transparent;
            this.voltar05.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar05.Location = new System.Drawing.Point(48, 584);
            this.voltar05.Name = "voltar05";
            this.voltar05.Size = new System.Drawing.Size(172, 76);
            this.voltar05.TabIndex = 2;
            this.voltar05.TabStop = false;
            this.voltar05.Click += new System.EventHandler(this.voltar05_Click);
            // 
            // anterior05
            // 
            this.anterior05.BackColor = System.Drawing.Color.Transparent;
            this.anterior05.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior05.Location = new System.Drawing.Point(270, 584);
            this.anterior05.Name = "anterior05";
            this.anterior05.Size = new System.Drawing.Size(172, 76);
            this.anterior05.TabIndex = 3;
            this.anterior05.TabStop = false;
            this.anterior05.Click += new System.EventHandler(this.anterior05_Click);
            // 
            // proximo05
            // 
            this.proximo05.BackColor = System.Drawing.Color.Transparent;
            this.proximo05.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo05.Location = new System.Drawing.Point(450, 584);
            this.proximo05.Name = "proximo05";
            this.proximo05.Size = new System.Drawing.Size(172, 76);
            this.proximo05.TabIndex = 4;
            this.proximo05.TabStop = false;
            this.proximo05.Click += new System.EventHandler(this.proximo05_Click);
            // 
            // titulo_pequeno_05
            // 
            this.titulo_pequeno_05.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_05.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_05.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_05.Name = "titulo_pequeno_05";
            this.titulo_pequeno_05.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_05.TabIndex = 5;
            this.titulo_pequeno_05.TabStop = false;
            // 
            // titulo005
            // 
            this.titulo005.AutoSize = true;
            this.titulo005.BackColor = System.Drawing.Color.Transparent;
            this.titulo005.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo005.Location = new System.Drawing.Point(75, 72);
            this.titulo005.Name = "titulo005";
            this.titulo005.Size = new System.Drawing.Size(948, 37);
            this.titulo005.TabIndex = 6;
            this.titulo005.Text = "5. MEDICAMENTOS “DE MARCA”,  GENÉRICOS E SIMILARES";
            // 
            // conteudo005
            // 
            this.conteudo005.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo005.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo005.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo005.Location = new System.Drawing.Point(75, 132);
            this.conteudo005.Name = "conteudo005";
            this.conteudo005.ReadOnly = true;
            this.conteudo005.Size = new System.Drawing.Size(976, 393);
            this.conteudo005.TabIndex = 7;
            this.conteudo005.Text = resources.GetString("conteudo005.Text");
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo005);
            this.Controls.Add(this.titulo005);
            this.Controls.Add(this.titulo_pequeno_05);
            this.Controls.Add(this.proximo05);
            this.Controls.Add(this.anterior05);
            this.Controls.Add(this.voltar05);
            this.Controls.Add(this.foto05);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "PROJETO IRMÃ ADELAIDE | 5. Medicamentos “de marca”,  genéricos e similares";
            ((System.ComponentModel.ISupportInitialize)(this.foto05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_05)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto05;
        private PictureBox voltar05;
        private PictureBox anterior05;
        private PictureBox proximo05;
        private PictureBox titulo_pequeno_05;
        private Label titulo005;
        private RichTextBox conteudo005;
    }
}