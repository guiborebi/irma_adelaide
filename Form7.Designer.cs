namespace ProjetoIrmaAdelaide
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.foto04 = new System.Windows.Forms.PictureBox();
            this.voltar04 = new System.Windows.Forms.PictureBox();
            this.anterior04 = new System.Windows.Forms.PictureBox();
            this.proximo04 = new System.Windows.Forms.PictureBox();
            this.titulo_pequeno_04 = new System.Windows.Forms.PictureBox();
            this.titulo004 = new System.Windows.Forms.Label();
            this.conteudo004 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_04)).BeginInit();
            this.SuspendLayout();
            // 
            // foto04
            // 
            this.foto04.BackColor = System.Drawing.Color.Transparent;
            this.foto04.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto041;
            this.foto04.Location = new System.Drawing.Point(1099, 45);
            this.foto04.Name = "foto04";
            this.foto04.Size = new System.Drawing.Size(216, 502);
            this.foto04.TabIndex = 1;
            this.foto04.TabStop = false;
            // 
            // voltar04
            // 
            this.voltar04.BackColor = System.Drawing.Color.Transparent;
            this.voltar04.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar04.Location = new System.Drawing.Point(48, 584);
            this.voltar04.Name = "voltar04";
            this.voltar04.Size = new System.Drawing.Size(172, 76);
            this.voltar04.TabIndex = 2;
            this.voltar04.TabStop = false;
            this.voltar04.Click += new System.EventHandler(this.voltar04_Click);
            // 
            // anterior04
            // 
            this.anterior04.BackColor = System.Drawing.Color.Transparent;
            this.anterior04.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior04.Location = new System.Drawing.Point(270, 584);
            this.anterior04.Name = "anterior04";
            this.anterior04.Size = new System.Drawing.Size(172, 76);
            this.anterior04.TabIndex = 3;
            this.anterior04.TabStop = false;
            this.anterior04.Click += new System.EventHandler(this.anterior04_Click);
            // 
            // proximo04
            // 
            this.proximo04.BackColor = System.Drawing.Color.Transparent;
            this.proximo04.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo04.Location = new System.Drawing.Point(450, 584);
            this.proximo04.Name = "proximo04";
            this.proximo04.Size = new System.Drawing.Size(172, 76);
            this.proximo04.TabIndex = 4;
            this.proximo04.TabStop = false;
            this.proximo04.Click += new System.EventHandler(this.proximo04_Click);
            // 
            // titulo_pequeno_04
            // 
            this.titulo_pequeno_04.BackColor = System.Drawing.Color.Transparent;
            this.titulo_pequeno_04.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_pequeno_04.Location = new System.Drawing.Point(667, 565);
            this.titulo_pequeno_04.Name = "titulo_pequeno_04";
            this.titulo_pequeno_04.Size = new System.Drawing.Size(649, 116);
            this.titulo_pequeno_04.TabIndex = 5;
            this.titulo_pequeno_04.TabStop = false;
            // 
            // titulo004
            // 
            this.titulo004.AutoSize = true;
            this.titulo004.BackColor = System.Drawing.Color.Transparent;
            this.titulo004.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo004.Location = new System.Drawing.Point(75, 72);
            this.titulo004.Name = "titulo004";
            this.titulo004.Size = new System.Drawing.Size(986, 34);
            this.titulo004.TabIndex = 6;
            this.titulo004.Text = "4. A IMPORTÂNCIA DO PAPEL DO PACIENTE E DOS SEUS FAMILIARES";
            // 
            // conteudo004
            // 
            this.conteudo004.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo004.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo004.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo004.Location = new System.Drawing.Point(75, 132);
            this.conteudo004.Name = "conteudo004";
            this.conteudo004.ReadOnly = true;
            this.conteudo004.Size = new System.Drawing.Size(976, 393);
            this.conteudo004.TabIndex = 7;
            this.conteudo004.Text = resources.GetString("conteudo004.Text");
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo004);
            this.Controls.Add(this.titulo004);
            this.Controls.Add(this.titulo_pequeno_04);
            this.Controls.Add(this.proximo04);
            this.Controls.Add(this.anterior04);
            this.Controls.Add(this.voltar04);
            this.Controls.Add(this.foto04);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "PROJETO IRMÃ ADELAIDE | 4. A importância do papel do paciente e dos seus familiar" +
    "es";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_pequeno_04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto04;
        private PictureBox voltar04;
        private PictureBox anterior04;
        private PictureBox proximo04;
        private PictureBox titulo_pequeno_04;
        private Label titulo004;
        private RichTextBox conteudo004;
    }
}