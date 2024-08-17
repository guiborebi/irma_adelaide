namespace ProjetoIrmaAdelaide
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imagem_creditos = new System.Windows.Forms.PictureBox();
            this.botao_voltar_creditos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_creditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_voltar_creditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagem_creditos
            // 
            this.imagem_creditos.BackColor = System.Drawing.Color.Transparent;
            this.imagem_creditos.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_credito;
            this.imagem_creditos.Location = new System.Drawing.Point(686, 20);
            this.imagem_creditos.Name = "imagem_creditos";
            this.imagem_creditos.Size = new System.Drawing.Size(326, 99);
            this.imagem_creditos.TabIndex = 0;
            this.imagem_creditos.TabStop = false;
            this.imagem_creditos.Click += new System.EventHandler(this.imagem_creditos_Click);
            // 
            // botao_voltar_creditos
            // 
            this.botao_voltar_creditos.BackColor = System.Drawing.Color.Transparent;
            this.botao_voltar_creditos.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar;
            this.botao_voltar_creditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botao_voltar_creditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_voltar_creditos.Location = new System.Drawing.Point(78, 558);
            this.botao_voltar_creditos.Name = "botao_voltar_creditos";
            this.botao_voltar_creditos.Size = new System.Drawing.Size(185, 91);
            this.botao_voltar_creditos.TabIndex = 14;
            this.botao_voltar_creditos.TabStop = false;
            this.botao_voltar_creditos.Tag = "";
            this.botao_voltar_creditos.Click += new System.EventHandler(this.botao_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.conteudo_creditos41;
            this.pictureBox1.Location = new System.Drawing.Point(415, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 532);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundazul;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botao_voltar_creditos);
            this.Controls.Add(this.imagem_creditos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "PROJETO IRMÃ ADELAIDE | CRÉDITOS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_creditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_voltar_creditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imagem_creditos;
        private PictureBox botao_voltar_creditos;
        private PictureBox pictureBox1;
    }
}