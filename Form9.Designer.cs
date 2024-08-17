namespace ProjetoIrmaAdelaide
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.foto06 = new System.Windows.Forms.PictureBox();
            this.voltar06 = new System.Windows.Forms.PictureBox();
            this.anterior06 = new System.Windows.Forms.PictureBox();
            this.proximo06 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_06 = new System.Windows.Forms.PictureBox();
            this.titulo006 = new System.Windows.Forms.Label();
            this.conteudo006 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_06)).BeginInit();
            this.SuspendLayout();
            // 
            // foto06
            // 
            this.foto06.BackColor = System.Drawing.Color.Transparent;
            this.foto06.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto061;
            this.foto06.Location = new System.Drawing.Point(1099, 45);
            this.foto06.Name = "foto06";
            this.foto06.Size = new System.Drawing.Size(216, 502);
            this.foto06.TabIndex = 1;
            this.foto06.TabStop = false;
            // 
            // voltar06
            // 
            this.voltar06.BackColor = System.Drawing.Color.Transparent;
            this.voltar06.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar06.Location = new System.Drawing.Point(48, 584);
            this.voltar06.Name = "voltar06";
            this.voltar06.Size = new System.Drawing.Size(172, 76);
            this.voltar06.TabIndex = 2;
            this.voltar06.TabStop = false;
            this.voltar06.Click += new System.EventHandler(this.voltar06_Click);
            // 
            // anterior06
            // 
            this.anterior06.BackColor = System.Drawing.Color.Transparent;
            this.anterior06.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior06.Location = new System.Drawing.Point(270, 584);
            this.anterior06.Name = "anterior06";
            this.anterior06.Size = new System.Drawing.Size(172, 76);
            this.anterior06.TabIndex = 3;
            this.anterior06.TabStop = false;
            this.anterior06.Click += new System.EventHandler(this.anterior06_Click);
            // 
            // proximo06
            // 
            this.proximo06.BackColor = System.Drawing.Color.Transparent;
            this.proximo06.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo06.Location = new System.Drawing.Point(450, 584);
            this.proximo06.Name = "proximo06";
            this.proximo06.Size = new System.Drawing.Size(172, 76);
            this.proximo06.TabIndex = 4;
            this.proximo06.TabStop = false;
            this.proximo06.Click += new System.EventHandler(this.proximo06_Click);
            // 
            // titulo_pequeno_06
            // 
            this.titulo_pequeno_06.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_06.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_06.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_06.Name = "titulo_pequeno_06";
            this.titulo_pequeno_06.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_06.TabIndex = 5;
            this.titulo_pequeno_06.TabStop = false;
            // 
            // titulo006
            // 
            this.titulo006.AutoSize = true;
            this.titulo006.BackColor = System.Drawing.Color.Transparent;
            this.titulo006.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo006.Location = new System.Drawing.Point(75, 72);
            this.titulo006.Name = "titulo006";
            this.titulo006.Size = new System.Drawing.Size(989, 34);
            this.titulo006.TabIndex = 6;
            this.titulo006.Text = "6. NÃO UTILIZE  MEDICAMENTOS INDICADOS POR OUTRAS PESSOAS";
            // 
            // conteudo006
            // 
            this.conteudo006.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo006.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo006.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo006.Location = new System.Drawing.Point(75, 132);
            this.conteudo006.Name = "conteudo006";
            this.conteudo006.ReadOnly = true;
            this.conteudo006.Size = new System.Drawing.Size(976, 393);
            this.conteudo006.TabIndex = 7;
            this.conteudo006.Text = resources.GetString("conteudo006.Text");
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo006);
            this.Controls.Add(this.titulo006);
            this.Controls.Add(this.titulo_pequeno_06);
            this.Controls.Add(this.proximo06);
            this.Controls.Add(this.anterior06);
            this.Controls.Add(this.voltar06);
            this.Controls.Add(this.foto06);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "PROJETO IRMÃ ADELAIDE | 6. Não utilize  medicamentos indicados por outras pessoas" +
    "";
            ((System.ComponentModel.ISupportInitialize)(this.foto06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_06)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto06;
        private PictureBox voltar06;
        private PictureBox anterior06;
        private PictureBox proximo06;
        private PictureBox titulo_pequeno_06;
        private Label titulo006;
        private RichTextBox conteudo006;
    }
}