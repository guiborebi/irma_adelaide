namespace ProjetoIrmaAdelaide
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.imagem_titulo_indice = new System.Windows.Forms.PictureBox();
            this.botao_creditos_indice = new System.Windows.Forms.PictureBox();
            this.fundo_indice = new System.Windows.Forms.PictureBox();
            this.campo_pesquisar = new System.Windows.Forms.TextBox();
            this.lista_orientacoes = new System.Windows.Forms.ListBox();
            this.botao_ajuda = new System.Windows.Forms.PictureBox();
            this.tooltip_ajuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_titulo_indice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_creditos_indice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo_indice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_ajuda)).BeginInit();
            this.SuspendLayout();
            // 
            // imagem_titulo_indice
            // 
            this.imagem_titulo_indice.BackColor = System.Drawing.Color.Transparent;
            this.imagem_titulo_indice.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.imagem_titulo;
            this.imagem_titulo_indice.Location = new System.Drawing.Point(85, 34);
            this.imagem_titulo_indice.Name = "imagem_titulo_indice";
            this.imagem_titulo_indice.Size = new System.Drawing.Size(1204, 226);
            this.imagem_titulo_indice.TabIndex = 0;
            this.imagem_titulo_indice.TabStop = false;
            this.imagem_titulo_indice.Click += new System.EventHandler(this.imagem_titulo_indice_Click);
            // 
            // botao_creditos_indice
            // 
            this.botao_creditos_indice.BackColor = System.Drawing.Color.Transparent;
            this.botao_creditos_indice.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.botao_creditos;
            this.botao_creditos_indice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao_creditos_indice.Location = new System.Drawing.Point(1093, 565);
            this.botao_creditos_indice.Name = "botao_creditos_indice";
            this.botao_creditos_indice.Size = new System.Drawing.Size(186, 93);
            this.botao_creditos_indice.TabIndex = 1;
            this.botao_creditos_indice.TabStop = false;
            this.botao_creditos_indice.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fundo_indice
            // 
            this.fundo_indice.BackColor = System.Drawing.Color.Transparent;
            this.fundo_indice.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.fundo_indice3;
            this.fundo_indice.Location = new System.Drawing.Point(85, 266);
            this.fundo_indice.Name = "fundo_indice";
            this.fundo_indice.Size = new System.Drawing.Size(960, 383);
            this.fundo_indice.TabIndex = 2;
            this.fundo_indice.TabStop = false;
            // 
            // campo_pesquisar
            // 
            this.campo_pesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.campo_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campo_pesquisar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campo_pesquisar.Location = new System.Drawing.Point(208, 286);
            this.campo_pesquisar.MaxLength = 70;
            this.campo_pesquisar.Name = "campo_pesquisar";
            this.campo_pesquisar.Size = new System.Drawing.Size(818, 25);
            this.campo_pesquisar.TabIndex = 1;
            this.campo_pesquisar.TextChanged += new System.EventHandler(this.campo_pesquisar_TextChanged);
            // 
            // lista_orientacoes
            // 
            this.lista_orientacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_orientacoes.CausesValidation = false;
            this.lista_orientacoes.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lista_orientacoes.FormattingEnabled = true;
            this.lista_orientacoes.IntegralHeight = false;
            this.lista_orientacoes.ItemHeight = 32;
            this.lista_orientacoes.Location = new System.Drawing.Point(100, 346);
            this.lista_orientacoes.Name = "lista_orientacoes";
            this.lista_orientacoes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lista_orientacoes.Size = new System.Drawing.Size(926, 288);
            this.lista_orientacoes.TabIndex = 2;
            this.lista_orientacoes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lista_orientacoes_MouseClick);
            this.lista_orientacoes.SelectedIndexChanged += new System.EventHandler(this.lista_orientacoes_SelectedIndexChanged);
            // 
            // botao_ajuda
            // 
            this.botao_ajuda.BackColor = System.Drawing.Color.Transparent;
            this.botao_ajuda.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.ajuda1;
            this.botao_ajuda.Location = new System.Drawing.Point(1051, 268);
            this.botao_ajuda.Name = "botao_ajuda";
            this.botao_ajuda.Size = new System.Drawing.Size(20, 52);
            this.botao_ajuda.TabIndex = 3;
            this.botao_ajuda.TabStop = false;
            this.tooltip_ajuda.SetToolTip(this.botao_ajuda, "Escreva no campo \"FILTRO\" o assunto que deseja pesquisar.");
            // 
            // tooltip_ajuda
            // 
            this.tooltip_ajuda.ToolTipTitle = "AJUDA";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIrmaAdelaide.Properties.Resources.backgroundvermelho1;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.botao_ajuda);
            this.Controls.Add(this.lista_orientacoes);
            this.Controls.Add(this.campo_pesquisar);
            this.Controls.Add(this.fundo_indice);
            this.Controls.Add(this.botao_creditos_indice);
            this.Controls.Add(this.imagem_titulo_indice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "PROJETO IRMÃ ADELAIDE | ÍNDICE";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_titulo_indice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_creditos_indice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo_indice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_ajuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imagem_titulo_indice;
        private PictureBox botao_creditos_indice;
        private PictureBox fundo_indice;
        private TextBox campo_pesquisar;
        private ListBox lista_orientacoes;
        private PictureBox botao_ajuda;
        private ToolTip tooltip_ajuda;
    }
}