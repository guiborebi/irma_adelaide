namespace ProjetoIrmaAdelaide
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.foto_01 = new System.Windows.Forms.PictureBox();
            this.titulo_peq_01 = new System.Windows.Forms.PictureBox();
            this.botao_proximo_01 = new System.Windows.Forms.PictureBox();
            this.botao_anterior_01 = new System.Windows.Forms.PictureBox();
            this.botao_voltar_01 = new System.Windows.Forms.PictureBox();
            this.titulo001 = new System.Windows.Forms.Label();
            this.conteudo001 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_peq_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_proximo_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_anterior_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_voltar_01)).BeginInit();
            this.SuspendLayout();
            // 
            // foto_01
            // 
            this.foto_01.BackColor = System.Drawing.Color.Transparent;
            this.foto_01.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto011;
            this.foto_01.Location = new System.Drawing.Point(1099, 45);
            this.foto_01.Name = "foto_01";
            this.foto_01.Size = new System.Drawing.Size(216, 502);
            this.foto_01.TabIndex = 1;
            this.foto_01.TabStop = false;
            // 
            // titulo_peq_01
            // 
            this.titulo_peq_01.BackColor = System.Drawing.Color.Transparent;
            this.titulo_peq_01.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo_peq_01.Location = new System.Drawing.Point(667, 565);
            this.titulo_peq_01.Name = "titulo_peq_01";
            this.titulo_peq_01.Size = new System.Drawing.Size(649, 116);
            this.titulo_peq_01.TabIndex = 2;
            this.titulo_peq_01.TabStop = false;
            // 
            // botao_proximo_01
            // 
            this.botao_proximo_01.BackColor = System.Drawing.Color.Transparent;
            this.botao_proximo_01.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.botao_proximo_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_proximo_01.Location = new System.Drawing.Point(450, 584);
            this.botao_proximo_01.Name = "botao_proximo_01";
            this.botao_proximo_01.Size = new System.Drawing.Size(172, 76);
            this.botao_proximo_01.TabIndex = 3;
            this.botao_proximo_01.TabStop = false;
            this.botao_proximo_01.Click += new System.EventHandler(this.botao_proximo_01_Click);
            // 
            // botao_anterior_01
            // 
            this.botao_anterior_01.BackColor = System.Drawing.Color.Transparent;
            this.botao_anterior_01.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.botao_anterior_01.Cursor = System.Windows.Forms.Cursors.No;
            this.botao_anterior_01.Location = new System.Drawing.Point(270, 584);
            this.botao_anterior_01.Name = "botao_anterior_01";
            this.botao_anterior_01.Size = new System.Drawing.Size(172, 76);
            this.botao_anterior_01.TabIndex = 4;
            this.botao_anterior_01.TabStop = false;
            this.botao_anterior_01.Click += new System.EventHandler(this.botao_anterior_01_Click);
            // 
            // botao_voltar_01
            // 
            this.botao_voltar_01.BackColor = System.Drawing.Color.Transparent;
            this.botao_voltar_01.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.botao_voltar_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_voltar_01.Location = new System.Drawing.Point(48, 584);
            this.botao_voltar_01.Name = "botao_voltar_01";
            this.botao_voltar_01.Size = new System.Drawing.Size(172, 76);
            this.botao_voltar_01.TabIndex = 5;
            this.botao_voltar_01.TabStop = false;
            this.botao_voltar_01.Click += new System.EventHandler(this.botao_voltar_01_Click);
            // 
            // titulo001
            // 
            this.titulo001.AutoSize = true;
            this.titulo001.BackColor = System.Drawing.Color.Transparent;
            this.titulo001.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo001.ForeColor = System.Drawing.SystemColors.WindowText;
            this.titulo001.Location = new System.Drawing.Point(75, 72);
            this.titulo001.Name = "titulo001";
            this.titulo001.Size = new System.Drawing.Size(957, 37);
            this.titulo001.TabIndex = 6;
            this.titulo001.Text = "1. COMO ARMAZENAR CORRETAMENTE OS MEDICAMENTOS";
            // 
            // conteudo001
            // 
            this.conteudo001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo001.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo001.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo001.Location = new System.Drawing.Point(75, 132);
            this.conteudo001.Name = "conteudo001";
            this.conteudo001.ReadOnly = true;
            this.conteudo001.Size = new System.Drawing.Size(976, 393);
            this.conteudo001.TabIndex = 7;
            this.conteudo001.Text = resources.GetString("conteudo001.Text");
            this.conteudo001.TextChanged += new System.EventHandler(this.conteudo001_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo001);
            this.Controls.Add(this.titulo001);
            this.Controls.Add(this.botao_voltar_01);
            this.Controls.Add(this.botao_anterior_01);
            this.Controls.Add(this.botao_proximo_01);
            this.Controls.Add(this.titulo_peq_01);
            this.Controls.Add(this.foto_01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "PROJETO IRMÃ ADELAIDE | 1. Como armazenar corretamente os medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.foto_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_peq_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_proximo_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_anterior_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_voltar_01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto_01;
        private PictureBox titulo_peq_01;
        private PictureBox botao_proximo_01;
        private PictureBox botao_anterior_01;
        private PictureBox botao_voltar_01;
        private Label titulo001;
        private RichTextBox conteudo001;
    }
}