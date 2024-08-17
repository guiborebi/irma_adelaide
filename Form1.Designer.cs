namespace ProjetoIrmaAdelaide
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagem_titulo_inicio = new System.Windows.Forms.PictureBox();
            this.botao_acessar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_titulo_inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_acessar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagem_titulo_inicio
            // 
            this.imagem_titulo_inicio.BackColor = System.Drawing.Color.Transparent;
            this.imagem_titulo_inicio.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo;
            this.imagem_titulo_inicio.Location = new System.Drawing.Point(85, 34);
            this.imagem_titulo_inicio.Name = "imagem_titulo_inicio";
            this.imagem_titulo_inicio.Size = new System.Drawing.Size(1200, 226);
            this.imagem_titulo_inicio.TabIndex = 0;
            this.imagem_titulo_inicio.TabStop = false;
            this.imagem_titulo_inicio.Click += new System.EventHandler(this.imagem_titulo_Click);
            // 
            // botao_acessar
            // 
            this.botao_acessar.BackColor = System.Drawing.Color.Transparent;
            this.botao_acessar.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_acessar;
            this.botao_acessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_acessar.Location = new System.Drawing.Point(304, 495);
            this.botao_acessar.Name = "botao_acessar";
            this.botao_acessar.Size = new System.Drawing.Size(763, 116);
            this.botao_acessar.TabIndex = 1;
            this.botao_acessar.TabStop = false;
            this.botao_acessar.Click += new System.EventHandler(this.botao_acessar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.descricaoinicial;
            this.pictureBox1.Location = new System.Drawing.Point(89, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1183, 124);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botao_acessar);
            this.Controls.Add(this.imagem_titulo_inicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PROJETO IRMÃ ADELAIDE | INICIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_titulo_inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_acessar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox imagem_titulo_inicio;
        private PictureBox botao_acessar;
        private PictureBox pictureBox1;
    }
}