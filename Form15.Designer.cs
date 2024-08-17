namespace ProjetoIrmaAdelaide
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.foto12 = new System.Windows.Forms.PictureBox();
            this.voltar12 = new System.Windows.Forms.PictureBox();
            this.anterior12 = new System.Windows.Forms.PictureBox();
            this.proximo12 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_12 = new System.Windows.Forms.PictureBox();
            this.titulo012 = new System.Windows.Forms.Label();
            this.conteudo012 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_12)).BeginInit();
            this.SuspendLayout();
            // 
            // foto12
            // 
            this.foto12.BackColor = System.Drawing.Color.Transparent;
            this.foto12.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto121;
            this.foto12.Location = new System.Drawing.Point(1099, 45);
            this.foto12.Name = "foto12";
            this.foto12.Size = new System.Drawing.Size(216, 502);
            this.foto12.TabIndex = 1;
            this.foto12.TabStop = false;
            // 
            // voltar12
            // 
            this.voltar12.BackColor = System.Drawing.Color.Transparent;
            this.voltar12.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar12.Location = new System.Drawing.Point(48, 584);
            this.voltar12.Name = "voltar12";
            this.voltar12.Size = new System.Drawing.Size(172, 76);
            this.voltar12.TabIndex = 2;
            this.voltar12.TabStop = false;
            this.voltar12.Click += new System.EventHandler(this.voltar12_Click);
            // 
            // anterior12
            // 
            this.anterior12.BackColor = System.Drawing.Color.Transparent;
            this.anterior12.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior12.Location = new System.Drawing.Point(270, 584);
            this.anterior12.Name = "anterior12";
            this.anterior12.Size = new System.Drawing.Size(172, 76);
            this.anterior12.TabIndex = 3;
            this.anterior12.TabStop = false;
            this.anterior12.Click += new System.EventHandler(this.anterior12_Click);
            // 
            // proximo12
            // 
            this.proximo12.BackColor = System.Drawing.Color.Transparent;
            this.proximo12.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo12.Location = new System.Drawing.Point(450, 584);
            this.proximo12.Name = "proximo12";
            this.proximo12.Size = new System.Drawing.Size(172, 76);
            this.proximo12.TabIndex = 4;
            this.proximo12.TabStop = false;
            this.proximo12.Click += new System.EventHandler(this.proximo12_Click);
            // 
            // titulo_pequeno_12
            // 
            this.titulo_pequeno_12.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_12.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_12.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_12.Name = "titulo_pequeno_12";
            this.titulo_pequeno_12.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_12.TabIndex = 5;
            this.titulo_pequeno_12.TabStop = false;
            // 
            // titulo012
            // 
            this.titulo012.AutoSize = true;
            this.titulo012.BackColor = System.Drawing.Color.Transparent;
            this.titulo012.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo012.Location = new System.Drawing.Point(75, 72);
            this.titulo012.Name = "titulo012";
            this.titulo012.Size = new System.Drawing.Size(973, 34);
            this.titulo012.TabIndex = 6;
            this.titulo012.Text = "12. MODO CORRETO PARA DESCARTAR MEDICAMENTOS VENCIDOS";
            // 
            // conteudo012
            // 
            this.conteudo012.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo012.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo012.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo012.Location = new System.Drawing.Point(75, 132);
            this.conteudo012.Name = "conteudo012";
            this.conteudo012.ReadOnly = true;
            this.conteudo012.Size = new System.Drawing.Size(976, 393);
            this.conteudo012.TabIndex = 7;
            this.conteudo012.Text = resources.GetString("conteudo012.Text");
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo012);
            this.Controls.Add(this.titulo012);
            this.Controls.Add(this.titulo_pequeno_12);
            this.Controls.Add(this.proximo12);
            this.Controls.Add(this.anterior12);
            this.Controls.Add(this.voltar12);
            this.Controls.Add(this.foto12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form15";
            this.Text = "PROJETO IRMÃ ADELAIDE | 12. Modo correto para descartar medicamentos vencidos";
            ((System.ComponentModel.ISupportInitialize)(this.foto12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto12;
        private PictureBox voltar12;
        private PictureBox anterior12;
        private PictureBox proximo12;
        private PictureBox titulo_pequeno_12;
        private Label titulo012;
        private RichTextBox conteudo012;
    }
}