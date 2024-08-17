namespace ProjetoIrmaAdelaide
{
    partial class Form18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form18));
            this.foto15 = new System.Windows.Forms.PictureBox();
            this.voltar15 = new System.Windows.Forms.PictureBox();
            this.anterior15 = new System.Windows.Forms.PictureBox();
            this.proximo15 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_15 = new System.Windows.Forms.PictureBox();
            this.titulo015 = new System.Windows.Forms.Label();
            this.conteudo015 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_15)).BeginInit();
            this.SuspendLayout();
            // 
            // foto15
            // 
            this.foto15.BackColor = System.Drawing.Color.Transparent;
            this.foto15.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto151;
            this.foto15.Location = new System.Drawing.Point(1099, 45);
            this.foto15.Name = "foto15";
            this.foto15.Size = new System.Drawing.Size(216, 502);
            this.foto15.TabIndex = 1;
            this.foto15.TabStop = false;
            // 
            // voltar15
            // 
            this.voltar15.BackColor = System.Drawing.Color.Transparent;
            this.voltar15.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar15.Location = new System.Drawing.Point(48, 584);
            this.voltar15.Name = "voltar15";
            this.voltar15.Size = new System.Drawing.Size(172, 76);
            this.voltar15.TabIndex = 2;
            this.voltar15.TabStop = false;
            this.voltar15.Click += new System.EventHandler(this.voltar15_Click);
            // 
            // anterior15
            // 
            this.anterior15.BackColor = System.Drawing.Color.Transparent;
            this.anterior15.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior15.Location = new System.Drawing.Point(270, 584);
            this.anterior15.Name = "anterior15";
            this.anterior15.Size = new System.Drawing.Size(172, 76);
            this.anterior15.TabIndex = 3;
            this.anterior15.TabStop = false;
            this.anterior15.Click += new System.EventHandler(this.anterior15_Click);
            // 
            // proximo15
            // 
            this.proximo15.BackColor = System.Drawing.Color.Transparent;
            this.proximo15.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo15.Location = new System.Drawing.Point(450, 584);
            this.proximo15.Name = "proximo15";
            this.proximo15.Size = new System.Drawing.Size(172, 76);
            this.proximo15.TabIndex = 4;
            this.proximo15.TabStop = false;
            this.proximo15.Click += new System.EventHandler(this.proximo15_Click);
            // 
            // titulo_pequeno_15
            // 
            this.titulo_pequeno_15.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_15.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_15.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_15.Name = "titulo_pequeno_15";
            this.titulo_pequeno_15.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_15.TabIndex = 5;
            this.titulo_pequeno_15.TabStop = false;
            // 
            // titulo015
            // 
            this.titulo015.AutoSize = true;
            this.titulo015.BackColor = System.Drawing.Color.Transparent;
            this.titulo015.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo015.Location = new System.Drawing.Point(75, 72);
            this.titulo015.Name = "titulo015";
            this.titulo015.Size = new System.Drawing.Size(996, 34);
            this.titulo015.TabIndex = 6;
            this.titulo015.Text = "15. MEDICAMENTOS POTENCIALMENTE INADEQUADOS PARA IDOSOS";
            // 
            // conteudo015
            // 
            this.conteudo015.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo015.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo015.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo015.Location = new System.Drawing.Point(75, 132);
            this.conteudo015.Name = "conteudo015";
            this.conteudo015.ReadOnly = true;
            this.conteudo015.Size = new System.Drawing.Size(976, 393);
            this.conteudo015.TabIndex = 7;
            this.conteudo015.Text = resources.GetString("conteudo015.Text");
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo015);
            this.Controls.Add(this.titulo015);
            this.Controls.Add(this.titulo_pequeno_15);
            this.Controls.Add(this.proximo15);
            this.Controls.Add(this.anterior15);
            this.Controls.Add(this.voltar15);
            this.Controls.Add(this.foto15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form18";
            this.Text = "PROJETO IRMÃ ADELAIDE | 15. Medicamentos potencialmente inadequados para idosos";
            ((System.ComponentModel.ISupportInitialize)(this.foto15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto15;
        private PictureBox voltar15;
        private PictureBox anterior15;
        private PictureBox proximo15;
        private PictureBox titulo_pequeno_15;
        private Label titulo015;
        private RichTextBox conteudo015;
    }
}