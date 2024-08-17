namespace ProjetoIrmaAdelaide
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.foto10 = new System.Windows.Forms.PictureBox();
            this.voltar10 = new System.Windows.Forms.PictureBox();
            this.anterior10 = new System.Windows.Forms.PictureBox();
            this.proximo10 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_10 = new System.Windows.Forms.PictureBox();
            this.titulo010 = new System.Windows.Forms.Label();
            this.conteudo010 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_10)).BeginInit();
            this.SuspendLayout();
            // 
            // foto10
            // 
            this.foto10.BackColor = System.Drawing.Color.Transparent;
            this.foto10.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto101;
            this.foto10.Location = new System.Drawing.Point(1099, 45);
            this.foto10.Name = "foto10";
            this.foto10.Size = new System.Drawing.Size(216, 502);
            this.foto10.TabIndex = 1;
            this.foto10.TabStop = false;
            // 
            // voltar10
            // 
            this.voltar10.BackColor = System.Drawing.Color.Transparent;
            this.voltar10.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar10.Location = new System.Drawing.Point(48, 584);
            this.voltar10.Name = "voltar10";
            this.voltar10.Size = new System.Drawing.Size(172, 76);
            this.voltar10.TabIndex = 2;
            this.voltar10.TabStop = false;
            this.voltar10.Click += new System.EventHandler(this.voltar10_Click);
            // 
            // anterior10
            // 
            this.anterior10.BackColor = System.Drawing.Color.Transparent;
            this.anterior10.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior10.Location = new System.Drawing.Point(270, 584);
            this.anterior10.Name = "anterior10";
            this.anterior10.Size = new System.Drawing.Size(172, 76);
            this.anterior10.TabIndex = 3;
            this.anterior10.TabStop = false;
            this.anterior10.Click += new System.EventHandler(this.anterior10_Click);
            // 
            // proximo10
            // 
            this.proximo10.BackColor = System.Drawing.Color.Transparent;
            this.proximo10.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo10.Location = new System.Drawing.Point(450, 584);
            this.proximo10.Name = "proximo10";
            this.proximo10.Size = new System.Drawing.Size(172, 76);
            this.proximo10.TabIndex = 4;
            this.proximo10.TabStop = false;
            this.proximo10.Click += new System.EventHandler(this.proximo10_Click);
            // 
            // titulo_pequeno_10
            // 
            this.titulo_pequeno_10.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_10.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_10.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_10.Name = "titulo_pequeno_10";
            this.titulo_pequeno_10.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_10.TabIndex = 5;
            this.titulo_pequeno_10.TabStop = false;
            // 
            // titulo010
            // 
            this.titulo010.AutoSize = true;
            this.titulo010.BackColor = System.Drawing.Color.Transparent;
            this.titulo010.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo010.Location = new System.Drawing.Point(75, 72);
            this.titulo010.Name = "titulo010";
            this.titulo010.Size = new System.Drawing.Size(658, 37);
            this.titulo010.TabIndex = 6;
            this.titulo010.Text = "10. PLANTAS MEDICINAIS X FITOTERAPIA";
            // 
            // conteudo010
            // 
            this.conteudo010.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo010.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo010.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo010.Location = new System.Drawing.Point(75, 132);
            this.conteudo010.Name = "conteudo010";
            this.conteudo010.ReadOnly = true;
            this.conteudo010.Size = new System.Drawing.Size(976, 393);
            this.conteudo010.TabIndex = 7;
            this.conteudo010.Text = resources.GetString("conteudo010.Text");
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo010);
            this.Controls.Add(this.titulo010);
            this.Controls.Add(this.titulo_pequeno_10);
            this.Controls.Add(this.proximo10);
            this.Controls.Add(this.anterior10);
            this.Controls.Add(this.voltar10);
            this.Controls.Add(this.foto10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form13";
            this.Text = "PROJETO IRMÃ ADELAIDE | 10. Plantas medicinais x fitoterapia";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto10;
        private PictureBox voltar10;
        private PictureBox anterior10;
        private PictureBox proximo10;
        private PictureBox titulo_pequeno_10;
        private Label titulo010;
        private RichTextBox conteudo010;
    }
}