namespace ProjetoIrmaAdelaide
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.foto13 = new System.Windows.Forms.PictureBox();
            this.voltar13 = new System.Windows.Forms.PictureBox();
            this.anterior13 = new System.Windows.Forms.PictureBox();
            this.proximo13 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_13 = new System.Windows.Forms.PictureBox();
            this.titulo013 = new System.Windows.Forms.Label();
            this.conteudo013 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_13)).BeginInit();
            this.SuspendLayout();
            // 
            // foto13
            // 
            this.foto13.BackColor = System.Drawing.Color.Transparent;
            this.foto13.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto131;
            this.foto13.Location = new System.Drawing.Point(1099, 45);
            this.foto13.Name = "foto13";
            this.foto13.Size = new System.Drawing.Size(216, 502);
            this.foto13.TabIndex = 1;
            this.foto13.TabStop = false;
            // 
            // voltar13
            // 
            this.voltar13.BackColor = System.Drawing.Color.Transparent;
            this.voltar13.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar13.Location = new System.Drawing.Point(48, 584);
            this.voltar13.Name = "voltar13";
            this.voltar13.Size = new System.Drawing.Size(172, 76);
            this.voltar13.TabIndex = 2;
            this.voltar13.TabStop = false;
            this.voltar13.Click += new System.EventHandler(this.voltar13_Click);
            // 
            // anterior13
            // 
            this.anterior13.BackColor = System.Drawing.Color.Transparent;
            this.anterior13.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior13.Location = new System.Drawing.Point(270, 584);
            this.anterior13.Name = "anterior13";
            this.anterior13.Size = new System.Drawing.Size(172, 76);
            this.anterior13.TabIndex = 3;
            this.anterior13.TabStop = false;
            this.anterior13.Click += new System.EventHandler(this.anterior13_Click);
            // 
            // proximo13
            // 
            this.proximo13.BackColor = System.Drawing.Color.Transparent;
            this.proximo13.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo13.Location = new System.Drawing.Point(450, 584);
            this.proximo13.Name = "proximo13";
            this.proximo13.Size = new System.Drawing.Size(172, 76);
            this.proximo13.TabIndex = 4;
            this.proximo13.TabStop = false;
            this.proximo13.Click += new System.EventHandler(this.proximo13_Click);
            // 
            // titulo_pequeno_13
            // 
            this.titulo_pequeno_13.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_13.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_13.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_13.Name = "titulo_pequeno_13";
            this.titulo_pequeno_13.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_13.TabIndex = 5;
            this.titulo_pequeno_13.TabStop = false;
            // 
            // titulo013
            // 
            this.titulo013.AutoSize = true;
            this.titulo013.BackColor = System.Drawing.Color.Transparent;
            this.titulo013.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo013.Location = new System.Drawing.Point(75, 72);
            this.titulo013.Name = "titulo013";
            this.titulo013.Size = new System.Drawing.Size(692, 37);
            this.titulo013.TabIndex = 6;
            this.titulo013.Text = "13. IDOSOS RESISTEM A TOMAR REMÉDIOS";
            // 
            // conteudo013
            // 
            this.conteudo013.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo013.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo013.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo013.Location = new System.Drawing.Point(75, 132);
            this.conteudo013.Name = "conteudo013";
            this.conteudo013.Size = new System.Drawing.Size(976, 393);
            this.conteudo013.TabIndex = 7;
            this.conteudo013.Text = resources.GetString("conteudo013.Text");
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo013);
            this.Controls.Add(this.titulo013);
            this.Controls.Add(this.titulo_pequeno_13);
            this.Controls.Add(this.proximo13);
            this.Controls.Add(this.anterior13);
            this.Controls.Add(this.voltar13);
            this.Controls.Add(this.foto13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "PROJETO IRMÃ ADELAIDE | 13. Idosos resistem a tomar remédios";
            ((System.ComponentModel.ISupportInitialize)(this.foto13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto13;
        private PictureBox voltar13;
        private PictureBox anterior13;
        private PictureBox proximo13;
        private PictureBox titulo_pequeno_13;
        private Label titulo013;
        private RichTextBox conteudo013;
    }
}