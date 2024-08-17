namespace ProjetoIrmaAdelaide
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.foto03 = new System.Windows.Forms.PictureBox();
            this.voltar03 = new System.Windows.Forms.PictureBox();
            this.anterior03 = new System.Windows.Forms.PictureBox();
            this.proximo03 = new System.Windows.Forms.PictureBox();
            this.titulo03 = new System.Windows.Forms.PictureBox();
            this.titulo003 = new System.Windows.Forms.Label();
            this.conteudo003 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo03)).BeginInit();
            this.SuspendLayout();
            // 
            // foto03
            // 
            this.foto03.BackColor = System.Drawing.Color.Transparent;
            this.foto03.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.foto031;
            this.foto03.Location = new System.Drawing.Point(1099, 45);
            this.foto03.Name = "foto03";
            this.foto03.Size = new System.Drawing.Size(216, 502);
            this.foto03.TabIndex = 1;
            this.foto03.TabStop = false;
            // 
            // voltar03
            // 
            this.voltar03.BackColor = System.Drawing.Color.Transparent;
            this.voltar03.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_voltar_indice;
            this.voltar03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar03.Location = new System.Drawing.Point(48, 584);
            this.voltar03.Name = "voltar03";
            this.voltar03.Size = new System.Drawing.Size(172, 76);
            this.voltar03.TabIndex = 2;
            this.voltar03.TabStop = false;
            this.voltar03.Click += new System.EventHandler(this.voltar03_Click);
            // 
            // anterior03
            // 
            this.anterior03.BackColor = System.Drawing.Color.Transparent;
            this.anterior03.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_anterior;
            this.anterior03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anterior03.Location = new System.Drawing.Point(270, 584);
            this.anterior03.Name = "anterior03";
            this.anterior03.Size = new System.Drawing.Size(172, 76);
            this.anterior03.TabIndex = 3;
            this.anterior03.TabStop = false;
            this.anterior03.Click += new System.EventHandler(this.anterior03_Click);
            // 
            // proximo03
            // 
            this.proximo03.BackColor = System.Drawing.Color.Transparent;
            this.proximo03.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_proximo;
            this.proximo03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo03.Location = new System.Drawing.Point(450, 584);
            this.proximo03.Name = "proximo03";
            this.proximo03.Size = new System.Drawing.Size(172, 76);
            this.proximo03.TabIndex = 4;
            this.proximo03.TabStop = false;
            this.proximo03.Click += new System.EventHandler(this.proximo03_Click);
            // 
            // titulo03
            // 
            this.titulo03.BackColor = System.Drawing.Color.Transparent;
            this.titulo03.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo_peq;
            this.titulo03.Location = new System.Drawing.Point(667, 565);
            this.titulo03.Name = "titulo03";
            this.titulo03.Size = new System.Drawing.Size(649, 116);
            this.titulo03.TabIndex = 5;
            this.titulo03.TabStop = false;
            // 
            // titulo003
            // 
            this.titulo003.AutoSize = true;
            this.titulo003.BackColor = System.Drawing.Color.Transparent;
            this.titulo003.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo003.Location = new System.Drawing.Point(75, 72);
            this.titulo003.Name = "titulo003";
            this.titulo003.Size = new System.Drawing.Size(947, 34);
            this.titulo003.TabIndex = 6;
            this.titulo003.Text = "3.  LEIA SEMPRE A BULA AO INICIAR O USO DE UM MEDICAMENTO";
            // 
            // conteudo003
            // 
            this.conteudo003.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.conteudo003.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conteudo003.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conteudo003.Location = new System.Drawing.Point(75, 121);
            this.conteudo003.Name = "conteudo003";
            this.conteudo003.ReadOnly = true;
            this.conteudo003.Size = new System.Drawing.Size(976, 404);
            this.conteudo003.TabIndex = 7;
            this.conteudo003.Text = resources.GetString("conteudo003.Text");
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundconteudo;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.conteudo003);
            this.Controls.Add(this.titulo003);
            this.Controls.Add(this.titulo03);
            this.Controls.Add(this.proximo03);
            this.Controls.Add(this.anterior03);
            this.Controls.Add(this.voltar03);
            this.Controls.Add(this.foto03);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "PROJETO IRMÃ ADELAIDE | 3. Leia sempre a bula ao iniciar o uso de um medicamento";
            ((System.ComponentModel.ISupportInitialize)(this.foto03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anterior03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox foto03;
        private PictureBox voltar03;
        private PictureBox anterior03;
        private PictureBox proximo03;
        private PictureBox titulo03;
        private Label titulo003;
        private RichTextBox conteudo003;
    }
}